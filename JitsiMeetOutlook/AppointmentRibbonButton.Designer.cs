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
            this.Appointment = this.Factory.CreateRibbonTab();
            this.JitsiMeet = this.Factory.CreateRibbonGroup();
            this.buttonCustomiseJitsiMeeting = this.Factory.CreateRibbonButton();
            this.Appointment.SuspendLayout();
            this.JitsiMeet.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appointment
            // 
            this.Appointment.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Appointment.ControlId.OfficeId = "TabAppointment";
            this.Appointment.Groups.Add(this.JitsiMeet);
            this.Appointment.Label = "TabAppointment";
            this.Appointment.Name = "Appointment";
            // 
            // JitsiMeet
            // 
            this.JitsiMeet.Items.Add(this.buttonCustomiseJitsiMeeting);
            this.JitsiMeet.Label = "Jitsi Meet";
            this.JitsiMeet.Name = "JitsiMeet";
            this.JitsiMeet.Position = this.Factory.RibbonPosition.BeforeOfficeId("GroupAttendees");
            // 
            // buttonCustomiseJitsiMeeting
            // 
            this.buttonCustomiseJitsiMeeting.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonCustomiseJitsiMeeting.Image = global::JitsiMeetOutlook.Properties.Resources.jitsiLogo_square;
            this.buttonCustomiseJitsiMeeting.Label = "Customise Jitsi Meeting";
            this.buttonCustomiseJitsiMeeting.Name = "buttonCustomiseJitsiMeeting";
            this.buttonCustomiseJitsiMeeting.ShowImage = true;
            // 
            // AppointmentRibbonButton
            // 
            this.Name = "AppointmentRibbonButton";
            this.RibbonType = "Microsoft.Outlook.Appointment";
            this.Tabs.Add(this.Appointment);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AppointmentRibbonButton_Load);
            this.Appointment.ResumeLayout(false);
            this.Appointment.PerformLayout();
            this.JitsiMeet.ResumeLayout(false);
            this.JitsiMeet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Appointment;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup JitsiMeet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCustomiseJitsiMeeting;
    }

    partial class ThisRibbonCollection
    {
        internal AppointmentRibbonButton AppointmentRibbonButton
        {
            get { return this.GetRibbon<AppointmentRibbonButton>(); }
        }
    }
}
