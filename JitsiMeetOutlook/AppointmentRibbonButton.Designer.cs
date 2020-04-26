namespace JitsiMeetOutlook
{
    partial class AppointmentRibbonButton : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public AppointmentRibbonButton()
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
            this.RoomID = this.Factory.CreateRibbonEditBox();
            this.box2 = this.Factory.CreateRibbonBox();
            this.buttonRandomiseRoomID = this.Factory.CreateRibbonButton();
            this.buttonMuteOnStart = this.Factory.CreateRibbonToggleButton();
            this.box3 = this.Factory.CreateRibbonBox();
            this.buttonRequireName = this.Factory.CreateRibbonToggleButton();
            this.buttonNoVideoOnStart = this.Factory.CreateRibbonToggleButton();
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
            this.groupJitsiMeet.Visible = false;
            this.groupJitsiMeet.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonDialogLauncher_Click);
            // 
            // box1
            // 
            this.box1.Items.Add(this.RoomID);
            this.box1.Name = "box1";
            // 
            // RoomID
            // 
            this.RoomID.Label = "ID:";
            this.RoomID.Name = "RoomID";
            this.RoomID.OfficeImageId = "StylesPaneNewStyle";
            this.RoomID.ShowImage = true;
            this.RoomID.SizeString = "wwwwwwwwwwwwwwwwwwwwww";
            this.RoomID.SuperTip = "Longer names are more secure.";
            this.RoomID.Text = null;
            this.RoomID.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RoomID_TextChanged);
            // 
            // box2
            // 
            this.box2.Items.Add(this.buttonRandomiseRoomID);
            this.box2.Items.Add(this.buttonMuteOnStart);
            this.box2.Name = "box2";
            // 
            // buttonRandomiseRoomID
            // 
            this.buttonRandomiseRoomID.Label = "Random ID";
            this.buttonRandomiseRoomID.Name = "buttonRandomiseRoomID";
            this.buttonRandomiseRoomID.OfficeImageId = "AccessRefreshAllLists";
            this.buttonRandomiseRoomID.ShowImage = true;
            this.buttonRandomiseRoomID.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonCustomiseJitsiMeeting_Click);
            // 
            // buttonMuteOnStart
            // 
            this.buttonMuteOnStart.Label = "Mute on Start";
            this.buttonMuteOnStart.Name = "buttonMuteOnStart";
            this.buttonMuteOnStart.OfficeImageId = "SpeechMicrophone";
            this.buttonMuteOnStart.ShowImage = true;
            this.buttonMuteOnStart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMuteOnStart_Click);
            // 
            // box3
            // 
            this.box3.Items.Add(this.buttonRequireName);
            this.box3.Items.Add(this.buttonNoVideoOnStart);
            this.box3.Name = "box3";
            // 
            // buttonRequireName
            // 
            this.buttonRequireName.Label = "Require Name";
            this.buttonRequireName.Name = "buttonRequireName";
            this.buttonRequireName.OfficeImageId = "FormControlEditBox";
            this.buttonRequireName.ShowImage = true;
            this.buttonRequireName.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonRequireName_Click);
            // 
            // buttonNoVideoOnStart
            // 
            this.buttonNoVideoOnStart.Label = "No Video on Start";
            this.buttonNoVideoOnStart.Name = "buttonNoVideoOnStart";
            this.buttonNoVideoOnStart.OfficeImageId = "Camera";
            this.buttonNoVideoOnStart.ShowImage = true;
            this.buttonNoVideoOnStart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonNoVideoOnStart_Click);
            // 
            // AppointmentRibbonButton
            // 
            this.Name = "AppointmentRibbonButton";
            this.RibbonType = "Microsoft.Outlook.Appointment";
            this.Tabs.Add(this.Appointment);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AppointmentRibbonButton_Load);
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
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox RoomID;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonMuteOnStart;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonNoVideoOnStart;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRandomiseRoomID;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton buttonRequireName;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box3;
    }

    partial class ThisRibbonCollection
    {
        internal AppointmentRibbonButton AppointmentRibbonButton
        {
            get { return this.GetRibbon<AppointmentRibbonButton>(); }
        }
    }
}
