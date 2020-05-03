using System;
using Outlook = Microsoft.Office.Interop.Outlook;
using MessageBox = System.Windows.Forms.MessageBox;

namespace JitsiMeetOutlook
{
    class NewJitsiAppointment
    {

        private Outlook.AppointmentItem newAppointment;
        private AppointmentRibbonButton thisRibbon;

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
                findThisRibbon();
                setRequireDisplayName();
                setStartWithAudioMuted();
                setStartWithVideoMuted();
                setRoomIdText(jitsiRoomId);

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }

        private void findThisRibbon()
        {
            Outlook.Inspector inspector = newAppointment.GetInspector; // Only works after appointment is displayed to user
            thisRibbon = Globals.Ribbons[inspector].AppointmentRibbonButton;
        }
        private void setRoomIdText(string roomIdText)
        {
            if (roomIdText != null)
            {
                thisRibbon.RoomID.Text = roomIdText;
            }
        }


        private void setRequireDisplayName()
        {
            if (Properties.Settings.Default.requireDisplayName)
            {
                thisRibbon.toggleRequireName();
                thisRibbon.buttonRequireName.Checked = true;
            }
        }

        private void setStartWithAudioMuted()
        {
            if (Properties.Settings.Default.startWithAudioMuted)
            {
                thisRibbon.toggleMuteOnStart();
                thisRibbon.buttonMuteOnStart.Checked = true;
            }
        }

        private void setStartWithVideoMuted()
        {
            if (Properties.Settings.Default.startWithVideoMuted)
            {
                thisRibbon.toggleVideoOnStart();
                thisRibbon.buttonNoVideoOnStart.Checked = true;
            }
        }

    }
}
