using System;
using Outlook = Microsoft.Office.Interop.Outlook;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Security.Cryptography;
using System.Text;
using System.Numerics;

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
                newAppointment.MeetingStatus = Outlook.OlMeetingStatus.olMeeting;
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
            return Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyMessage") + (JitsiUrl.getUrlBase() + roomId) + Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyMessagePhone") + JitsiUrl.getPhone()  + Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyPin") + getPIN(roomId + "@conference." + JitsiUrl.getDomain() ).ToString("D8") + Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyDisclaimer"); 
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



        public static BigInteger getPIN(string roomName)
        {
            // conference = conference.lower()
            // confid =int(hashlib.sha3_256(conference.encode("utf-8")).hexdigest(), 16) % 10**digits
            int digits = 8;
            using (SHA256 shaAlg = SHA256.Create())
            {
                var hash = shaAlg.ComputeHash(Encoding.UTF8.GetBytes(roomName.ToLower()));
                StringBuilder res = new StringBuilder();

                foreach (Byte b in hash)
                {
                    res.Append(b.ToString("x2"));
                }
                BigInteger reminder = BigInteger.Parse("0" + res.ToString(), System.Globalization.NumberStyles.HexNumber) % (int)Math.Pow(10, digits);
                return (int)reminder;
            }
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
