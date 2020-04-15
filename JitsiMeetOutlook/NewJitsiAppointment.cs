using System;
using Outlook = Microsoft.Office.Interop.Outlook;
using MessageBox = System.Windows.Forms.MessageBox;

namespace JitsiMeetOutlook
{
    class NewJitsiAppointment
    {
        public NewJitsiAppointment()
        {
            // Get the Application object
            Outlook.Application application = Globals.ThisAddIn.Application;

            try
            {
                // Create meeting object
                Outlook.AppointmentItem newAppointment = (Outlook.AppointmentItem)
                application.CreateItem(Outlook.OlItemType.olAppointmentItem);

                // Appointment details
                newAppointment.Location = "Jitsi Meet";
                newAppointment.Body = "Join the meeting: " + JitsiUrl.generateUrl();

                // Display ribbon group, then the appointment window
                displayRibbonGroup();
                newAppointment.Display(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }

        private void displayRibbonGroup()
        {
            AppointmentRibbonButton individualRibbon = Globals.Ribbons[Globals.ThisAddIn.Application.ActiveInspector()].AppointmentRibbonButton;

            // This list must contain all elements within the ribbon group
            individualRibbon.RoomID.Visible = true;
            individualRibbon.buttonMuteOnStart.Visible = true;
            individualRibbon.buttonNoVideoOnStart.Visible = true;
            individualRibbon.buttonRandomiseRoomID.Visible = true;
            individualRibbon.buttonRequireName.Visible = true;
            individualRibbon.separator1.Visible = true;
        }
    }
}
