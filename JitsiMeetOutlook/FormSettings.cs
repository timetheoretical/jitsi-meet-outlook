using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Linq;
using System.Text.Json;

namespace JitsiMeetOutlook
{
    public partial class FormSettings : Form
    {

        string defaultDomain;

        public FormSettings()
        {
            InitializeComponent();
            loadSettings();
        }

        private void loadSettings()
        {
            // Set default domain
            defaultDomain = "meet.jit.si";

            // Set radio buttons
            loadDomainButtons();
            loadRoomIDButtons();
            loadStartWithAudioMutedButtons();
            loadStartWithVideoMutedButtons();
            loadRequireDisplayNameButtons();

            // Load text field
            textBoxDomain.Text = Properties.Settings.Default.Domain;

            // Load body texts
            // The translations contain wierd newline definitions. Fix them by only using the "\n" newline character.
            // In the properties, we allow "\r\n" encoded as literal @"\n" so we can easily pass it to msiexec.
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.textBodyMessage))
            {
                textBoxMessage.Text = Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyMessage").Replace("\r", "").Replace("\n", "\r\n");
            }
            else
            {
                textBoxMessage.Text = Properties.Settings.Default.textBodyMessage.Replace(@"\n", "\r\n");
            }
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.textBodyDisclaimer))
            {
                textBoxDisclaimer.Text = Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyDisclaimer").Replace("\r", "").Replace("\n", "\r\n");
            }
            else
            {
                textBoxDisclaimer.Text = Properties.Settings.Default.textBodyDisclaimer.Replace(@"\n", "\r\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setLanguage();
            loadComboBoxLanguage();
            loadComboBoxRandomGeneratorMode();
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

        private void radioButtonDefaultDomain_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDefaultDomain.Checked)
            {
                textBoxDomain.Enabled = false;
                textBoxDomain.Text = defaultDomain;
            }
        }

        private void radioButtonCustomDomain_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustomDomain.Checked)
            {
                textBoxDomain.Text = null;
                textBoxDomain.Enabled = true;
            }
        }

        private void radioButtonRandomID_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRandomRoomID.Checked)
            {
                textBoxRoomID.Enabled = false;
                textBoxRoomID.Text = null;
            }
        }

        private void radioButtonCustomRoomID_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRoomID.Enabled = true;
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
            if (radioButtonDefaultDomain.Checked)
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

            // Set room ID
            if (radioButtonRandomRoomID.Checked)
            {
                Properties.Settings.Default.roomID = "";
            }
            else
            {
                if (textBoxRoomID.Text.Length > 0)
                {
                    Properties.Settings.Default.roomID = textBoxRoomID.Text;
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

            // Set language
            string languageSelection = (string)comboBoxLanguage.SelectedItem;
            Properties.Settings.Default.language = languageDropDown.FirstOrDefault(x => x.Value == languageSelection).Key;

            // Set random generator mode
            string randomGeneratorModeSelection = (string)comboBoxRandomGeneratorMode.SelectedItem;
            Properties.Settings.Default.randomRoomIdGeneratorMode = randomGeneratorModeDropDown.FirstOrDefault(x => x.Value == randomGeneratorModeSelection).Key;

            // Set body texts
            Properties.Settings.Default.textBodyMessage = textBoxMessage.Text;
            Properties.Settings.Default.textBodyDisclaimer = textBoxDisclaimer.Text;
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
                radioButtonDefaultDomain.Checked = true;
                radioButtonCustomDomain.Checked = false;
            }
            else
            {
                radioButtonDefaultDomain.Checked = false;
                radioButtonCustomDomain.Checked = true;
            }
        }

        private void loadRoomIDButtons()
        {
            if (Properties.Settings.Default.roomID.Length == 0)
            {
                radioButtonRandomRoomID.Checked = true;
                radioButtonCustomRoomID.Checked = false;
            }
            else
            {
                radioButtonRandomRoomID.Checked = false;
                radioButtonCustomRoomID.Checked = true;
                textBoxRoomID.Text = Properties.Settings.Default.roomID;
            }
        }

        private void loadRequireDisplayNameButtons()
        {
            if (Properties.Settings.Default.requireDisplayName)
            {
                radioButtonRequireDisplayNameToggled.Checked = true;
                radioButtonRequireDisplayNameUntoggled.Checked = false;
            }
            else
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

        private void loadComboBoxLanguage()
        {
            JsonElement jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("settings");
            comboBoxLanguage.SelectedItem = jsonUILanguage.GetProperty("comboBoxLanguageItems").GetProperty(Properties.Settings.Default.language).GetString();
        }

        private void loadComboBoxRandomGeneratorMode()
        {
            JsonElement jsonUILanguage = Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("settings");
            comboBoxRandomGeneratorMode.SelectedItem = jsonUILanguage.GetProperty("comboBoxRandomGeneratorMode").GetProperty(Properties.Settings.Default.randomRoomIdGeneratorMode).GetString();
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // When editing a multi-line text, we want the Enter key to insert a line break
        // instead of accepting and closing the dialog
        private void textBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            AcceptButton = buttonOK;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            loadSettings();
        }
    }
}
