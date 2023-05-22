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
            this.tabPageTexts = new System.Windows.Forms.TabPage();
            this.groupBoxDisclaimer = new System.Windows.Forms.GroupBox();
            this.textBoxDisclaimer = new System.Windows.Forms.TextBox();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
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
            this.tabPageTexts.SuspendLayout();
            this.groupBoxDisclaimer.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBoxDomain
            // 
            this.groupBoxDomain.Controls.Add(this.textBoxDomain);
            this.groupBoxDomain.Controls.Add(this.radioButtonCustomDomain);
            this.groupBoxDomain.Controls.Add(this.radioButtonDefaultDomain);
            this.groupBoxDomain.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDomain.Name = "groupBoxDomain";
            this.groupBoxDomain.Size = new System.Drawing.Size(303, 70);
            this.groupBoxDomain.TabIndex = 2;
            this.groupBoxDomain.TabStop = false;
            this.groupBoxDomain.Text = "Domain";
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Location = new System.Drawing.Point(113, 42);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(180, 20);
            this.textBoxDomain.TabIndex = 2;
            this.textBoxDomain.TextChanged += new System.EventHandler(this.textBoxDomain_TextChanged);
            // 
            // radioButtonCustomDomain
            // 
            this.radioButtonCustomDomain.AutoSize = true;
            this.radioButtonCustomDomain.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCustomDomain.Name = "radioButtonCustomDomain";
            this.radioButtonCustomDomain.Size = new System.Drawing.Size(63, 17);
            this.radioButtonCustomDomain.TabIndex = 1;
            this.radioButtonCustomDomain.TabStop = true;
            this.radioButtonCustomDomain.Text = "Custom:";
            this.radioButtonCustomDomain.UseVisualStyleBackColor = true;
            this.radioButtonCustomDomain.CheckedChanged += new System.EventHandler(this.radioButtonCustomDomain_CheckedChanged);
            // 
            // radioButtonDefaultDomain
            // 
            this.radioButtonDefaultDomain.AutoSize = true;
            this.radioButtonDefaultDomain.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDefaultDomain.Name = "radioButtonDefaultDomain";
            this.radioButtonDefaultDomain.Size = new System.Drawing.Size(59, 17);
            this.radioButtonDefaultDomain.TabIndex = 0;
            this.radioButtonDefaultDomain.TabStop = true;
            this.radioButtonDefaultDomain.Text = "Default";
            this.radioButtonDefaultDomain.UseVisualStyleBackColor = true;
            this.radioButtonDefaultDomain.CheckedChanged += new System.EventHandler(this.radioButtonDefaultDomain_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(99, 227);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(180, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxToggleDefaults
            // 
            this.groupBoxToggleDefaults.Controls.Add(this.panelStartWithVideoMuted);
            this.groupBoxToggleDefaults.Controls.Add(this.panelStartWithAudioMuted);
            this.groupBoxToggleDefaults.Controls.Add(this.labelToggled);
            this.groupBoxToggleDefaults.Controls.Add(this.labelUntoggled);
            this.groupBoxToggleDefaults.Controls.Add(this.panelRequireDisplayName);
            this.groupBoxToggleDefaults.Location = new System.Drawing.Point(5, 6);
            this.groupBoxToggleDefaults.Name = "groupBoxToggleDefaults";
            this.groupBoxToggleDefaults.Size = new System.Drawing.Size(303, 110);
            this.groupBoxToggleDefaults.TabIndex = 5;
            this.groupBoxToggleDefaults.TabStop = false;
            this.groupBoxToggleDefaults.Text = "Default meeting options";
            // 
            // panelStartWithVideoMuted
            // 
            this.panelStartWithVideoMuted.Controls.Add(this.radioButtonStartWithVideoMutedToggled);
            this.panelStartWithVideoMuted.Controls.Add(this.radioButtonStartWithVideoMutedUntoggled);
            this.panelStartWithVideoMuted.Controls.Add(this.labelStartWithVideoMuted);
            this.panelStartWithVideoMuted.Location = new System.Drawing.Point(6, 79);
            this.panelStartWithVideoMuted.Name = "panelStartWithVideoMuted";
            this.panelStartWithVideoMuted.Size = new System.Drawing.Size(287, 19);
            this.panelStartWithVideoMuted.TabIndex = 3;
            // 
            // radioButtonStartWithVideoMutedToggled
            // 
            this.radioButtonStartWithVideoMutedToggled.AutoSize = true;
            this.radioButtonStartWithVideoMutedToggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithVideoMutedToggled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonStartWithVideoMutedToggled.Location = new System.Drawing.Point(207, 3);
            this.radioButtonStartWithVideoMutedToggled.Name = "radioButtonStartWithVideoMutedToggled";
            this.radioButtonStartWithVideoMutedToggled.Size = new System.Drawing.Size(14, 13);
            this.radioButtonStartWithVideoMutedToggled.TabIndex = 2;
            this.radioButtonStartWithVideoMutedToggled.TabStop = true;
            this.radioButtonStartWithVideoMutedToggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithVideoMutedToggled.UseVisualStyleBackColor = true;
            // 
            // radioButtonStartWithVideoMutedUntoggled
            // 
            this.radioButtonStartWithVideoMutedUntoggled.AutoSize = true;
            this.radioButtonStartWithVideoMutedUntoggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithVideoMutedUntoggled.Location = new System.Drawing.Point(260, 3);
            this.radioButtonStartWithVideoMutedUntoggled.Name = "radioButtonStartWithVideoMutedUntoggled";
            this.radioButtonStartWithVideoMutedUntoggled.Size = new System.Drawing.Size(14, 13);
            this.radioButtonStartWithVideoMutedUntoggled.TabIndex = 1;
            this.radioButtonStartWithVideoMutedUntoggled.TabStop = true;
            this.radioButtonStartWithVideoMutedUntoggled.UseVisualStyleBackColor = true;
            // 
            // labelStartWithVideoMuted
            // 
            this.labelStartWithVideoMuted.AutoSize = true;
            this.labelStartWithVideoMuted.Location = new System.Drawing.Point(3, 3);
            this.labelStartWithVideoMuted.Name = "labelStartWithVideoMuted";
            this.labelStartWithVideoMuted.Size = new System.Drawing.Size(91, 13);
            this.labelStartWithVideoMuted.TabIndex = 0;
            this.labelStartWithVideoMuted.Text = "No Video on Start";
            // 
            // panelStartWithAudioMuted
            // 
            this.panelStartWithAudioMuted.Controls.Add(this.radioButtonStartWithAudioMutedToggled);
            this.panelStartWithAudioMuted.Controls.Add(this.radioButtonStartWithAudioMutedUntoggled);
            this.panelStartWithAudioMuted.Controls.Add(this.labelStartWithAudioMuted);
            this.panelStartWithAudioMuted.Location = new System.Drawing.Point(6, 57);
            this.panelStartWithAudioMuted.Name = "panelStartWithAudioMuted";
            this.panelStartWithAudioMuted.Size = new System.Drawing.Size(287, 19);
            this.panelStartWithAudioMuted.TabIndex = 3;
            // 
            // radioButtonStartWithAudioMutedToggled
            // 
            this.radioButtonStartWithAudioMutedToggled.AutoSize = true;
            this.radioButtonStartWithAudioMutedToggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithAudioMutedToggled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonStartWithAudioMutedToggled.Location = new System.Drawing.Point(207, 3);
            this.radioButtonStartWithAudioMutedToggled.Name = "radioButtonStartWithAudioMutedToggled";
            this.radioButtonStartWithAudioMutedToggled.Size = new System.Drawing.Size(14, 13);
            this.radioButtonStartWithAudioMutedToggled.TabIndex = 2;
            this.radioButtonStartWithAudioMutedToggled.TabStop = true;
            this.radioButtonStartWithAudioMutedToggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithAudioMutedToggled.UseVisualStyleBackColor = true;
            // 
            // radioButtonStartWithAudioMutedUntoggled
            // 
            this.radioButtonStartWithAudioMutedUntoggled.AutoSize = true;
            this.radioButtonStartWithAudioMutedUntoggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStartWithAudioMutedUntoggled.Location = new System.Drawing.Point(260, 3);
            this.radioButtonStartWithAudioMutedUntoggled.Name = "radioButtonStartWithAudioMutedUntoggled";
            this.radioButtonStartWithAudioMutedUntoggled.Size = new System.Drawing.Size(14, 13);
            this.radioButtonStartWithAudioMutedUntoggled.TabIndex = 1;
            this.radioButtonStartWithAudioMutedUntoggled.TabStop = true;
            this.radioButtonStartWithAudioMutedUntoggled.UseVisualStyleBackColor = true;
            // 
            // labelStartWithAudioMuted
            // 
            this.labelStartWithAudioMuted.AutoSize = true;
            this.labelStartWithAudioMuted.Location = new System.Drawing.Point(3, 3);
            this.labelStartWithAudioMuted.Name = "labelStartWithAudioMuted";
            this.labelStartWithAudioMuted.Size = new System.Drawing.Size(71, 13);
            this.labelStartWithAudioMuted.TabIndex = 0;
            this.labelStartWithAudioMuted.Text = "Mute on Start";
            // 
            // labelToggled
            // 
            this.labelToggled.AutoSize = true;
            this.labelToggled.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelToggled.Location = new System.Drawing.Point(198, 16);
            this.labelToggled.Name = "labelToggled";
            this.labelToggled.Size = new System.Drawing.Size(46, 13);
            this.labelToggled.TabIndex = 4;
            this.labelToggled.Text = "Toggled";
            this.labelToggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUntoggled
            // 
            this.labelUntoggled.AutoSize = true;
            this.labelUntoggled.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelUntoggled.Location = new System.Drawing.Point(244, 16);
            this.labelUntoggled.Name = "labelUntoggled";
            this.labelUntoggled.Size = new System.Drawing.Size(56, 13);
            this.labelUntoggled.TabIndex = 3;
            this.labelUntoggled.Text = "Untoggled";
            this.labelUntoggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRequireDisplayName
            // 
            this.panelRequireDisplayName.Controls.Add(this.radioButtonRequireDisplayNameToggled);
            this.panelRequireDisplayName.Controls.Add(this.radioButtonRequireDisplayNameUntoggled);
            this.panelRequireDisplayName.Controls.Add(this.labelRequireDisplayName);
            this.panelRequireDisplayName.Location = new System.Drawing.Point(6, 32);
            this.panelRequireDisplayName.Name = "panelRequireDisplayName";
            this.panelRequireDisplayName.Size = new System.Drawing.Size(287, 19);
            this.panelRequireDisplayName.TabIndex = 0;
            // 
            // radioButtonRequireDisplayNameToggled
            // 
            this.radioButtonRequireDisplayNameToggled.AutoSize = true;
            this.radioButtonRequireDisplayNameToggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRequireDisplayNameToggled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonRequireDisplayNameToggled.Location = new System.Drawing.Point(207, 3);
            this.radioButtonRequireDisplayNameToggled.Name = "radioButtonRequireDisplayNameToggled";
            this.radioButtonRequireDisplayNameToggled.Size = new System.Drawing.Size(14, 13);
            this.radioButtonRequireDisplayNameToggled.TabIndex = 2;
            this.radioButtonRequireDisplayNameToggled.TabStop = true;
            this.radioButtonRequireDisplayNameToggled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRequireDisplayNameToggled.UseVisualStyleBackColor = true;
            // 
            // radioButtonRequireDisplayNameUntoggled
            // 
            this.radioButtonRequireDisplayNameUntoggled.AutoSize = true;
            this.radioButtonRequireDisplayNameUntoggled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRequireDisplayNameUntoggled.Location = new System.Drawing.Point(260, 3);
            this.radioButtonRequireDisplayNameUntoggled.Name = "radioButtonRequireDisplayNameUntoggled";
            this.radioButtonRequireDisplayNameUntoggled.Size = new System.Drawing.Size(14, 13);
            this.radioButtonRequireDisplayNameUntoggled.TabIndex = 1;
            this.radioButtonRequireDisplayNameUntoggled.TabStop = true;
            this.radioButtonRequireDisplayNameUntoggled.UseVisualStyleBackColor = true;
            // 
            // labelRequireDisplayName
            // 
            this.labelRequireDisplayName.AutoSize = true;
            this.labelRequireDisplayName.Location = new System.Drawing.Point(3, 3);
            this.labelRequireDisplayName.Name = "labelRequireDisplayName";
            this.labelRequireDisplayName.Size = new System.Drawing.Size(75, 13);
            this.labelRequireDisplayName.TabIndex = 0;
            this.labelRequireDisplayName.Text = "Require Name";
            // 
            // groupBoxDefaultRoomID
            // 
            this.groupBoxDefaultRoomID.Controls.Add(this.textBoxRoomID);
            this.groupBoxDefaultRoomID.Controls.Add(this.radioButtonCustomRoomID);
            this.groupBoxDefaultRoomID.Controls.Add(this.radioButtonRandomRoomID);
            this.groupBoxDefaultRoomID.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDefaultRoomID.Name = "groupBoxDefaultRoomID";
            this.groupBoxDefaultRoomID.Size = new System.Drawing.Size(303, 70);
            this.groupBoxDefaultRoomID.TabIndex = 3;
            this.groupBoxDefaultRoomID.TabStop = false;
            this.groupBoxDefaultRoomID.Text = "Default room ID";
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(113, 42);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(180, 20);
            this.textBoxRoomID.TabIndex = 2;
            // 
            // radioButtonCustomRoomID
            // 
            this.radioButtonCustomRoomID.AutoSize = true;
            this.radioButtonCustomRoomID.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCustomRoomID.Name = "radioButtonCustomRoomID";
            this.radioButtonCustomRoomID.Size = new System.Drawing.Size(63, 17);
            this.radioButtonCustomRoomID.TabIndex = 1;
            this.radioButtonCustomRoomID.TabStop = true;
            this.radioButtonCustomRoomID.Text = "Custom:";
            this.radioButtonCustomRoomID.UseVisualStyleBackColor = true;
            this.radioButtonCustomRoomID.CheckedChanged += new System.EventHandler(this.radioButtonCustomRoomID_CheckedChanged);
            // 
            // radioButtonRandomRoomID
            // 
            this.radioButtonRandomRoomID.AutoSize = true;
            this.radioButtonRandomRoomID.Location = new System.Drawing.Point(6, 19);
            this.radioButtonRandomRoomID.Name = "radioButtonRandomRoomID";
            this.radioButtonRandomRoomID.Size = new System.Drawing.Size(65, 17);
            this.radioButtonRandomRoomID.TabIndex = 0;
            this.radioButtonRandomRoomID.TabStop = true;
            this.radioButtonRandomRoomID.Text = "Random";
            this.radioButtonRandomRoomID.UseVisualStyleBackColor = true;
            this.radioButtonRandomRoomID.CheckedChanged += new System.EventHandler(this.radioButtonRandomID_CheckedChanged);
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.Controls.Add(this.comboBoxLanguage);
            this.groupBoxLanguage.Location = new System.Drawing.Point(5, 3);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.Size = new System.Drawing.Size(303, 49);
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
            this.comboBoxLanguage.Location = new System.Drawing.Point(9, 19);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(287, 21);
            this.comboBoxLanguage.TabIndex = 0;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageDomain);
            this.tabControlSettings.Controls.Add(this.tabPageRoomId);
            this.tabControlSettings.Controls.Add(this.tabPageMeetingOptions);
            this.tabControlSettings.Controls.Add(this.tabPageLanguage);
            this.tabControlSettings.Controls.Add(this.tabPageTexts);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 27);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(328, 194);
            this.tabControlSettings.TabIndex = 6;
            // 
            // tabPageDomain
            // 
            this.tabPageDomain.Controls.Add(this.groupBoxDomain);
            this.tabPageDomain.Location = new System.Drawing.Point(4, 22);
            this.tabPageDomain.Name = "tabPageDomain";
            this.tabPageDomain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDomain.Size = new System.Drawing.Size(320, 168);
            this.tabPageDomain.TabIndex = 0;
            this.tabPageDomain.Text = "Domain";
            this.tabPageDomain.UseVisualStyleBackColor = true;
            // 
            // tabPageRoomId
            // 
            this.tabPageRoomId.Controls.Add(this.groupBoxRandomGeneratorMode);
            this.tabPageRoomId.Controls.Add(this.groupBoxDefaultRoomID);
            this.tabPageRoomId.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoomId.Name = "tabPageRoomId";
            this.tabPageRoomId.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoomId.Size = new System.Drawing.Size(320, 168);
            this.tabPageRoomId.TabIndex = 1;
            this.tabPageRoomId.Text = "Room ID";
            this.tabPageRoomId.UseVisualStyleBackColor = true;
            // 
            // groupBoxRandomGeneratorMode
            // 
            this.groupBoxRandomGeneratorMode.Controls.Add(this.comboBoxRandomGeneratorMode);
            this.groupBoxRandomGeneratorMode.Location = new System.Drawing.Point(6, 82);
            this.groupBoxRandomGeneratorMode.Name = "groupBoxRandomGeneratorMode";
            this.groupBoxRandomGeneratorMode.Size = new System.Drawing.Size(303, 49);
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
            this.comboBoxRandomGeneratorMode.Location = new System.Drawing.Point(9, 19);
            this.comboBoxRandomGeneratorMode.Name = "comboBoxRandomGeneratorMode";
            this.comboBoxRandomGeneratorMode.Size = new System.Drawing.Size(287, 21);
            this.comboBoxRandomGeneratorMode.TabIndex = 0;
            // 
            // tabPageMeetingOptions
            // 
            this.tabPageMeetingOptions.Controls.Add(this.groupBoxToggleDefaults);
            this.tabPageMeetingOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageMeetingOptions.Name = "tabPageMeetingOptions";
            this.tabPageMeetingOptions.Size = new System.Drawing.Size(320, 168);
            this.tabPageMeetingOptions.TabIndex = 2;
            this.tabPageMeetingOptions.Text = "Meeting Options";
            this.tabPageMeetingOptions.UseVisualStyleBackColor = true;
            // 
            // tabPageLanguage
            // 
            this.tabPageLanguage.Controls.Add(this.groupBoxLanguage);
            this.tabPageLanguage.Location = new System.Drawing.Point(4, 22);
            this.tabPageLanguage.Name = "tabPageLanguage";
            this.tabPageLanguage.Size = new System.Drawing.Size(320, 168);
            this.tabPageLanguage.TabIndex = 3;
            this.tabPageLanguage.Text = "Language";
            this.tabPageLanguage.UseVisualStyleBackColor = true;
            // 
            // tabPageTexts
            // 
            this.tabPageTexts.Controls.Add(this.groupBoxDisclaimer);
            this.tabPageTexts.Controls.Add(this.groupBoxMessage);
            this.tabPageTexts.Location = new System.Drawing.Point(4, 22);
            this.tabPageTexts.Name = "tabPageTexts";
            this.tabPageTexts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTexts.Size = new System.Drawing.Size(320, 168);
            this.tabPageTexts.TabIndex = 4;
            this.tabPageTexts.Text = "Texts";
            this.tabPageTexts.UseVisualStyleBackColor = true;
            // 
            // groupBoxDisclaimer
            // 
            this.groupBoxDisclaimer.Controls.Add(this.textBoxDisclaimer);
            this.groupBoxDisclaimer.Location = new System.Drawing.Point(6, 103);
            this.groupBoxDisclaimer.Name = "groupBoxDisclaimer";
            this.groupBoxDisclaimer.Size = new System.Drawing.Size(308, 59);
            this.groupBoxDisclaimer.TabIndex = 1;
            this.groupBoxDisclaimer.TabStop = false;
            this.groupBoxDisclaimer.Text = "Disclaimer";
            // 
            // textBoxDisclaimer
            // 
            this.textBoxDisclaimer.Location = new System.Drawing.Point(6, 19);
            this.textBoxDisclaimer.Multiline = true;
            this.textBoxDisclaimer.Name = "textBoxDisclaimer";
            this.textBoxDisclaimer.Size = new System.Drawing.Size(296, 34);
            this.textBoxDisclaimer.TabIndex = 0;
            this.textBoxDisclaimer.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxDisclaimer.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.textBoxMessage);
            this.groupBoxMessage.Location = new System.Drawing.Point(6, 6);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(308, 91);
            this.groupBoxMessage.TabIndex = 0;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Message";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(6, 19);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(296, 66);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxMessage.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(261, 227);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(354, 257);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.tabPageTexts.ResumeLayout(false);
            this.groupBoxDisclaimer.ResumeLayout(false);
            this.groupBoxDisclaimer.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPageTexts;
        private System.Windows.Forms.GroupBox groupBoxDisclaimer;
        private System.Windows.Forms.TextBox textBoxDisclaimer;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonReset;
    }
}