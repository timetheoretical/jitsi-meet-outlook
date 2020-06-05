using System;
using System.Text;
using System.Text.Json;

namespace JitsiMeetOutlook
{
    public partial class ThisAddIn
    {
        private JsonElement languageJsonRoot;

        private void readLanguageJson()
        {
            try
            {
                byte[] jsonFile = findJson(Properties.Settings.Default.language);
                string jsonString = Encoding.UTF8.GetString(jsonFile);

                JsonDocument document = JsonDocument.Parse(jsonString);
                languageJsonRoot = document.RootElement;
            }
            catch (Exception ex)
            {
                //Do nothing
            }

        }

        private byte[] findJson(string language)
        {
            if (language == "en")
            {
                return Resources.languages.en;
            }
            else if (language == "fr")
            {
                return Resources.languages.fr;
            }
            else if (language == "ru")
            {
                return Resources.languages.ru;
            }
            else
            {
                return null;
            }
        }

        public JsonElement getLanguageJsonRoot()
        {
            return languageJsonRoot;
        }

    }

}
