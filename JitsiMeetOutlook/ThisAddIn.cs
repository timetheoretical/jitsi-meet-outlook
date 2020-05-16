using System.IO;

namespace JitsiMeetOutlook
{
    public partial class ThisAddIn
    {

        public bool ShowRibbonAppointment;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            ShowRibbonAppointment = false;
            checkFirstRunSettings();
            readLanguageJson();
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
