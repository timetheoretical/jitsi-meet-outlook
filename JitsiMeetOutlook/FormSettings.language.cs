using System.Collections.Generic;
using System.Text.Json;


namespace JitsiMeetOutlook
{
    partial class FormSettings
    {
        private Dictionary<string, string> languageDropDown = new Dictionary<string, string>();
        private Dictionary<string, string> randomGeneratorModeDropDown = new Dictionary<string, string>();

        private void setLanguage()
        {
            setLanguageTabs();
            setLanguageDropDown();
            setRandomGeneratorMode();

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

        }


        private void setLanguageDropDown()
        {
            JsonElement jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("settings");
            languageDropDown.Add("de", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("de").GetString());
            languageDropDown.Add("en", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("en").GetString());
            languageDropDown.Add("fr", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("fr").GetString());
            languageDropDown.Add("ru", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("ru").GetString());
            languageDropDown.Add("es", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("es").GetString());
            languageDropDown.Add("cz", jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty("cz").GetString());

            this.comboBoxLanguage.Items.Clear();
            this.comboBoxLanguage.Items.AddRange(new object[] {
                languageDropDown["de"],
                languageDropDown["en"],
                languageDropDown["fr"],
                languageDropDown["ru"],
                languageDropDown["es"],
                languageDropDown["cz"]
            });
        }

        private void setLanguageTabs()
        {
            JsonElement jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("settings");
            this.tabPageDomain.Text = jsonUILanguage.GetProperty("tabControlSettings").GetProperty("tabPageDomain").GetString();
            this.tabPageRoomId.Text = jsonUILanguage.GetProperty("tabControlSettings").GetProperty("tabPageRoomId").GetString();
            this.tabPageMeetingOptions.Text = jsonUILanguage.GetProperty("tabControlSettings").GetProperty("tabPageMeetingOptions").GetString();
            this.tabPageLanguage.Text = jsonUILanguage.GetProperty("tabControlSettings").GetProperty("tabPageLanguage").GetString();
        }

        private void setRandomGeneratorMode()
        {
            JsonElement jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("settings");
            randomGeneratorModeDropDown.Add("phrase", jsonUILanguage.GetProperty("comboBoxRandomGeneratorMode").GetProperty("phrase").GetString());
            randomGeneratorModeDropDown.Add("string", jsonUILanguage.GetProperty("comboBoxRandomGeneratorMode").GetProperty("string").GetString());

            this.comboBoxRandomGeneratorMode.Items.Clear();
            this.comboBoxRandomGeneratorMode.Items.AddRange(new object[] {
                randomGeneratorModeDropDown["phrase"],
                randomGeneratorModeDropDown["string"],
            });
        }
    }
}
