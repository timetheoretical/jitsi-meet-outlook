using System.Text.Json;

namespace JitsiMeetOutlook
{
    public partial class CalendarRibbonButton
    {
        JsonElement jsonUILanguage;
        private void setLanguage()
        {
            setJsonNode();

            this.buttonNewJitsiMeeting.Label = getLanguageValue("buttonNewJitsiMeeting");
        }


        private void setJsonNode()
        {
            jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("calendarRibbonButton");
        }

        private string getLanguageValue(string property)
        {
            return jsonUILanguage.GetProperty(property).GetString();
        }
    }
}
