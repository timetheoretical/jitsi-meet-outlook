using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JitsiMeetOutlook
{
    public partial class FormSettings : Form
    {
        string defaultDomain;

        public FormSettings()
        {
            InitializeComponent();

            // Set default domain
            defaultDomain = "meet.jit.si";

            // Set radio buttons
            if (isDefaultDomain())
            {
                radioDefault.Checked = true;
                radioCustom.Checked = false;
            } else
            {
                radioDefault.Checked = false;
                radioCustom.Checked = true;
            }

            // Load text field
            textBoxDomain.Text = Properties.Settings.Default.Domain;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            setSettings();
            Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void radioDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDefault.Checked)
            {
                textBoxDomain.Enabled = false;
                textBoxDomain.Text = defaultDomain;
            }
        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCustom.Checked)
            {
                textBoxDomain.Text = null;
                textBoxDomain.Enabled = true;
            }
        }

        private void textBoxDomain_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isDefaultDomain()
        {
            if (Properties.Settings.Default.Domain == defaultDomain)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void setSettings()
        {
            if (radioDefault.Checked)
            {
                Properties.Settings.Default.Domain = defaultDomain;
            }
            else
            {
                Properties.Settings.Default.Domain = textBoxDomain.Text;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
