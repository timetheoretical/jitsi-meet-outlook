using System.Text.Json;


namespace JitsiMeetOutlook
{
    partial class FormSettings
    {
        JsonElement jsonUILanguage;
        private void setLanguage()
        {
            setJsonNode();

            this.groupBoxDomain.Text = getLanguageValue("groupBoxDomain");
            this.radioButtonDefaultDomain.Text = getLanguageValue("radioButtonDefaultDomain");
            this.radioButtonCustomDomain.Text = getLanguageValue("radioButtonCustomDomain");
            this.groupBoxDefaultRoomID.Text = getLanguageValue("groupBoxDefaultRoomID");
            this.radioButtonRandomRoomID.Text = getLanguageValue("radioButtonRandomRoomID");
            this.radioButtonCustomRoomID.Text = getLanguageValue("radioButtonCustomRoomID");
            this.groupBoxToggleDefaults.Text = getLanguageValue("groupBoxToggleDefaults");
            this.labelToggled.Text = getLanguageValue("labelToggled");
            this.labelUntoggled.Text = getLanguageValue("labelUntoggled");
            this.labelRequireDisplayName.Text = getLanguageValue("labelRequireDisplayName");
            this.labelStartWithAudioMuted.Text = getLanguageValue("labelStartWithAudioMuted");
            this.labelStartWithVideoMuted.Text = getLanguageValue("labelStartWithVideoMuted");

        }


        private void setJsonNode()
        {
            jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("settings");
        }

        private string getLanguageValue(string property)
        {
            return jsonUILanguage.GetProperty(property).GetString();
        }
    }
}
