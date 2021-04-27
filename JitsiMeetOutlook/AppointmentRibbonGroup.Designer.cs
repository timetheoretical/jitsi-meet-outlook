namespace JitsiMeetOutlook
{
    partial class AppointmentRibbonGroup : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public AppointmentRibbonGroup()
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
            this.Appointment = this.Factory.CreateRibbonTab();
            this.groupJitsiMeet = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.fieldRoomID = this.Factory.CreateRibbonEditBox();
            this.box2 = this.Factory.CreateRibbonBox();
            this.buttonRandomRoomID = this.Factory.CreateRibbonButton();
            this.buttonStartWithAudioMuted = this.Factory.CreateRibbonToggleButton();
            this.box3 = this.Factory.CreateRibbonBox();
            this.buttonRequireDisplayName = this.Factory.CreateRibbonToggleButton();
            this.buttonStartWithVideoMuted = this.Factory.CreateRibbonToggleButton();
            this.Appointment.SuspendLayout();
            this.groupJitsiMeet.SuspendLayout();
            this.box1.SuspendLayout();
            this.box2.SuspendLayout();
            this.box3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appointment
            // 
            this.Appointment.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Appointment.ControlId.OfficeId = "TabAppointment";
            this.Appointment.Groups.Add(this.groupJitsiMeet);
            this.Appointment.Label = "TabAppointment";
            this.Appointment.Name = "Appointment";
            // 
            // groupJitsiMeet
            // 
            ribbonDialogLauncherImpl1.SuperTip = "Preferences";
            this.groupJitsiMeet.DialogLauncher = ribbonDialogLauncherImpl1;
            this.groupJitsiMeet.Items.Add(this.box1);
            this.groupJitsiMeet.Items.Add(this.box2);
            this.groupJitsiMeet.Items.Add(this.box3);
            this.groupJitsiMeet.Label = "Jitsi Meet";
            this.groupJitsiMeet.Name = "groupJitsiMeet";
            this.groupJitsiMeet.Position = this.Factory.RibbonPosition.BeforeOfficeId("GroupAttendees");
            this.groupJitsiMeet.Visible = Properties.Settings.Default.showRibbonOnEveryAppointment;
            this.groupJitsiMeet.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonDialogLauncher_Click);
            // 
            // box1
            // 
            this.box1.Items.Add(this.fieldRoomID);
            this.box1.Name = "box1";
            // 
            // fieldRoomID
            // 
            this.fieldRoomID.Label = "ID:";
            this.fieldRoomID.Name = "fieldRoomID";
            this.fieldRoomID.OfficeImageId = "StylesPaneNewStyle";
            this.fieldRoomID.ShowImage = true;
            this.fieldRoomID.SizeString = "wwwwwwwwwwwwwwwwwwwwww";
            this.fieldRoomID.SuperTip = "Longer names are more secure.";
            this.fieldRoomID.Text = null;
            this.fieldRoomID.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RoomID_TextChanged);
            // 
            // box2
            // 
            this.box2.Items.Add(this.buttonRandomRoomID);
            this.box2.Items.Add(this.buttonStartWithAudioMuted);
            this.box2.Name = "box2";
            // 
            // buttonRandomRoomID
            // 
            this.buttonRandomRoomID.Label = "Random ID";
            this.buttonRandomRoomID.Name = "buttonRandomRoomID";
            this.buttonRandomRoomID.OfficeImageId = "AccessRefreshAllLists";
            this.buttonRandomRoomID.ShowImage = true;
            this.buttonRandomRoomID.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonCustomiseJitsiMeeting_Click);
            // 
            // buttonStartWithAudioMuted
            // 
            this.buttonStartWithAudioMuted.Label = "Mute on Start";
            this.buttonStartWithAudioMuted.Name = "buttonStartWithAudioMuted";
            this.buttonStartWithAudioMuted.OfficeImageId = "SpeechMicrophone";
            this.buttonStartWithAudioMuted.ShowImage = true;
            this.buttonStartWithAudioMuted.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonStartWithAudioMuted_Click);
            // 
            // box3
            // 
            this.box3.Items.Add(this.buttonRequireDisplayName);
            this.box3.Items.Add(this.buttonStartWithVideoMuted);
            this.box3.Name = "box3";
            // 
            // buttonRequireDisplayName
            // 
            this.buttonRequireDisplayName.Label = "Require Name";
            this.buttonRequireDisplayName.Name = "buttonRequireDisplayName";
            this.buttonRequireDisplayName.OfficeImageId = "FormControlEditBox";
            this.buttonRequireDisplayName.ShowImage = true;
            this.buttonRequireDisplayName.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonRequireDisplayName_Click);
            // 
            // buttonStartWithVideoMuted
            // 
            this.buttonStartWithVideoMuted.Label = "No Video on Start";
            this.buttonStartWithVideoMuted.Name = "buttonStartWithVideoMuted";
            this.buttonStartWithVideoMuted.OfficeImageId = "Camera";
            this.buttonStartWithVideoMuted.ShowImage = true;
            this.buttonStartWithVideoMuted.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonStartWithVideoMuted_Click);
            // 
            // AppointmentRibbonGroup
            // 
            this.Name = "AppointmentRibbonGroup";
            this.RibbonType = "Microsoft.Outlook.Appointment";
            this.Tabs.Add(this.Appointment);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AppointmentRibbonGroup_Load);
            this.Appointment.ResumeLayout(false);
            this.Appointment.PerformLayout();
            this.groupJitsiMeet.ResumeLayout(false);
            this.groupJitsiMeet.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box3.ResumeLayout(false);
            this.box3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Appointment;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupJitsiMeet;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox fieldRoomID;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonStartWithAudioMuted;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonStartWithVideoMuted;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRandomRoomID;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonRequireDisplayName;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box3;
    }

    partial class ThisRibbonCollection
    {
        internal AppointmentRibbonGroup AppointmentRibbonGroup
        {
            get { return this.GetRibbon<AppointmentRibbonGroup>(); }
        }
    }
}
