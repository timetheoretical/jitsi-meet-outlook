using Microsoft.Office.Tools.Ribbon;
using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace JitsiMeetOutlook
{
    public partial class CalendarRibbonButton
    {
        private void CalendarRibbonButton_Load(object sender, RibbonUIEventArgs e)
        {
            setLanguage();
        }

        private async void buttonNewJitsiMeeting_Click(object sender, RibbonControlEventArgs e)
        {
            // Get the Application object
            Outlook.Application application = Globals.ThisAddIn.Application;

            DateTime dateNull = new DateTime(4501, 1, 1, 0, 0, 0);
            Outlook.Explorer expl = application.ActiveExplorer();
            Outlook.View view = expl.CurrentView as Outlook.View;

            try
            {
                // Create meeting object
                var newAppointment = (Outlook.AppointmentItem)application.CreateItem(Outlook.OlItemType.olAppointmentItem);

                // Appointment details
                newAppointment.MeetingStatus = Outlook.OlMeetingStatus.olMeeting;
                newAppointment.Location = "Jitsi Meet New";

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

                // Display the appointment window
                newAppointment.Display(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }
    }
}
