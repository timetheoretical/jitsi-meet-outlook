using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace JitsiMeetOutlook
{
    public partial class AppointmentRibbonButton
    {
        private void AppointmentRibbonButton_Load(object sender, RibbonUIEventArgs e)
        {

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
    }
}
