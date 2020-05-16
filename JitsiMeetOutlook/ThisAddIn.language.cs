using System;
using System.Text;
using System.Text.Json;

namespace JitsiMeetOutlook
{
    public partial class ThisAddIn
    {

        // Load JSON file to memory
        // create public function to get this file

        private JsonElement languageJsonRoot;
        private void setLanguage()
        {
           // this.buttonRandomRoomID.Label = readJson();

        }


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
                return Resources.languages.fr;
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
