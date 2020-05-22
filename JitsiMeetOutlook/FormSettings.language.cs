using System.Linq;
using System.Collections.Generic;
using System.Text.Json;


namespace JitsiMeetOutlook
{
    partial class FormSettings
    {
        private JsonElement jsonUILanguage;
        private Dictionary<string, string> languageDropDown = new Dictionary<string, string>();

        private void setLanguage()
        {
            setJsonNode();
            setlanguageDropDown();

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
            this.groupBoxLanguage.Text = getLanguageValue("groupBoxLanguage");
            this.comboBoxLanguage.Items.Clear();
            this.comboBoxLanguage.Items.AddRange(new object[] {
                languageDropDown["en"],
                languageDropDown["fr"]
            });

        }


        private void setJsonNode()
        {
            jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("settings");
        }

        private void setlanguageDropDown()
        {
            languageDropDown.Add("en", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("en").GetString());
            languageDropDown.Add("fr", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("fr").GetString());
        }

        private string getLanguageValue(string property)
        {
            return jsonUILanguage.GetProperty(property).GetString();
        }
    }
}
