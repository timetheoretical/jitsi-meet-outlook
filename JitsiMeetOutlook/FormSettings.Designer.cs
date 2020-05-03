namespace JitsiMeetOutlook
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
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRequireDisplayName = new System.Windows.Forms.Panel();
            this.radioButtonRequireDisplayNameToggled = new System.Windows.Forms.RadioButton();
            this.radioButtonRequireDisplayNameUntoggled = new System.Windows.Forms.RadioButton();
            this.labelRequireDisplayName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxDomain.SuspendLayout();
            this.groupBoxToggleDefaults.SuspendLayout();
            this.panelStartWithVideoMuted.SuspendLayout();
            this.panelStartWithAudioMuted.SuspendLayout();
            this.panelRequireDisplayName.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
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
            this.groupBoxDomain.Controls.Add(this.radioButtonCustom);
            this.groupBoxDomain.Controls.Add(this.radioButtonDefault);
            this.groupBoxDomain.Location = new System.Drawing.Point(12, 27);
            this.groupBoxDomain.Name = "groupBoxDomain";
            this.groupBoxDomain.Size = new System.Drawing.Size(303, 70);
            this.groupBoxDomain.TabIndex = 2;
            this.groupBoxDomain.TabStop = false;
            this.groupBoxDomain.Text = "Domain";
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Location = new System.Drawing.Point(75, 42);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(218, 20);
            this.textBoxDomain.TabIndex = 2;
            this.textBoxDomain.TextChanged += new System.EventHandler(this.textBoxDomain_TextChanged);
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(63, 17);
            this.radioButtonCustom.TabIndex = 1;
            this.radioButtonCustom.TabStop = true;
            this.radioButtonCustom.Text = "Custom:";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            this.radioButtonCustom.CheckedChanged += new System.EventHandler(this.radioCustom_CheckedChanged);
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(59, 17);
            this.radioButtonDefault.TabIndex = 0;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Default";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            this.radioButtonDefault.CheckedChanged += new System.EventHandler(this.radioDefault_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(159, 219);
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
            this.buttonCancel.Location = new System.Drawing.Point(240, 219);
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
            this.groupBoxToggleDefaults.Controls.Add(this.label3);
            this.groupBoxToggleDefaults.Controls.Add(this.label2);
            this.groupBoxToggleDefaults.Controls.Add(this.panelRequireDisplayName);
            this.groupBoxToggleDefaults.Location = new System.Drawing.Point(12, 103);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(198, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toggled";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(244, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Untoggled";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // FormSettings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(327, 247);
            this.Controls.Add(this.groupBoxToggleDefaults);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxDomain);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxDomain;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxToggleDefaults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
    }
}