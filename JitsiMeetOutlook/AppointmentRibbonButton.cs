using Microsoft.Office.Tools.Ribbon;

namespace JitsiMeetOutlook
{
    public partial class AppointmentRibbonButton
    {

        private void AppointmentRibbonButton_Load(object sender, RibbonUIEventArgs e)
        {
            displayRibbonGroup();
            initialise();
        }

        private void buttonDialogLauncher_Click(object sender, RibbonControlEventArgs e)
        {

            FormSettings settingsWindow = new FormSettings();
            settingsWindow.Show();
        }

        private void buttonCustomiseJitsiMeeting_Click(object sender, RibbonControlEventArgs e)
        {
            randomiseRoomId();
        }

        private void buttonRequireName_Click(object sender, RibbonControlEventArgs e)
        {
            toggleRequireName();
        }

        private void buttonMuteOnStart_Click(object sender, RibbonControlEventArgs e)
        {
            toggleMuteOnStart();
        }

        private void RoomID_TextChanged(object sender, RibbonControlEventArgs e)
        {
            setRoomId(RoomID.Text);
        }

        private void buttonNoVideoOnStart_Click(object sender, RibbonControlEventArgs e)
        {
            toggleVideoOnStart();
        }

        private void displayRibbonGroup()
        {
            if(Globals.ThisAddIn.ShowRibbonAppointment)
            {
                groupJitsiMeet.Visible = true;
            }
        }
    }
}
