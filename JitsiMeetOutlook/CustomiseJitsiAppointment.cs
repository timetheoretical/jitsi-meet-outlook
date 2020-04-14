using System.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Text.RegularExpressions;

namespace JitsiMeetOutlook
{
    class CustomiseJitsiAppointment
    {
        AppointmentRibbonButton appointmentRibbon;
        Outlook.Application application;
        Outlook.AppointmentItem appointmentItem;

        public CustomiseJitsiAppointment(AppointmentRibbonButton appointmentRibbon)
        {
            this.appointmentRibbon = appointmentRibbon;
            // Get the Application object
            application = Globals.ThisAddIn.Application;
            // Get the active Inspector object
            Outlook.Inspector inspector = application.ActiveInspector();
            appointmentItem = inspector.CurrentItem as Outlook.AppointmentItem;
        }

        public void setRoomId(string newRoomId)
        {
            string oldBody = appointmentItem.Body;

            string newBody = oldBody.Replace(findRoomId(), newRoomId);

            appointmentRibbon.RoomID.Text = newRoomId;
            appointmentItem.Body = newBody;
         }

        public string findRoomId()
        {
            string roomId = Regex.Match(appointmentItem.Body, "(?<=meet\\.jit\\.si/)\\S+?(?=(#config|&config|\\s))").Value; // Match all non-blanks after jitsi url and before config or end
            return roomId;
        }

        public void randomiseRoomId()
        {
            setRoomId(JitsiUrl.generateRoomId());
        }

        public void toggleMuteOnStart()
        {
            toggleSetting("startWithAudioMuted");
        }
        public void togglVideoOnStart()
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
            string urlMatch = Regex.Match(oldBody, "meet\\.jit\\.si/\\S+").Value;

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
