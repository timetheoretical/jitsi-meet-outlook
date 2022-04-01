using System;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;

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
            Dictionary<string, byte[]> languages = new Dictionary<string, byte[]>();
            languages.Add("en", Resources.languages.en);
            languages.Add("de", Resources.languages.de);
            languages.Add("fr", Resources.languages.fr);
            languages.Add("ru", Resources.languages.ru);
            languages.Add("es", Resources.languages.es);
            languages.Add("cz", Resources.languages.cz);

            if (languages.ContainsKey(language))
            {
                return languages[language];
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

        public string getElementTranslation(string jsonGroup, string jsonElement)
        {
            return languageJsonRoot.GetProperty(jsonGroup).GetProperty(jsonElement).GetString();
        }

    }

}
