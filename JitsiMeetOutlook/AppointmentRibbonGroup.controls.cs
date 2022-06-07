using System.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // Assign the domain prevailing at appointment item launch
            Properties.Settings.Default.Reload();
            oldDomain = Properties.Settings.Default.Domain;

            // Assign the relevant appointment item
            Outlook.Inspector inspector = (Outlook.Inspector)this.Context;
            appointmentItem = inspector.CurrentItem as Outlook.AppointmentItem;

            if (appointmentItem.Location == "Jitsi Meet")
            {
                groupJitsiMeetControls.Visible = true;
                groupNewMeeting.Visible = false;
                InitializeRibbonWithCurrentData();
            }
            else
            {
                groupNewMeeting.Visible = true;
                groupJitsiMeetControls.Visible = false;
            }


        }


        private void InitializeRibbonWithCurrentData()
        {
            var roomId = Utils.findRoomId(appointmentItem.Body, oldDomain);
            if (roomId != string.Empty)
            {
                // The Meeting already exists
                // TODO: Not working correctly because edited body are in RTF Format
                // Update Conrol State from the embedded text
                setRoomIdText(roomId);

                var url = Utils.GetUrl(appointmentItem.Body, oldDomain);
                if (Utils.SettingIsActive(url, "requireDisplayName"))
                {
                    buttonRequireDisplayName.Checked = true;
                }
                if (Utils.SettingIsActive(url, "startWithAudioMuted"))
                {
                    buttonStartWithAudioMuted.Checked = true;
                }
                if (Utils.SettingIsActive(url, "startWithVideoMuted"))
                {
                    buttonStartWithVideoMuted.Checked = true;
                }

            }
            else
            {
                // New Meeting
                if (Properties.Settings.Default.roomID.Length == 0)
                {
                    randomiseRoomId();
                }
                else
                {
                    setRoomId(Properties.Settings.Default.roomID);
                }
                if (Properties.Settings.Default.requireDisplayName)
                {
                    toggleRequireName();
                    buttonRequireDisplayName.Checked = true;
                }
                if (Properties.Settings.Default.startWithAudioMuted)
                {
                    toggleMuteOnStart();
                    buttonStartWithAudioMuted.Checked = true;
                }
                if (Properties.Settings.Default.startWithVideoMuted)
                {
                    toggleVideoOnStart();
                    buttonStartWithVideoMuted.Checked = true;
                }
            }

        }

        public async void setRoomId(string newRoomId)
        {
            string newDomain = JitsiUrl.getDomain();
            string oldBody = appointmentItem.Body;

            // Filter room id for legal characters
            string newRoomIdLegal = JitsiUrl.filterLegalCharacters(newRoomId);

            string newBody;
            try
            {
                // Replace old domain for new domain
                newBody = oldBody.Replace(Utils.findRoomId(appointmentItem.Body, oldDomain), newRoomIdLegal);
                newBody = newBody.Replace(oldDomain, newDomain);
                newBody = await generateBody(newRoomIdLegal);
            }
            catch
            {
                // If replacement failed, append new message text
                if (string.IsNullOrWhiteSpace(oldBody))
                {
                    newBody = await generateBody(newRoomIdLegal);
                }
                else
                {
                    newBody = oldBody + "\n" + generateBody(newRoomIdLegal);
                }

                this.buttonStartWithAudioMuted.Checked = false;
                this.buttonStartWithVideoMuted.Checked = false;
                this.buttonRequireDisplayName.Checked = false;
            }

            fieldRoomID.Text = newRoomIdLegal;
            appointmentItem.Body = newBody;

            oldDomain = newDomain;
        }

        public static async Task<string> generateBody(string roomId)
        {
            return Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyMessage")
                + (JitsiUrl.getUrlBase() + roomId)
                + Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyMessagePhone")
                + await Globals.ThisAddIn.JitsiApiService.getPhoneNumbers(roomId)
                + Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyPin")
                + await Globals.ThisAddIn.JitsiApiService.getPIN(roomId)
                + Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyDisclaimer");
        }


        public void randomiseRoomId()
        {
            setRoomId(JitsiUrl.generateRandomId());
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

        private void setRoomIdText(string roomIdText)
        {
            if (roomIdText != null)
            {
                fieldRoomID.Text = roomIdText;
            }
        }

        private void addJitsiMeeting()
        {
            appointmentItem.Location = "Jitsi Meet";
            initialise();

        }

        private void toggleSetting(string setting)
        {
            // Find Jitsi URL in message
            string oldBody = appointmentItem.Body;
            string urlMatch = Utils.GetUrl(oldBody, oldDomain);

            // Remove setting if present
            string urlNew;
            if (Utils.SettingIsActive(urlMatch, setting))
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
