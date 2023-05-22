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
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl2 = this.Factory.CreateRibbonDialogLauncher();
            this.Appointment = this.Factory.CreateRibbonTab();
            this.groupJitsiMeetControls = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.fieldRoomID = this.Factory.CreateRibbonEditBox();
            this.box2 = this.Factory.CreateRibbonBox();
            this.box3 = this.Factory.CreateRibbonBox();
            this.groupNewMeeting = this.Factory.CreateRibbonGroup();
            this.buttonRandomRoomID = this.Factory.CreateRibbonButton();
            this.buttonStartWithAudioMuted = this.Factory.CreateRibbonToggleButton();
            this.buttonRequireDisplayName = this.Factory.CreateRibbonToggleButton();
            this.buttonStartWithVideoMuted = this.Factory.CreateRibbonToggleButton();
            this.buttonNewJitsiMeeting = this.Factory.CreateRibbonButton();
            this.Appointment.SuspendLayout();
            this.groupJitsiMeetControls.SuspendLayout();
            this.box1.SuspendLayout();
            this.box2.SuspendLayout();
            this.box3.SuspendLayout();
            this.groupNewMeeting.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appointment
            // 
            this.Appointment.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Appointment.ControlId.OfficeId = "TabAppointment";
            this.Appointment.Groups.Add(this.groupJitsiMeetControls);
            this.Appointment.Groups.Add(this.groupNewMeeting);
            this.Appointment.Label = "TabAppointment";
            this.Appointment.Name = "Appointment";
            // 
            // groupJitsiMeetControls
            // 
            ribbonDialogLauncherImpl1.SuperTip = "Preferences";
            this.groupJitsiMeetControls.DialogLauncher = ribbonDialogLauncherImpl1;
            this.groupJitsiMeetControls.Items.Add(this.box1);
            this.groupJitsiMeetControls.Items.Add(this.box2);
            this.groupJitsiMeetControls.Items.Add(this.box3);
            this.groupJitsiMeetControls.Label = "Jitsi Meet";
            this.groupJitsiMeetControls.Name = "groupJitsiMeetControls";
            this.groupJitsiMeetControls.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupShow");
            this.groupJitsiMeetControls.Visible = false;
            this.groupJitsiMeetControls.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonDialogLauncher_Click);
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
            // box3
            // 
            this.box3.Items.Add(this.buttonRequireDisplayName);
            this.box3.Items.Add(this.buttonStartWithVideoMuted);
            this.box3.Name = "box3";
            // 
            // groupNewMeeting
            // 
            ribbonDialogLauncherImpl2.SuperTip = "Preferences";
            this.groupNewMeeting.DialogLauncher = ribbonDialogLauncherImpl2;
            this.groupNewMeeting.Items.Add(this.buttonNewJitsiMeeting);
            this.groupNewMeeting.Label = "Jitsi Meet";
            this.groupNewMeeting.Name = "groupNewMeeting";
            this.groupNewMeeting.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupShow");
            this.groupNewMeeting.Visible = false;
            this.groupNewMeeting.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonDialogLauncher_Click);
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
            // buttonNewJitsiMeeting
            // 
            this.buttonNewJitsiMeeting.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonNewJitsiMeeting.Image = global::JitsiMeetOutlook.Properties.Resources.jitsiLogo_square;
            this.buttonNewJitsiMeeting.Label = "New Jitsi Meeting";
            this.buttonNewJitsiMeeting.Name = "buttonNewJitsiMeeting";
            this.buttonNewJitsiMeeting.ShowImage = true;
            this.buttonNewJitsiMeeting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonNewJitsiMeeting_Click);
            // 
            // AppointmentRibbonGroup
            // 
            this.Name = "AppointmentRibbonGroup";
            this.RibbonType = "Microsoft.Outlook.Appointment";
            this.Tabs.Add(this.Appointment);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AppointmentRibbonGroup_Load);
            this.Appointment.ResumeLayout(false);
            this.Appointment.PerformLayout();
            this.groupJitsiMeetControls.ResumeLayout(false);
            this.groupJitsiMeetControls.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box3.ResumeLayout(false);
            this.box3.PerformLayout();
            this.groupNewMeeting.ResumeLayout(false);
            this.groupNewMeeting.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Appointment;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupJitsiMeetControls;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox fieldRoomID;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonStartWithAudioMuted;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonStartWithVideoMuted;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRandomRoomID;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonRequireDisplayName;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box3;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupNewMeeting;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonNewJitsiMeeting;
    }

    partial class ThisRibbonCollection
    {
        internal AppointmentRibbonGroup AppointmentRibbonGroup
        {
            get { return this.GetRibbon<AppointmentRibbonGroup>(); }
        }
    }
}
