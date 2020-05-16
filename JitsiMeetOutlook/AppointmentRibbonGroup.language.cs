using System.Text.Json;

namespace JitsiMeetOutlook
{
    public partial class AppointmentRibbonGroup
    {

        JsonElement jsonUILanguage;
        private void setLanguage()
        {
            setJsonNode();

            this.fieldRoomID.Label = getLanguageValue("fieldRoomID");
            this.fieldRoomID.SuperTip = getLanguageValue("fieldRoomIDSuperTip");
            this.buttonRandomRoomID.Label = getLanguageValue("buttonRandomRoomID");
            this.buttonRequireDisplayName.Label = getLanguageValue("buttonRequireDisplayName");
            this.buttonStartWithAudioMuted.Label = getLanguageValue("buttonStartWithAudioMuted");
            this.buttonStartWithVideoMuted.Label = getLanguageValue("buttonStartWithVideoMuted");

        }


        private void setJsonNode()
        {
            jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("appointmentRibbonGroup");
        }

        private string getLanguageValue(string property)
        {
            return jsonUILanguage.GetProperty(property).GetString();
        }

    }

}
