using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;
/**
 * Copied from https://github.com/phw198/OutlookGoogleCalendarSync/blob/master/src/OutlookGoogleCalendarSync/Recurrence.cs
 * Please retain the Copyright notice: MPL-2
 * https://github.com/phw198/OutlookGoogleCalendarSync/blob/master/license.md
 */

namespace JitsiMeetOutlook
{
    class Recurrence
    {
        /*
         * Recurrence rule standards for iCalendar: http://www.ietf.org/rfc/rfc2445 
         */
        private static Recurrence instance;
        public static Recurrence Instance
        {
            get
            {
                if (instance == null) instance = new Recurrence();
                return instance;
            }
        }

        public Recurrence() { }

        private Dictionary<String, String> rrule = new Dictionary<String, String>();

        /// <summary>
        /// Maps <see cref="Microsoft.Office.Interop.Outlook.RecurrencePattern"/> to RRule (<see href="https://datatracker.ietf.org/doc/html/rfc5545"/>)
        /// </summary>
        /// <param name="oPattern">Recurrence Pattern</param>
        /// <returns>RFC compliant RRule</returns>
        public string buildRrule(RecurrencePattern oPattern)
        {
            rrule = new Dictionary<String, String>();

            switch (oPattern.RecurrenceType)
            {
                case OlRecurrenceType.olRecursDaily:
                    {
                        addRule(rrule, "FREQ", "DAILY");
                        setInterval(oPattern.Interval);
                        break;
                    }

                case OlRecurrenceType.olRecursWeekly:
                    {
                        addRule(rrule, "FREQ", "WEEKLY");
                        setInterval(oPattern.Interval);
                        if ((oPattern.DayOfWeekMask & (oPattern.DayOfWeekMask - 1)) != 0)
                        { //is not a power of 2 (i.e. not just a single day) 
                            // Need to work out "BY" pattern
                            // Eg "BYDAY=MO,TU,WE,TH,FR"
                            addRule(rrule, "BYDAY", string.Join(",", getByDay(oPattern.DayOfWeekMask).ToArray()));
                        }
                        break;
                    }

                case OlRecurrenceType.olRecursMonthly:
                    {
                        addRule(rrule, "FREQ", "MONTHLY");
                        setInterval(oPattern.Interval);
                        //Outlook runs on last day of month if day doesn't exist; Google doesn't run at all - so fix
                        if (oPattern.PatternStartDate.Day > 28)
                        {
                            addRule(rrule, "BYDAY", "SU,MO,TU,WE,TH,FR,SA");
                            addRule(rrule, "BYSETPOS", "-1");
                        }
                        break;
                    }

                case OlRecurrenceType.olRecursMonthNth:
                    {
                        addRule(rrule, "FREQ", "MONTHLY");
                        setInterval(oPattern.Interval);
                        addRule(rrule, "BYDAY", string.Join(",", getByDay(oPattern.DayOfWeekMask).ToArray()));
                        addRule(rrule, "BYSETPOS", (oPattern.Instance == 5) ? "-1" : oPattern.Instance.ToString());
                        break;
                    }

                case OlRecurrenceType.olRecursYearly:
                    {
                        addRule(rrule, "FREQ", "YEARLY");
                        //Google interval is years, Outlook is months
                        if (oPattern.Interval != 12)
                            addRule(rrule, "INTERVAL", (oPattern.Interval / 12).ToString());
                        break;
                    }

                case OlRecurrenceType.olRecursYearNth:
                    {
                        //Issue 445: Outlook incorrectly surfaces 12 monthly recurrences as olRecursYearNth, so we'll undo that.
                        //In addition, many apps, indeed even the Google webapp, doesn't display a yearly recurrence rule properly 
                        //despite actually showing the events on the right dates.
                        //So to make OGCS work better with apps that aren't providing full iCal functionality, we'll translate this 
                        //into a monthly recurrence instead.
                        addRule(rrule, "FREQ", "MONTHLY");
                        addRule(rrule, "INTERVAL", oPattern.Interval.ToString());

                        /*Strictly, what we /should/ be doing is:
                        addRule(rrule, "FREQ", "YEARLY");
                        if (oPattern.Interval != 12)
                            addRule(rrule, "INTERVAL", (oPattern.Interval / 12).ToString());
                        addRule(rrule, "BYMONTH", oPattern.MonthOfYear.ToString());
                        */
                        if (oPattern.DayOfWeekMask != (OlDaysOfWeek)127)
                        { //If not every day of week, define which ones
                            addRule(rrule, "BYDAY", string.Join(",", getByDay(oPattern.DayOfWeekMask).ToArray()));
                        }
                        addRule(rrule, "BYSETPOS", (oPattern.Instance == 5) ? "-1" : oPattern.Instance.ToString());
                        break;
                    }
            }

            if (!oPattern.NoEndDate)
            {
                addRule(rrule, "UNTIL", Recurrence.IANAdate(oPattern.PatternEndDate.ToUniversalTime()));
            }
            return string.Join(";", rrule.Select(x => x.Key + "=" + x.Value).ToArray());
        }

        private Dictionary<String, String> explodeRrule(IList<String> allRules)
        {
            foreach (String rrule in allRules)
            {
                if (rrule.StartsWith("RRULE:"))
                {
                    String[] rrules = rrule.TrimStart("RRULE:".ToCharArray()).Split(';');
                    Dictionary<String, String> rules = new Dictionary<String, String>();
                    for (int r = 0; r < rrules.Count(); r++)
                    {
                        String[] ruleKVPs = rrules[r].Split('=');
                        rules.Add(ruleKVPs[0], ruleKVPs[1]);
                    }
                    return rules;
                }
            }
            // Warn("There aren't any RRULEs present. Outlook doesn't support this: https://support.microsoft.com/en-gb/kb/2643084");
            //foreach (String rule in allRules)
            //{
            //    log.Debug("rule: " + rule);
            //}
            return null;
        }

        private void addRule(Dictionary<string, string> ruleBook, string key, string value)
        {
            ruleBook.Add(key, value);
        }

        private void setInterval(int interval)
        {
            if (interval > 1) addRule(rrule, "INTERVAL", interval.ToString());
        }

        private static List<String> getByDay(OlDaysOfWeek dowMask)
        {
            List<String> byDay = new List<String>();
            byDay.Add(((dowMask & OlDaysOfWeek.olMonday) != 0) ? "MO" : "");
            byDay.Add(((dowMask & OlDaysOfWeek.olTuesday) != 0) ? "TU" : "");
            byDay.Add(((dowMask & OlDaysOfWeek.olWednesday) != 0) ? "WE" : "");
            byDay.Add(((dowMask & OlDaysOfWeek.olThursday) != 0) ? "TH" : "");
            byDay.Add(((dowMask & OlDaysOfWeek.olFriday) != 0) ? "FR" : "");
            byDay.Add(((dowMask & OlDaysOfWeek.olSaturday) != 0) ? "SA" : "");
            byDay.Add(((dowMask & OlDaysOfWeek.olSunday) != 0) ? "SU" : "");
            byDay = byDay.Where(s => !string.IsNullOrEmpty(s)).ToList();
            return byDay;
        }
        private static OlDaysOfWeek getDOWmask(Dictionary<String, String> ruleBook)
        {
            OlDaysOfWeek dowMask = 0;
            if (ruleBook.ContainsKey("BYDAY")) dowMask = getDOWmask(ruleBook["BYDAY"]);
            return dowMask;
        }
        private static OlDaysOfWeek getDOWmask(String byDay)
        {
            OlDaysOfWeek dowMask = 0;
            if (byDay.Contains("MO")) dowMask |= OlDaysOfWeek.olMonday;
            if (byDay.Contains("TU")) dowMask |= OlDaysOfWeek.olTuesday;
            if (byDay.Contains("WE")) dowMask |= OlDaysOfWeek.olWednesday;
            if (byDay.Contains("TH")) dowMask |= OlDaysOfWeek.olThursday;
            if (byDay.Contains("FR")) dowMask |= OlDaysOfWeek.olFriday;
            if (byDay.Contains("SA")) dowMask |= OlDaysOfWeek.olSaturday;
            if (byDay.Contains("SU")) dowMask |= OlDaysOfWeek.olSunday;
            return dowMask;
        }

        public static String IANAdate(DateTime dt)
        {
            return dt.ToString("yyyyMMddTHHmmssZ");
        }
    }
}