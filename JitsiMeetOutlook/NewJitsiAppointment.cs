using System;
using Outlook = Microsoft.Office.Interop.Outlook;
using MessageBox = System.Windows.Forms.MessageBox;

namespace JitsiMeetOutlook
{
    class NewJitsiAppointment
    {

        private Outlook.AppointmentItem newAppointment;
        public NewJitsiAppointment()
        {
            // Get the Application object
            Outlook.Application application = Globals.ThisAddIn.Application;

            try
            {
                // Generate meeting ID
                string jitsiRoomId = JitsiUrl.generateRoomId();

                // Create meeting object
                newAppointment = (Outlook.AppointmentItem) application.CreateItem(Outlook.OlItemType.olAppointmentItem);


                // Appointment details
                newAppointment.Location = "Jitsi Meet";
                newAppointment.Body = "Join the meeting: " + (JitsiUrl.getUrlBase() + jitsiRoomId);

                // Display ribbon group, then the appointment window
                Globals.ThisAddIn.ShowRibbonAppointment = true;
                newAppointment.Display(false);
                Globals.ThisAddIn.ShowRibbonAppointment = false;

                // Set Room ID field
                setRoomIdText(jitsiRoomId);

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }

        private void setRoomIdText(string roomIdText)
        {
            Outlook.Inspector inspector = newAppointment.GetInspector;
            AppointmentRibbonButton individualRibbon = Globals.Ribbons[inspector].AppointmentRibbonButton;
            if (roomIdText != null)
            {
                individualRibbon.RoomID.Text = roomIdText;
            }
        }
    }
}
