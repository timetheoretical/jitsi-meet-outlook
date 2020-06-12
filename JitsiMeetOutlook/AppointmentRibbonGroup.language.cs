using System.Text.Json;

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

        }
    }

}
