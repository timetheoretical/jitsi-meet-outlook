using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MessageBox = System.Windows.Forms.MessageBox;

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
            try
            {
                setSettings();
                Dispose();
            }
            catch (InvalidOperationException ex)
            {
                // Do nothing
            }
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
                Properties.Settings.Default.Save();

            }
            else
            {
                string newDomain = cleanDomain(textBoxDomain.Text);

                if (validDomain(newDomain))
                {
                    Properties.Settings.Default.Domain = newDomain;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("The domain entered is not valid.\n\nPlease specify a domain in the format 'your.domain.tld', 'yourdomain.tld' or similar.");
                    throw new InvalidOperationException("Invalid domain");
                }


            }
        }

        private string cleanDomain(string userInput)
        {
            string withoutEndSlash = Regex.Replace(userInput, "/*$", "");

            string withoutHttp = Regex.Replace(withoutEndSlash, "^http(s)?://", "");

            string cleanedDomain = withoutHttp;

            return cleanedDomain;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private bool validDomain(string domain)
        {
            return Uri.CheckHostName(domain) != UriHostNameType.Unknown;
        }
    }
}
