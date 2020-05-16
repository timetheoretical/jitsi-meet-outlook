using Microsoft.Office.Tools.Ribbon;

namespace JitsiMeetOutlook
{
    public partial class AppointmentRibbonGroup
    {

        private void AppointmentRibbonGroup_Load(object sender, RibbonUIEventArgs e)
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

        private void buttonRequireDisplayName_Click(object sender, RibbonControlEventArgs e)
        {
            toggleRequireName();
        }

        private void buttonStartWithAudioMuted_Click(object sender, RibbonControlEventArgs e)
        {
            toggleMuteOnStart();
        }

        private void RoomID_TextChanged(object sender, RibbonControlEventArgs e)
        {
            setRoomId(fieldRoomID.Text);
        }

        private void buttonStartWithVideoMuted_Click(object sender, RibbonControlEventArgs e)
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
