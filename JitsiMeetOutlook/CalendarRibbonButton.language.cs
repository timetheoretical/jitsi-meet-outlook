using System.Text.Json;
using System;
using System.IO;
using System.Drawing;

namespace JitsiMeetOutlook
{
    public partial class CalendarRibbonButton
    {
        private void setLanguage()
        {
            this.JitsiMeet.Label = Properties.Settings.Default.appName;
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.meetingButtonLabel))
            {
                this.buttonNewJitsiMeeting.Label = Globals.ThisAddIn.getElementTranslation("calendarRibbonButton", "buttonNewJitsiMeeting");
            }
            else
            {
                this.buttonNewJitsiMeeting.Label = Properties.Settings.Default.meetingButtonLabel;
            }
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.meetingButtonLogo))
            {
                // See https://stackoverflow.com/a/31962116
                byte[] bytes = Convert.FromBase64String(Properties.Settings.Default.meetingButtonLogo);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    this.buttonNewJitsiMeeting.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
