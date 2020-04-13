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
                newAppointment.Display(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }
    }
}
