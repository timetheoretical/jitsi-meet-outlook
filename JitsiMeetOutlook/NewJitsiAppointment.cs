using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                //newAppointment.Start = DateTime.Now.AddHours(2);
                //newAppointment.End = DateTime.Now.AddHours(3);
                newAppointment.Location = "Jitsi Meet";
                newAppointment.Body = "Join the meeting: " + JitsiUrl.generateUrl();
                //newAppointment.AllDayEvent = false;
                //newAppointment.Subject = "Group Project";
                //newAppointment.Recipients.Add("Roger Harui");

                // Recipients
                /*
                Outlook.Recipients sentTo = newAppointment.Recipients;
                Outlook.Recipient sentInvite = null;

                sentInvite = sentTo.Add("Holly Holt");
                sentInvite.Type = (int)Outlook.OlMeetingRecipientType.olRequired;
                sentInvite = sentTo.Add("David Junca");
                sentInvite.Type = (int)Outlook.OlMeetingRecipientType.olOptional;
                sentTo.ResolveAll();
                */

                // Save and display meeting event
                //newAppointment.Save();
                newAppointment.Display(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }
    }
}
