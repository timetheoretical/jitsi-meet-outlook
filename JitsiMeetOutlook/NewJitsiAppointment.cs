using System;
using Outlook = Microsoft.Office.Interop.Outlook;
using MessageBox = System.Windows.Forms.MessageBox;

namespace JitsiMeetOutlook
{
    class NewJitsiAppointment
    {

        private Outlook.AppointmentItem newAppointment;
        private AppointmentRibbonGroup thisRibbon;

        public NewJitsiAppointment()
        {
            // Get the Application object
            Outlook.Application application = Globals.ThisAddIn.Application;

            DateTime dateNull = new DateTime(4501, 1, 1, 0, 0, 0);
            Outlook.Explorer expl = application.ActiveExplorer();
            Outlook.View view = expl.CurrentView as Outlook.View;

            try
            {
                // Generate meeting ID
                string jitsiRoomId = getRoomId();

                // Create meeting object
                newAppointment = (Outlook.AppointmentItem) application.CreateItem(Outlook.OlItemType.olAppointmentItem);


                // Appointment details
                newAppointment.Location = "Jitsi Meet";
                newAppointment.Body = generateBody(jitsiRoomId);

                // Set appointment date if selected in calendar
                if (view.ViewType == Outlook.OlViewType.olCalendarView)
                {
                    Outlook.CalendarView calView = view as Outlook.CalendarView;
                    DateTime dateStart = calView.SelectedStartTime;
                    DateTime dateEnd = calView.SelectedEndTime;
                    if (dateStart != dateNull && dateEnd != dateNull)
                    {
                        newAppointment.Start = dateStart;
                        newAppointment.End = dateEnd;
                    }
                }

                // Display ribbon group, then the appointment window
                Globals.ThisAddIn.ShowRibbonAppointment = true;
                newAppointment.Display(false);
                Globals.ThisAddIn.ShowRibbonAppointment = false;

                // Set ribbon control defaults
                findThisRibbon(); // This only works after message is displayed to user
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
            thisRibbon = Globals.Ribbons[inspector].AppointmentRibbonGroup;
        }

        public static string generateBody(string roomId)
        {
            return Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyMessage") + (JitsiUrl.getUrlBase() + roomId);
        }

        private string getRoomId()
        {
            string roomId;
            if (Properties.Settings.Default.roomID.Length == 0)
            {
                roomId = JitsiUrl.generateRandomId();
            }
            else
            {
                roomId = Properties.Settings.Default.roomID;
            }

            return roomId;
        }

        private void setRoomIdText(string roomIdText)
        {
            if (roomIdText != null)
            {
                thisRibbon.fieldRoomID.Text = roomIdText;
            }
        }


        private void setRequireDisplayName()
        {
            if (Properties.Settings.Default.requireDisplayName)
            {
                thisRibbon.toggleRequireName();
                thisRibbon.buttonRequireDisplayName.Checked = true;
            }
        }

        private void setStartWithAudioMuted()
        {
            if (Properties.Settings.Default.startWithAudioMuted)
            {
                thisRibbon.toggleMuteOnStart();
                thisRibbon.buttonStartWithAudioMuted.Checked = true;
            }
        }

        private void setStartWithVideoMuted()
        {
            if (Properties.Settings.Default.startWithVideoMuted)
            {
                thisRibbon.toggleVideoOnStart();
                thisRibbon.buttonStartWithVideoMuted.Checked = true;
            }
        }

    }
}
