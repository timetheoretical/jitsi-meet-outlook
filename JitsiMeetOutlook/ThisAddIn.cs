using JitsiMeetOutlook.Entities;
using Microsoft.Office.Interop.Outlook;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace JitsiMeetOutlook
{
    public partial class ThisAddIn
    {
        public JitsiApiService JitsiApiService;

        // Define these so they are not garbarge collected
        private MAPIFolder calendarFolder;
        private Items calendarFolderItems;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            checkFirstRunSettings();
            readLanguageJson();

            JitsiApiService = new JitsiApiService();

            // Create Hooks for all Outlook Calendar Items
            // Maybe there is a better way, but thats the best I could find.
            // It will call the change event multiple times!
            calendarFolder =
                this.Application.ActiveExplorer().Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar);
            calendarFolderItems = calendarFolder.Items;
            calendarFolderItems.ItemAdd += AppointmentAddedOrChanged;
            calendarFolderItems.ItemChange += AppointmentAddedOrChanged;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        private void checkFirstRunSettings()
        {
            if (isFirstRun())
            {
                customSettingsOnFirstRun();
            }
            else if (isTxtOlderThanInstallation())
            {
                File.Delete(firstRunMarkerFilePath());
                customSettingsOnFirstRun();
            }
        }

        private bool isFirstRun()
        {
            return !File.Exists(firstRunMarkerFilePath());
        }

        private bool isTxtOlderThanInstallation()
        {
            string mainDllPath = Path.Combine(Properties.Settings.Default.installDirectory, "Jitsi Meet Outlook Add-In.dll.config");

            FileInfo infoMainDll = new FileInfo(mainDllPath);
            FileInfo infoFirstRunTxt = new FileInfo(firstRunMarkerFilePath());

            return infoMainDll.LastWriteTime > infoFirstRunTxt.LastWriteTime;
        }

        private string firstRunMarkerFilePath()
        {
            string shadowCopyLocation = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string firstRunMarkerFile = Path.Combine(shadowCopyLocation, "firstrun.txt");

            return firstRunMarkerFile;
        }

        private void customSettingsOnFirstRun()
        {
            // Reset settings to those specified during install, and if none were specified, to default settings
            Properties.Settings.Default.Reset();

            // Create a file in the assembly shadow copy location to mark this code as executed
            string firstRunText = "This file is created the first time the add-in is launched.\n\nRemoval of this file will reset settings, whereafter it will be re-created on next launch of the add-in.";
            File.WriteAllText(firstRunMarkerFilePath(), firstRunText);
        }

        public void AppointmentAddedOrChanged(object appointment)
        {
            // Make sure we only react to Appointments
            if (appointment is AppointmentItem)
            {
                AppointmentItem item = appointment as AppointmentItem;

                if (item.Location == "Jitsi Meet")
                {
                    Utils.RunInThread(() =>
                    {
                        string recurrencePattern = null;
                        if (item.IsRecurring)
                        {
                            var recurrencebuilder = new Recurrence();
                            recurrencePattern = recurrencebuilder.buildRrule(item.GetRecurrencePattern());
                        }

                        var scheduledConference = new ConferenceSchedulerMessage
                        {

                            Name = item.Subject,
                            Start = item.StartUTC,
                            End = item.EndUTC,
                            Recurrance = recurrencePattern
                        };
                        JitsiApiService.ScheduleConference(scheduledConference);
                    });
                }
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
