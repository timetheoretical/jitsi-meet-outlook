using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace JitsiMeetOutlook
{
    public partial class AppointmentRibbonButton
    {

        private CustomiseJitsiAppointment customAppointment;

        private void AppointmentRibbonButton_Load(object sender, RibbonUIEventArgs e)
        {
            displayRibbonGroup();
        }

        private void buttonDialogLauncher_Click(object sender, RibbonControlEventArgs e)
        {

            FormSettings settingsWindow = new FormSettings();
            settingsWindow.Show();
        }

        private void buttonCustomiseJitsiMeeting_Click(object sender, RibbonControlEventArgs e)
        {
            ensureCustomExists();
            customAppointment.randomiseRoomId();
        }

        private void buttonRequireName_Click(object sender, RibbonControlEventArgs e)
        {
            ensureCustomExists();
            customAppointment.toggleRequireName();
        }

        private void buttonMuteOnStart_Click(object sender, RibbonControlEventArgs e)
        {
            ensureCustomExists();
            customAppointment.toggleMuteOnStart();
        }

        private void RoomID_TextChanged(object sender, RibbonControlEventArgs e)
        {
            ensureCustomExists();
            customAppointment.setRoomId(RoomID.Text);
        }

        private void buttonNoVideoOnStart_Click(object sender, RibbonControlEventArgs e)
        {
            ensureCustomExists();
            customAppointment.toggleVideoOnStart();
        }

        private AppointmentRibbonButton thisRibbon()
        {
            Outlook.Inspector inspector = (Outlook.Inspector)this.Context;
            AppointmentRibbonButton individualRibbon = Globals.Ribbons[inspector].AppointmentRibbonButton;           

            return individualRibbon;
        }

        private void displayRibbonGroup()
        {
            thisRibbon().groupJitsiMeet.Visible = true;
        }

        private void ensureCustomExists()
        {
            if (customAppointment == null)
            {
                customAppointment = new CustomiseJitsiAppointment(this);
            }
        }
    }
}
