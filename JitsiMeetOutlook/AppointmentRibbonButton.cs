using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace JitsiMeetOutlook
{
    public partial class AppointmentRibbonButton
    {
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
            CustomiseJitsiAppointment customAppointment = new CustomiseJitsiAppointment(this);
            customAppointment.randomiseRoomId();
        }

        private void buttonRequireName_Click(object sender, RibbonControlEventArgs e)
        {
            CustomiseJitsiAppointment customAppointment = new CustomiseJitsiAppointment(this);
            customAppointment.toggleRequireName();
        }

        private void buttonMuteOnStart_Click(object sender, RibbonControlEventArgs e)
        {
            CustomiseJitsiAppointment customAppointment = new CustomiseJitsiAppointment(this);
            customAppointment.toggleMuteOnStart();
        }

        private void RoomID_TextChanged(object sender, RibbonControlEventArgs e)
        {
            CustomiseJitsiAppointment customAppointment = new CustomiseJitsiAppointment(this);
            customAppointment.setRoomId(RoomID.Text);
        }

        private void buttonNoVideoOnStart_Click(object sender, RibbonControlEventArgs e)
        {
            CustomiseJitsiAppointment customAppointment = new CustomiseJitsiAppointment(this);
            customAppointment.toggleVideoOnStart();
        }

        private void displayRibbonGroup()
        {
            if (this.Context is Outlook.Inspector)
            {
                Outlook.Inspector inspector = (Outlook.Inspector)this.Context;

                if (Globals.ThisAddIn.ShowRibbonAppointment)
                {
                    AppointmentRibbonButton individualRibbon = Globals.Ribbons[inspector].AppointmentRibbonButton;
                    individualRibbon.groupJitsiMeet.Visible = true;
                }
            }
        }
    }
}
