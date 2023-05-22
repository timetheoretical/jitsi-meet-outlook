using System.Text.Json;
using System;
using System.IO;
using System.Drawing;

namespace JitsiMeetOutlook
{
    public partial class AppointmentRibbonGroup
    {

        private void setLanguage()
        {
            this.fieldRoomID.Label = Globals.ThisAddIn.getElementTranslation("appointmentRibbonGroup", "fieldRoomID");
            this.fieldRoomID.SuperTip = Globals.ThisAddIn.getElementTranslation("appointmentRibbonGroup", "fieldRoomIDSuperTip");
            this.buttonRandomRoomID.Label = Globals.ThisAddIn.getElementTranslation("appointmentRibbonGroup", "buttonRandomRoomID");
            this.buttonRequireDisplayName.Label = Globals.ThisAddIn.getElementTranslation("appointmentRibbonGroup", "buttonRequireDisplayName");
            this.buttonStartWithAudioMuted.Label = Globals.ThisAddIn.getElementTranslation("appointmentRibbonGroup", "buttonStartWithAudioMuted");
            this.buttonStartWithVideoMuted.Label = Globals.ThisAddIn.getElementTranslation("appointmentRibbonGroup", "buttonStartWithVideoMuted");
            this.groupJitsiMeetControls.Label = Properties.Settings.Default.appName;
            this.groupNewMeeting.Label = Properties.Settings.Default.appName;
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.meetingButtonLabel))
            {
                this.buttonNewJitsiMeeting.Label = Globals.ThisAddIn.getElementTranslation("calendarRibbonButton", "buttonNewJitsiMeeting");
            }
            else
            {
                this.buttonNewJitsiMeeting.Label = Properties.Settings.Default.meetingButtonLabel;
            }
            if (! string.IsNullOrWhiteSpace(Properties.Settings.Default.meetingButtonLogo))
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
