namespace JitsiMeetOutlook
{
    partial class CalendarRibbonButton : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CalendarRibbonButton()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.Calendar = this.Factory.CreateRibbonTab();
            this.JitsiMeet = this.Factory.CreateRibbonGroup();
            this.buttonNewJitsiMeeting = this.Factory.CreateRibbonButton();
            this.Calendar.SuspendLayout();
            this.JitsiMeet.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Calendar.ControlId.OfficeId = "TabCalendar";
            this.Calendar.Groups.Add(this.JitsiMeet);
            this.Calendar.Label = "TabCalendar";
            this.Calendar.Name = "Calendar";
            // 
            // JitsiMeet
            // 
            ribbonDialogLauncherImpl1.SuperTip = "Preferences";
            this.JitsiMeet.DialogLauncher = ribbonDialogLauncherImpl1;
            this.JitsiMeet.Items.Add(this.buttonNewJitsiMeeting);
            this.JitsiMeet.Label = "Jitsi Meet";
            this.JitsiMeet.Name = "JitsiMeet";
            this.JitsiMeet.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupCalendarNew");
            this.JitsiMeet.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonDialogLauncher_Click);
            // 
            // buttonNewJitsiMeeting
            // 
            this.buttonNewJitsiMeeting.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonNewJitsiMeeting.Image = global::JitsiMeetOutlook.Properties.Resources.jitsiLogo_square;
            this.buttonNewJitsiMeeting.Label = "New Jitsi Meeting";
            this.buttonNewJitsiMeeting.Name = "buttonNewJitsiMeeting";
            this.buttonNewJitsiMeeting.ShowImage = true;
            this.buttonNewJitsiMeeting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonNewJitsiMeeting_Click);
            // 
            // CalendarRibbonButton
            // 
            this.Name = "CalendarRibbonButton";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.Calendar);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CalendarRibbonButton_Load);
            this.Calendar.ResumeLayout(false);
            this.Calendar.PerformLayout();
            this.JitsiMeet.ResumeLayout(false);
            this.JitsiMeet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Calendar;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup JitsiMeet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonNewJitsiMeeting;
    }

    partial class ThisRibbonCollection
    {
        internal CalendarRibbonButton CalendarRibbonButton
        {
            get { return this.GetRibbon<CalendarRibbonButton>(); }
        }
    }
}
