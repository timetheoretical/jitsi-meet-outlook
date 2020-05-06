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
            loadDomainButtons();
            loadStartWithAudioMutedButtons();
            loadStartWithVideoMutedButtons();
            loadRequireDisplayNameButtons();

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
                Properties.Settings.Default.Save();
                Dispose();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void radioDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDefault.Checked)
            {
                textBoxDomain.Enabled = false;
                textBoxDomain.Text = defaultDomain;
            }
        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustom.Checked)
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
            // Set domain
            if (radioButtonDefault.Checked)
            {
                Properties.Settings.Default.Domain = defaultDomain;
            }
            else
            {
                string newDomain = cleanDomain(textBoxDomain.Text);

                if (validDomain(newDomain))
                {
                    Properties.Settings.Default.Domain = newDomain;
                }
                else
                {
                    throw new InvalidOperationException("The domain entered is not valid.\n\nPlease specify a domain in the format 'your.domain.tld', 'yourdomain.tld' or similar.");
                }
            }

            // Set toggles
            if (radioButtonRequireDisplayNameToggled.Checked)
            {
                Properties.Settings.Default.requireDisplayName = true;
            } 
            else
            {
                Properties.Settings.Default.requireDisplayName = false;
            }

            if (radioButtonStartWithAudioMutedToggled.Checked)
            {
                Properties.Settings.Default.startWithAudioMuted = true;
            }
            else
            {
                Properties.Settings.Default.startWithAudioMuted = false;
            }

            if (radioButtonStartWithVideoMutedToggled.Checked)
            {
                Properties.Settings.Default.startWithVideoMuted = true;
            }
            else
            {
                Properties.Settings.Default.startWithVideoMuted = false;
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
            string domainWithoutPort = Regex.Replace(domain, ":\\d+", "");

            return Uri.CheckHostName(domainWithoutPort) != UriHostNameType.Unknown;
        }

        private void loadDomainButtons()
        {
            if (isDefaultDomain())
            {
                radioButtonDefault.Checked = true;
                radioButtonCustom.Checked = false;
            }
            else
            {
                radioButtonDefault.Checked = false;
                radioButtonCustom.Checked = true;
            }
        }

        private void loadRequireDisplayNameButtons()
        {
            if (Properties.Settings.Default.requireDisplayName)
            {
                radioButtonRequireDisplayNameToggled.Checked = true;
                radioButtonRequireDisplayNameUntoggled.Checked = false;
            } else
            {
                radioButtonRequireDisplayNameToggled.Checked = false;
                radioButtonRequireDisplayNameUntoggled.Checked = true;
            }
        }

        private void loadStartWithAudioMutedButtons()
        {
            if (Properties.Settings.Default.startWithAudioMuted)
            {
                radioButtonStartWithAudioMutedToggled.Checked = true;
                radioButtonStartWithAudioMutedUntoggled.Checked = false;
            }
            else
            {
                radioButtonStartWithAudioMutedToggled.Checked = false;
                radioButtonStartWithAudioMutedUntoggled.Checked = true;
            }
        }

        private void loadStartWithVideoMutedButtons()
        {
            if (Properties.Settings.Default.startWithVideoMuted)
            {
                radioButtonStartWithVideoMutedToggled.Checked = true;
                radioButtonStartWithVideoMutedUntoggled.Checked = false;
            }
            else
            {
                radioButtonStartWithVideoMutedToggled.Checked = false;
                radioButtonStartWithVideoMutedUntoggled.Checked = true;
            }
        }
    }
}
