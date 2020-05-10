using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Xml;


namespace JitsiMeetOutlook
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }


        public override void Install(IDictionary stateSaver)
        {
            //stateSaver.Add("InstallPath", Path.GetDirectoryName(Context.Parameters["assemblypath"]));
            base.Install(stateSaver);

            updateConfigXml();

        }

        private void updateConfigXml()
        {
            // Write install path to config file
            string xmlPath = Path.Combine(getInstallDir(), "Jitsi Meet Outlook Add-In.dll.config");

            XmlDocument document = new XmlDocument();
            document.Load(xmlPath);
            System.Xml.XPath.XPathNavigator navigator = document.CreateNavigator();


            if (getDomain().Length != 0)
            {
                navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='Domain']/value").SetValue(getDomain());
            }


            if (getRoomID().Length != 0)
            {
                navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='roomID']/value").SetValue(getRoomID());
            }


            navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='requireDisplayName']/value").SetValue(getRequireDisplayName());

            navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='startWithAudioMuted']/value").SetValue(getStartWithAudioMuted());

            navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='startWithVideoMuted']/value").SetValue(getStartWithVideoMuted());

            navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='installDirectory']/value").SetValue(getInstallDir());

            document.Save(xmlPath);
        }

        private string getInstallDir()
        {
            return Path.GetDirectoryName(Context.Parameters["assemblypath"]);
        }

        private string getDomain()
        {
            return Context.Parameters["Domain"];
        }

        private string getRoomID()
        {
            return Context.Parameters["roomID"];
        }

        private string getRequireDisplayName()
        {
            return getBooleanParameter("requireDisplayName");
        }

        private string getStartWithAudioMuted()
        {
            return getBooleanParameter("startWithAudioMuted");
        }

        private string getStartWithVideoMuted()
        {
            return getBooleanParameter("startWithVideoMuted");
        }


        private string getBooleanParameter(string parameter)
        {
            string userInput = Context.Parameters[parameter];

            if (userInput == null)
            {
                return "False";
            }
            else if (validBoolSettingInput(userInput))
            {
                return ToTitleCase(userInput);
            }
            else
            {
                return "False";
            }
        }

        private bool validBoolSettingInput(string input)
        {
            String[] xmlBoolean = { "true", "false" };

            if (xmlBoolean.Contains(input.ToLower())) {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string ToTitleCase(string input)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}
