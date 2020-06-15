using System.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Text.RegularExpressions;

namespace JitsiMeetOutlook
{
    public partial class AppointmentRibbonGroup
    {
        private Outlook.AppointmentItem appointmentItem;
        private string oldDomain;

        private void initialise()
        {
            // Set language
            setLanguage();

            // Assign the relevant appointment item
            Outlook.Inspector inspector = (Outlook.Inspector)this.Context;
            appointmentItem = inspector.CurrentItem as Outlook.AppointmentItem;

            // Assign the domain prevailing at appointment item launch
            Properties.Settings.Default.Reload();
            oldDomain = Properties.Settings.Default.Domain;
        }

        public void setRoomId(string newRoomId)
        {
            string newDomain = JitsiUrl.getDomain();
            string oldBody = appointmentItem.Body;

            // Filter room id for legal characters
            string newRoomIdLegal = JitsiUrl.filterLegalCharacters(newRoomId);

            // Replace old domain for new domain
            string newBody = oldBody.Replace(findRoomId(), newRoomIdLegal);
            newBody = newBody.Replace(oldDomain, newDomain);

            fieldRoomID.Text = newRoomIdLegal;
            appointmentItem.Body = newBody;

            oldDomain = newDomain;
         }


        private string escapeDomain()
        {
            string escapedDomain = Regex.Escape(oldDomain);
            if (!escapedDomain.EndsWith("/"))
            {
                escapedDomain += "/";
            }
            return escapedDomain;
        }

        public string findRoomId()
        {
            string roomId = Regex.Match(appointmentItem.Body, "(?<=" + escapeDomain() + ")\\S+?(?=(#config|&config|\\s))").Value; // Match all non-blanks after jitsi url and before config or end
            return roomId;
        }

        public void randomiseRoomId()
        {
            setRoomId(JitsiUrl.generateRandomPhrase());
        }

        public void toggleMuteOnStart()
        {
            toggleSetting("startWithAudioMuted");
        }
        public void toggleVideoOnStart()
        {
            toggleSetting("startWithVideoMuted");
        }

        public void toggleRequireName()
        {
            toggleSetting("requireDisplayName");
        }

        private void toggleSetting(string setting)
        {
            // Find Jitsi URL in message
            string oldBody = appointmentItem.Body;
            string urlMatch = Regex.Match(oldBody, escapeDomain() + "\\S+").Value;

            // Remove setting if present
            string urlNew;
            if (urlMatch.Contains("config." + setting + "=true"))
            {
                urlNew = Regex.Replace(urlMatch, "(#|&)config\\." + setting + "=true", "");
            } 
            
            // Otherwise add
            else
            {
                if (urlMatch.Contains("#config"))
                {
                    urlNew = urlMatch + "&config." + setting + "=true";
                }
                else
                {
                    urlNew = urlMatch + "#config." + setting + "=true";
                }
            }

            string newBody = oldBody.Replace(urlMatch, fixUrl(urlNew));
            appointmentItem.Body = newBody;
        }

        private string fixUrl(string url)
        {
            string fixedUrl = url;

            // Make sure settings appear correctly
            int countHashConfig = url.Count(f => f == '#');
            int countAndConfig = url.Count(f => f == '&');

            if (countHashConfig == 0 && countAndConfig == 1)
            {
                fixedUrl = url.Replace("&config", "#config");
            }

            return fixedUrl;
        }
    }
}
