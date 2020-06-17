using System.Collections.Generic;
using System.Text.Json;


namespace JitsiMeetOutlook
{
    partial class FormSettings
    {
        private Dictionary<string, string> languageDropDown = new Dictionary<string, string>();

        private void setLanguage()
        {
            setLanguageTabs();
            setLanguageDropDown();

            this.groupBoxDomain.Text = Globals.ThisAddIn.getElementTranslation("settings", "groupBoxDomain");
            this.radioButtonDefaultDomain.Text = Globals.ThisAddIn.getElementTranslation("settings", "radioButtonDefaultDomain");
            this.radioButtonCustomDomain.Text = Globals.ThisAddIn.getElementTranslation("settings", "radioButtonCustomDomain");
            this.groupBoxDefaultRoomID.Text = Globals.ThisAddIn.getElementTranslation("settings", "groupBoxDefaultRoomID");
            this.radioButtonRandomRoomID.Text = Globals.ThisAddIn.getElementTranslation("settings", "radioButtonRandomRoomID");
            this.radioButtonCustomRoomID.Text = Globals.ThisAddIn.getElementTranslation("settings", "radioButtonCustomRoomID");
            this.groupBoxToggleDefaults.Text = Globals.ThisAddIn.getElementTranslation("settings", "groupBoxToggleDefaults");
            this.labelToggled.Text = Globals.ThisAddIn.getElementTranslation("settings", "labelToggled");
            this.labelUntoggled.Text = Globals.ThisAddIn.getElementTranslation("settings", "labelUntoggled");
            this.labelRequireDisplayName.Text = Globals.ThisAddIn.getElementTranslation("settings", "labelRequireDisplayName");
            this.labelStartWithAudioMuted.Text = Globals.ThisAddIn.getElementTranslation("settings", "labelStartWithAudioMuted");
            this.labelStartWithVideoMuted.Text = Globals.ThisAddIn.getElementTranslation("settings", "labelStartWithVideoMuted");
            this.groupBoxLanguage.Text = Globals.ThisAddIn.getElementTranslation("settings", "groupBoxLanguage");
            this.comboBoxLanguage.Items.Clear();
            this.comboBoxLanguage.Items.AddRange(new object[] {
                languageDropDown["en"],
                languageDropDown["fr"],
                languageDropDown["ru"]
            });

        }


        private void setLanguageDropDown()
        {
            JsonElement jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("settings");
            languageDropDown.Add("en", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("en").GetString());
            languageDropDown.Add("fr", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("fr").GetString());
            languageDropDown.Add("ru", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("ru").GetString());
        }

        private void setLanguageTabs()
        {
            JsonElement jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("settings");
            this.tabPageDomain.Text = jsonUILanguage.GetProperty("tabControlSettings").GetProperty("tabPageDomain").GetString();
            this.tabPageRoomId.Text = jsonUILanguage.GetProperty("tabControlSettings").GetProperty("tabPageRoomId").GetString();
            this.tabPageMeetingOptions.Text = jsonUILanguage.GetProperty("tabControlSettings").GetProperty("tabPageMeetingOptions").GetString();
            this.tabPageLanguage.Text = jsonUILanguage.GetProperty("tabControlSettings").GetProperty("tabPageLanguage").GetString();
        }
    }
}
