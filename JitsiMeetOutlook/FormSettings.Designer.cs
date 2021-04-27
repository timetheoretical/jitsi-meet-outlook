﻿namespace JitsiMeetOutlook
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDomain = new System.Windows.Forms.GroupBox();
            this.textBoxDomain = new System.Windows.Forms.TextBox();
            this.radioButtonCustomDomain = new System.Windows.Forms.RadioButton();
            this.radioButtonDefaultDomain = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxToggleDefaults = new System.Windows.Forms.GroupBox();
            this.panelStartWithVideoMuted = new System.Windows.Forms.Panel();
            this.radioButtonStartWithVideoMutedToggled = new System.Windows.Forms.RadioButton();
            this.radioButtonStartWithVideoMutedUntoggled = new System.Windows.Forms.RadioButton();
            this.labelStartWithVideoMuted = new System.Windows.Forms.Label();
            this.panelStartWithAudioMuted = new System.Windows.Forms.Panel();
            this.radioButtonStartWithAudioMutedToggled = new System.Windows.Forms.RadioButton();
            this.radioButtonStartWithAudioMutedUntoggled = new System.Windows.Forms.RadioButton();
            this.labelStartWithAudioMuted = new System.Windows.Forms.Label();
            this.labelToggled = new System.Windows.Forms.Label();
            this.labelUntoggled = new System.Windows.Forms.Label();
            this.panelRequireDisplayName = new System.Windows.Forms.Panel();
            this.radioButtonRequireDisplayNameToggled = new System.Windows.Forms.RadioButton();
            this.radioButtonRequireDisplayNameUntoggled = new System.Windows.Forms.RadioButton();
            this.labelRequireDisplayName = new System.Windows.Forms.Label();
            this.groupBoxDefaultRoomID = new System.Windows.Forms.GroupBox();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.radioButtonCustomRoomID = new System.Windows.Forms.RadioButton();
            this.radioButtonRandomRoomID = new System.Windows.Forms.RadioButton();
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageDomain = new System.Windows.Forms.TabPage();
            this.tabPageRoomId = new System.Windows.Forms.TabPage();
            this.groupBoxRandomGeneratorMode = new System.Windows.Forms.GroupBox();
            this.comboBoxRandomGeneratorMode = new System.Windows.Forms.ComboBox();
            this.tabPageMeetingOptions = new System.Windows.Forms.TabPage();
            this.tabPageLanguage = new System.Windows.Forms.TabPage();
            this.panelRibbonOnEveryAppointment = new System.Windows.Forms.Panel();
            this.labelRibbonOnEveryAppointment = new System.Windows.Forms.Label();
            this.radioButtonRibbonOnEveryAppointmentToggled = new System.Windows.Forms.RadioButton();
            this.radioButtonRibbonOnEveryAppointmentUntoggled = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBoxDomain.SuspendLayout();
            this.groupBoxToggleDefaults.SuspendLayout();
            this.panelStartWithVideoMuted.SuspendLayout();
            this.panelStartWithAudioMuted.SuspendLayout();
            this.panelRequireDisplayName.SuspendLayout();
            this.groupBoxDefaultRoomID.SuspendLayout();
            this.groupBoxLanguage.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageDomain.SuspendLayout();
            this.tabPageRoomId.SuspendLayout();
            this.groupBoxRandomGeneratorMode.SuspendLayout();
            this.tabPageMeetingOptions.SuspendLayout();
            this.tabPageLanguage.SuspendLayout();
            this.panelRibbonOnEveryAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(595, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBoxDomain
            // 
            this.groupBoxDomain.Controls.Add(this.textBoxDomain);
            this.groupBoxDomain.Controls.Add(this.radioButtonCustomDomain);
            this.groupBoxDomain.Controls.Add(this.radioButtonDefaultDomain);
            this.groupBoxDomain.Location = new System.Drawing.Point(9, 9);
            this.groupBoxDomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDomain.Name = "groupBoxDomain";
            this.groupBoxDomain.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDomain.Size = new System.Drawing.Size(454, 108);
            this.groupBoxDomain.TabIndex = 2;
            this.groupBoxDomain.TabStop = false;
            this.groupBoxDomain.Text = "Domain";
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Location = new System.Drawing.Point(170, 65);
            this.textBoxDomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(268, 26);
            this.textBoxDomain.TabIndex = 2;
            this.textBoxDomain.TextChanged += new System.EventHandler(this.textBoxDomain_TextChanged);
            // 
            // radioButtonCustomDomain
            // 
            this.radioButtonCustomDomain.AutoSize = true;
            this.radioButtonCustomDomain.Location = new System.Drawing.Point(9, 65);
            this.radioButtonCustomDomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCustomDomain.Name = "radioButtonCustomDomain";
            this.radioButtonCustomDomain.Size = new System.Drawing.Size(93, 24);
            this.radioButtonCustomDomain.TabIndex = 1;
            this.radioButtonCustomDomain.TabStop = true;
            this.radioButtonCustomDomain.Text = "Custom:";
            this.radioButtonCustomDomain.UseVisualStyleBackColor = true;
            this.radioButtonCustomDomain.CheckedChanged += new System.EventHandler(this.radioButtonCustomDomain_CheckedChanged);
            // 
            // radioButtonDefaultDomain
            // 
            this.radioButtonDefaultDomain.AutoSize = true;
            this.radioButtonDefaultDomain.Location = new System.Drawing.Point(9, 29);
            this.radioButtonDefaultDomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonDefaultDomain.Name = "radioButtonDefaultDomain";
            this.radioButtonDefaultDomain.Size = new System.Drawing.Size(86, 24);
            this.radioButtonDefaultDomain.TabIndex = 0;
            this.radioButtonDefaultDomain.TabStop = true;
            this.radioButtonDefaultDomain.Text = "Default";
            this.radioButtonDefaultDomain.UseVisualStyleBackColor = true;
            this.radioButtonDefaultDomain.CheckedChanged += new System.EventHandler(this.radioButtonDefaultDomain_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(270, 349);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 35);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(392, 349);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 35);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxToggleDefaults
            // 
            this.groupBoxToggleDefaults.Controls.Add(this.panelRibbonOnEveryAppointment);
            this.groupBoxToggleDefaults.Controls.Add(this.panelStartWithVideoMuted);
            this.groupBoxToggleDefaults.Controls.Add(this.panelStartWithAudioMuted);
            this.groupBoxToggleDefaults.Controls.Add(this.labelToggled);
            this.groupBoxToggleDefaults.Controls.Add(this.labelUntoggled);
            this.groupBoxToggleDefaults.Controls.Add(this.panelRequireDisplayName);
            this.groupBoxToggleDefaults.Location = new System.Drawing.Point(8, 9);
            this.groupBoxToggleDefaults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxToggleDefaults.Name = "groupBoxToggleDefaults";
            this.groupBoxToggleDefaults.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxToggleDefaults.Size = new System.Drawing.Size(487, 251);
            this.groupBoxToggleDefaults.TabIndex = 5;
            this.groupBoxToggleDefaults.TabStop = false;
            this.groupBoxToggleDefaults.Text = "Default meeting options";
            // 
            // panelStartWithVideoMuted
            // 
            this.panelStartWithVideoMuted.Controls.Add(this.radioButtonStartWithVideoMutedToggled);
            this.panelStartWithVideoMuted.Controls.Add(this.radioButtonStartWithVideoMutedUntoggled);
            this.panelStartWithVideoMuted.Controls.Add(this.labelStartWithVideoMuted);
            this.panelStartWithVideoMuted.Location = new System.Drawing.Point(9, 127);
            this.panelStartWithVideoMuted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelStartWithVideoMuted.Name = "panelStartWithVideoMuted";
            this.panelStartWithVideoMuted.Size = new System.Drawing.Size(465, 29);
            this.panelStartWithVideoMuted.TabIndex = 3;
            // 
            // radioButtonStartWithVideoMutedToggled
            // 
            this.radioButtonStartWithVideoMutedToggled.AutoSize = true;
            this.radioButtonStartWithVideoMutedToggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithVideoMutedToggled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonStartWithVideoMutedToggled.Location = new System.Drawing.Point(344, 5);
            this.radioButtonStartWithVideoMutedToggled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonStartWithVideoMutedToggled.Name = "radioButtonStartWithVideoMutedToggled";
            this.radioButtonStartWithVideoMutedToggled.Size = new System.Drawing.Size(21, 20);
            this.radioButtonStartWithVideoMutedToggled.TabIndex = 2;
            this.radioButtonStartWithVideoMutedToggled.TabStop = true;
            this.radioButtonStartWithVideoMutedToggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithVideoMutedToggled.UseVisualStyleBackColor = true;
            // 
            // radioButtonStartWithVideoMutedUntoggled
            // 
            this.radioButtonStartWithVideoMutedUntoggled.AutoSize = true;
            this.radioButtonStartWithVideoMutedUntoggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithVideoMutedUntoggled.Location = new System.Drawing.Point(417, 5);
            this.radioButtonStartWithVideoMutedUntoggled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonStartWithVideoMutedUntoggled.Name = "radioButtonStartWithVideoMutedUntoggled";
            this.radioButtonStartWithVideoMutedUntoggled.Size = new System.Drawing.Size(21, 20);
            this.radioButtonStartWithVideoMutedUntoggled.TabIndex = 1;
            this.radioButtonStartWithVideoMutedUntoggled.TabStop = true;
            this.radioButtonStartWithVideoMutedUntoggled.UseVisualStyleBackColor = true;
            // 
            // labelStartWithVideoMuted
            // 
            this.labelStartWithVideoMuted.AutoSize = true;
            this.labelStartWithVideoMuted.Location = new System.Drawing.Point(4, 5);
            this.labelStartWithVideoMuted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartWithVideoMuted.Name = "labelStartWithVideoMuted";
            this.labelStartWithVideoMuted.Size = new System.Drawing.Size(135, 20);
            this.labelStartWithVideoMuted.TabIndex = 0;
            this.labelStartWithVideoMuted.Text = "No Video on Start";
            // 
            // panelStartWithAudioMuted
            // 
            this.panelStartWithAudioMuted.Controls.Add(this.radioButtonStartWithAudioMutedToggled);
            this.panelStartWithAudioMuted.Controls.Add(this.radioButtonStartWithAudioMutedUntoggled);
            this.panelStartWithAudioMuted.Controls.Add(this.labelStartWithAudioMuted);
            this.panelStartWithAudioMuted.Location = new System.Drawing.Point(9, 88);
            this.panelStartWithAudioMuted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelStartWithAudioMuted.Name = "panelStartWithAudioMuted";
            this.panelStartWithAudioMuted.Size = new System.Drawing.Size(465, 29);
            this.panelStartWithAudioMuted.TabIndex = 3;
            // 
            // radioButtonStartWithAudioMutedToggled
            // 
            this.radioButtonStartWithAudioMutedToggled.AutoSize = true;
            this.radioButtonStartWithAudioMutedToggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithAudioMutedToggled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonStartWithAudioMutedToggled.Location = new System.Drawing.Point(344, 5);
            this.radioButtonStartWithAudioMutedToggled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonStartWithAudioMutedToggled.Name = "radioButtonStartWithAudioMutedToggled";
            this.radioButtonStartWithAudioMutedToggled.Size = new System.Drawing.Size(21, 20);
            this.radioButtonStartWithAudioMutedToggled.TabIndex = 2;
            this.radioButtonStartWithAudioMutedToggled.TabStop = true;
            this.radioButtonStartWithAudioMutedToggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithAudioMutedToggled.UseVisualStyleBackColor = true;
            // 
            // radioButtonStartWithAudioMutedUntoggled
            // 
            this.radioButtonStartWithAudioMutedUntoggled.AutoSize = true;
            this.radioButtonStartWithAudioMutedUntoggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithAudioMutedUntoggled.Location = new System.Drawing.Point(417, 5);
            this.radioButtonStartWithAudioMutedUntoggled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonStartWithAudioMutedUntoggled.Name = "radioButtonStartWithAudioMutedUntoggled";
            this.radioButtonStartWithAudioMutedUntoggled.Size = new System.Drawing.Size(21, 20);
            this.radioButtonStartWithAudioMutedUntoggled.TabIndex = 1;
            this.radioButtonStartWithAudioMutedUntoggled.TabStop = true;
            this.radioButtonStartWithAudioMutedUntoggled.UseVisualStyleBackColor = true;
            // 
            // labelStartWithAudioMuted
            // 
            this.labelStartWithAudioMuted.AutoSize = true;
            this.labelStartWithAudioMuted.Location = new System.Drawing.Point(4, 5);
            this.labelStartWithAudioMuted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartWithAudioMuted.Name = "labelStartWithAudioMuted";
            this.labelStartWithAudioMuted.Size = new System.Drawing.Size(106, 20);
            this.labelStartWithAudioMuted.TabIndex = 0;
            this.labelStartWithAudioMuted.Text = "Mute on Start";
            // 
            // labelToggled
            // 
            this.labelToggled.AutoSize = true;
            this.labelToggled.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelToggled.Location = new System.Drawing.Point(334, 24);
            this.labelToggled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToggled.Name = "labelToggled";
            this.labelToggled.Size = new System.Drawing.Size(66, 20);
            this.labelToggled.TabIndex = 4;
            this.labelToggled.Text = "Toggled";
            this.labelToggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUntoggled
            // 
            this.labelUntoggled.AutoSize = true;
            this.labelUntoggled.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelUntoggled.Location = new System.Drawing.Point(400, 24);
            this.labelUntoggled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUntoggled.Name = "labelUntoggled";
            this.labelUntoggled.Size = new System.Drawing.Size(83, 20);
            this.labelUntoggled.TabIndex = 3;
            this.labelUntoggled.Text = "Untoggled";
            this.labelUntoggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRequireDisplayName
            // 
            this.panelRequireDisplayName.Controls.Add(this.radioButtonRequireDisplayNameToggled);
            this.panelRequireDisplayName.Controls.Add(this.radioButtonRequireDisplayNameUntoggled);
            this.panelRequireDisplayName.Controls.Add(this.labelRequireDisplayName);
            this.panelRequireDisplayName.Location = new System.Drawing.Point(9, 49);
            this.panelRequireDisplayName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRequireDisplayName.Name = "panelRequireDisplayName";
            this.panelRequireDisplayName.Size = new System.Drawing.Size(465, 29);
            this.panelRequireDisplayName.TabIndex = 0;
            // 
            // radioButtonRequireDisplayNameToggled
            // 
            this.radioButtonRequireDisplayNameToggled.AutoSize = true;
            this.radioButtonRequireDisplayNameToggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRequireDisplayNameToggled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonRequireDisplayNameToggled.Location = new System.Drawing.Point(344, 5);
            this.radioButtonRequireDisplayNameToggled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonRequireDisplayNameToggled.Name = "radioButtonRequireDisplayNameToggled";
            this.radioButtonRequireDisplayNameToggled.Size = new System.Drawing.Size(21, 20);
            this.radioButtonRequireDisplayNameToggled.TabIndex = 2;
            this.radioButtonRequireDisplayNameToggled.TabStop = true;
            this.radioButtonRequireDisplayNameToggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRequireDisplayNameToggled.UseVisualStyleBackColor = true;
            // 
            // radioButtonRequireDisplayNameUntoggled
            // 
            this.radioButtonRequireDisplayNameUntoggled.AutoSize = true;
            this.radioButtonRequireDisplayNameUntoggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRequireDisplayNameUntoggled.Location = new System.Drawing.Point(417, 5);
            this.radioButtonRequireDisplayNameUntoggled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonRequireDisplayNameUntoggled.Name = "radioButtonRequireDisplayNameUntoggled";
            this.radioButtonRequireDisplayNameUntoggled.Size = new System.Drawing.Size(21, 20);
            this.radioButtonRequireDisplayNameUntoggled.TabIndex = 1;
            this.radioButtonRequireDisplayNameUntoggled.TabStop = true;
            this.radioButtonRequireDisplayNameUntoggled.UseVisualStyleBackColor = true;
            // 
            // labelRequireDisplayName
            // 
            this.labelRequireDisplayName.AutoSize = true;
            this.labelRequireDisplayName.Location = new System.Drawing.Point(4, 5);
            this.labelRequireDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRequireDisplayName.Name = "labelRequireDisplayName";
            this.labelRequireDisplayName.Size = new System.Drawing.Size(111, 20);
            this.labelRequireDisplayName.TabIndex = 0;
            this.labelRequireDisplayName.Text = "Require Name";
            // 
            // groupBoxDefaultRoomID
            // 
            this.groupBoxDefaultRoomID.Controls.Add(this.textBoxRoomID);
            this.groupBoxDefaultRoomID.Controls.Add(this.radioButtonCustomRoomID);
            this.groupBoxDefaultRoomID.Controls.Add(this.radioButtonRandomRoomID);
            this.groupBoxDefaultRoomID.Location = new System.Drawing.Point(9, 9);
            this.groupBoxDefaultRoomID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDefaultRoomID.Name = "groupBoxDefaultRoomID";
            this.groupBoxDefaultRoomID.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDefaultRoomID.Size = new System.Drawing.Size(454, 108);
            this.groupBoxDefaultRoomID.TabIndex = 3;
            this.groupBoxDefaultRoomID.TabStop = false;
            this.groupBoxDefaultRoomID.Text = "Default room ID";
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(170, 65);
            this.textBoxRoomID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(268, 26);
            this.textBoxRoomID.TabIndex = 2;
            // 
            // radioButtonCustomRoomID
            // 
            this.radioButtonCustomRoomID.AutoSize = true;
            this.radioButtonCustomRoomID.Location = new System.Drawing.Point(9, 65);
            this.radioButtonCustomRoomID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCustomRoomID.Name = "radioButtonCustomRoomID";
            this.radioButtonCustomRoomID.Size = new System.Drawing.Size(93, 24);
            this.radioButtonCustomRoomID.TabIndex = 1;
            this.radioButtonCustomRoomID.TabStop = true;
            this.radioButtonCustomRoomID.Text = "Custom:";
            this.radioButtonCustomRoomID.UseVisualStyleBackColor = true;
            this.radioButtonCustomRoomID.CheckedChanged += new System.EventHandler(this.radioButtonCustomRoomID_CheckedChanged);
            // 
            // radioButtonRandomRoomID
            // 
            this.radioButtonRandomRoomID.AutoSize = true;
            this.radioButtonRandomRoomID.Location = new System.Drawing.Point(9, 29);
            this.radioButtonRandomRoomID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonRandomRoomID.Name = "radioButtonRandomRoomID";
            this.radioButtonRandomRoomID.Size = new System.Drawing.Size(95, 24);
            this.radioButtonRandomRoomID.TabIndex = 0;
            this.radioButtonRandomRoomID.TabStop = true;
            this.radioButtonRandomRoomID.Text = "Random";
            this.radioButtonRandomRoomID.UseVisualStyleBackColor = true;
            this.radioButtonRandomRoomID.CheckedChanged += new System.EventHandler(this.radioButtonRandomID_CheckedChanged);
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.Controls.Add(this.comboBoxLanguage);
            this.groupBoxLanguage.Location = new System.Drawing.Point(8, 5);
            this.groupBoxLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLanguage.Size = new System.Drawing.Size(454, 75);
            this.groupBoxLanguage.TabIndex = 3;
            this.groupBoxLanguage.TabStop = false;
            this.groupBoxLanguage.Text = "Language";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "French"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(14, 29);
            this.comboBoxLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(428, 28);
            this.comboBoxLanguage.TabIndex = 0;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageDomain);
            this.tabControlSettings.Controls.Add(this.tabPageRoomId);
            this.tabControlSettings.Controls.Add(this.tabPageMeetingOptions);
            this.tabControlSettings.Controls.Add(this.tabPageLanguage);
            this.tabControlSettings.Location = new System.Drawing.Point(18, 42);
            this.tabControlSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(520, 298);
            this.tabControlSettings.TabIndex = 6;
            // 
            // tabPageDomain
            // 
            this.tabPageDomain.Controls.Add(this.groupBoxDomain);
            this.tabPageDomain.Location = new System.Drawing.Point(4, 29);
            this.tabPageDomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDomain.Name = "tabPageDomain";
            this.tabPageDomain.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDomain.Size = new System.Drawing.Size(484, 265);
            this.tabPageDomain.TabIndex = 0;
            this.tabPageDomain.Text = "Domain";
            this.tabPageDomain.UseVisualStyleBackColor = true;
            // 
            // tabPageRoomId
            // 
            this.tabPageRoomId.Controls.Add(this.groupBoxRandomGeneratorMode);
            this.tabPageRoomId.Controls.Add(this.groupBoxDefaultRoomID);
            this.tabPageRoomId.Location = new System.Drawing.Point(4, 29);
            this.tabPageRoomId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageRoomId.Name = "tabPageRoomId";
            this.tabPageRoomId.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageRoomId.Size = new System.Drawing.Size(484, 265);
            this.tabPageRoomId.TabIndex = 1;
            this.tabPageRoomId.Text = "Room ID";
            this.tabPageRoomId.UseVisualStyleBackColor = true;
            // 
            // groupBoxRandomGeneratorMode
            // 
            this.groupBoxRandomGeneratorMode.Controls.Add(this.comboBoxRandomGeneratorMode);
            this.groupBoxRandomGeneratorMode.Location = new System.Drawing.Point(9, 126);
            this.groupBoxRandomGeneratorMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRandomGeneratorMode.Name = "groupBoxRandomGeneratorMode";
            this.groupBoxRandomGeneratorMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRandomGeneratorMode.Size = new System.Drawing.Size(454, 75);
            this.groupBoxRandomGeneratorMode.TabIndex = 4;
            this.groupBoxRandomGeneratorMode.TabStop = false;
            this.groupBoxRandomGeneratorMode.Text = "Random generator mode";
            // 
            // comboBoxRandomGeneratorMode
            // 
            this.comboBoxRandomGeneratorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRandomGeneratorMode.FormattingEnabled = true;
            this.comboBoxRandomGeneratorMode.Items.AddRange(new object[] {
            "Phrase",
            "String"});
            this.comboBoxRandomGeneratorMode.Location = new System.Drawing.Point(14, 29);
            this.comboBoxRandomGeneratorMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxRandomGeneratorMode.Name = "comboBoxRandomGeneratorMode";
            this.comboBoxRandomGeneratorMode.Size = new System.Drawing.Size(428, 28);
            this.comboBoxRandomGeneratorMode.TabIndex = 0;
            // 
            // tabPageMeetingOptions
            // 
            this.tabPageMeetingOptions.Controls.Add(this.groupBoxToggleDefaults);
            this.tabPageMeetingOptions.Location = new System.Drawing.Point(4, 29);
            this.tabPageMeetingOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMeetingOptions.Name = "tabPageMeetingOptions";
            this.tabPageMeetingOptions.Size = new System.Drawing.Size(512, 265);
            this.tabPageMeetingOptions.TabIndex = 2;
            this.tabPageMeetingOptions.Text = "Meeting Options";
            this.tabPageMeetingOptions.UseVisualStyleBackColor = true;
            // 
            // tabPageLanguage
            // 
            this.tabPageLanguage.Controls.Add(this.groupBoxLanguage);
            this.tabPageLanguage.Location = new System.Drawing.Point(4, 29);
            this.tabPageLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageLanguage.Name = "tabPageLanguage";
            this.tabPageLanguage.Size = new System.Drawing.Size(512, 265);
            this.tabPageLanguage.TabIndex = 3;
            this.tabPageLanguage.Text = "Language";
            this.tabPageLanguage.UseVisualStyleBackColor = true;
            // 
            // panelRibbonOnEveryAppointment
            // 
            this.panelRibbonOnEveryAppointment.Controls.Add(this.radioButtonRibbonOnEveryAppointmentUntoggled);
            this.panelRibbonOnEveryAppointment.Controls.Add(this.radioButtonRibbonOnEveryAppointmentToggled);
            this.panelRibbonOnEveryAppointment.Controls.Add(this.labelRibbonOnEveryAppointment);
            this.panelRibbonOnEveryAppointment.Location = new System.Drawing.Point(9, 180);
            this.panelRibbonOnEveryAppointment.Name = "panelRibbonOnEveryAppointment";
            this.panelRibbonOnEveryAppointment.Size = new System.Drawing.Size(465, 48);
            this.panelRibbonOnEveryAppointment.TabIndex = 5;

            // labelRibbonOnEveryAppointment
            // 
            this.labelRibbonOnEveryAppointment.Location = new System.Drawing.Point(4, 5);
            this.labelRibbonOnEveryAppointment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRibbonOnEveryAppointment.MaximumSize = new System.Drawing.Size(350, 40);
            this.labelRibbonOnEveryAppointment.Name = "labelRibbonOnEveryAppointment";
            this.labelRibbonOnEveryAppointment.Size = new System.Drawing.Size(350, 40);
            this.labelRibbonOnEveryAppointment.TabIndex = 1;
            this.labelRibbonOnEveryAppointment.Text = "Show Jitsi Ribbon in every Appointment";
            // 
            // radioButtonRibbonOnEveryAppointmentToggled
            // 
            this.radioButtonRibbonOnEveryAppointmentToggled.AutoSize = true;
            this.radioButtonRibbonOnEveryAppointmentToggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRibbonOnEveryAppointmentToggled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonRibbonOnEveryAppointmentToggled.Location = new System.Drawing.Point(344, 5);
            this.radioButtonRibbonOnEveryAppointmentToggled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonRibbonOnEveryAppointmentToggled.Name = "radioButtonRibbonOnEveryAppointmentToggled";
            this.radioButtonRibbonOnEveryAppointmentToggled.Size = new System.Drawing.Size(21, 20);
            this.radioButtonRibbonOnEveryAppointmentToggled.TabIndex = 3;
            this.radioButtonRibbonOnEveryAppointmentToggled.TabStop = true;
            this.radioButtonRibbonOnEveryAppointmentToggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRibbonOnEveryAppointmentToggled.UseVisualStyleBackColor = true;
            // 
            // radioButtonRibbonOnEveryAppointmentUntoggled
            // 
            this.radioButtonRibbonOnEveryAppointmentUntoggled.AutoSize = true;
            this.radioButtonRibbonOnEveryAppointmentUntoggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRibbonOnEveryAppointmentUntoggled.Location = new System.Drawing.Point(417, 5);
            this.radioButtonRibbonOnEveryAppointmentUntoggled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonRibbonOnEveryAppointmentUntoggled.Name = "radioButtonRibbonOnEveryAppointmentUntoggled";
            this.radioButtonRibbonOnEveryAppointmentUntoggled.Size = new System.Drawing.Size(21, 20);
            this.radioButtonRibbonOnEveryAppointmentUntoggled.TabIndex = 4;
            this.radioButtonRibbonOnEveryAppointmentUntoggled.TabStop = true;
            this.radioButtonRibbonOnEveryAppointmentUntoggled.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(595, 395);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Jitsi Meet Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxDomain.ResumeLayout(false);
            this.groupBoxDomain.PerformLayout();
            this.groupBoxToggleDefaults.ResumeLayout(false);
            this.groupBoxToggleDefaults.PerformLayout();
            this.panelStartWithVideoMuted.ResumeLayout(false);
            this.panelStartWithVideoMuted.PerformLayout();
            this.panelStartWithAudioMuted.ResumeLayout(false);
            this.panelStartWithAudioMuted.PerformLayout();
            this.panelRequireDisplayName.ResumeLayout(false);
            this.panelRequireDisplayName.PerformLayout();
            this.groupBoxDefaultRoomID.ResumeLayout(false);
            this.groupBoxDefaultRoomID.PerformLayout();
            this.groupBoxLanguage.ResumeLayout(false);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageDomain.ResumeLayout(false);
            this.tabPageRoomId.ResumeLayout(false);
            this.groupBoxRandomGeneratorMode.ResumeLayout(false);
            this.tabPageMeetingOptions.ResumeLayout(false);
            this.tabPageLanguage.ResumeLayout(false);
            this.panelRibbonOnEveryAppointment.ResumeLayout(false);
            this.panelRibbonOnEveryAppointment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxDomain;
        private System.Windows.Forms.RadioButton radioButtonCustomDomain;
        private System.Windows.Forms.RadioButton radioButtonDefaultDomain;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxToggleDefaults;
        private System.Windows.Forms.Label labelToggled;
        private System.Windows.Forms.Label labelUntoggled;
        private System.Windows.Forms.Panel panelRequireDisplayName;
        private System.Windows.Forms.RadioButton radioButtonRequireDisplayNameToggled;
        private System.Windows.Forms.RadioButton radioButtonRequireDisplayNameUntoggled;
        private System.Windows.Forms.Label labelRequireDisplayName;
        private System.Windows.Forms.Panel panelStartWithVideoMuted;
        private System.Windows.Forms.RadioButton radioButtonStartWithVideoMutedToggled;
        private System.Windows.Forms.RadioButton radioButtonStartWithVideoMutedUntoggled;
        private System.Windows.Forms.Label labelStartWithVideoMuted;
        private System.Windows.Forms.Panel panelStartWithAudioMuted;
        private System.Windows.Forms.RadioButton radioButtonStartWithAudioMutedToggled;
        private System.Windows.Forms.RadioButton radioButtonStartWithAudioMutedUntoggled;
        private System.Windows.Forms.Label labelStartWithAudioMuted;
        private System.Windows.Forms.GroupBox groupBoxDefaultRoomID;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.RadioButton radioButtonCustomRoomID;
        private System.Windows.Forms.RadioButton radioButtonRandomRoomID;
        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageDomain;
        private System.Windows.Forms.TabPage tabPageRoomId;
        private System.Windows.Forms.TabPage tabPageMeetingOptions;
        private System.Windows.Forms.TabPage tabPageLanguage;
        private System.Windows.Forms.GroupBox groupBoxRandomGeneratorMode;
        private System.Windows.Forms.ComboBox comboBoxRandomGeneratorMode;
        private System.Windows.Forms.Panel panelRibbonOnEveryAppointment;
        private System.Windows.Forms.Label labelRibbonOnEveryAppointment;
        private System.Windows.Forms.RadioButton radioButtonRibbonOnEveryAppointmentUntoggled;
        private System.Windows.Forms.RadioButton radioButtonRibbonOnEveryAppointmentToggled;
    }
}