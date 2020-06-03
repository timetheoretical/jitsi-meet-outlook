using System;
using System.IO;
using System.Linq;
using System.Xml;
using Microsoft.Deployment.WindowsInstaller;

namespace SettingsInstallerParameters
{
    public class CustomActions
    {
        
        [CustomAction]
        public static ActionResult UpdateConfigXml(Session session)
        {
            session.Log("Starting UpdateConfigXml");
            try
            {
                updateConfigXml(session);
                session.Log("Successfully finished UpdateConfigXml");
                return ActionResult.Success;
            }
            catch(Exception err)
            {
                session.Log("An issue was encountered in UpdateConfigXml:\n" + err);
                return ActionResult.Failure;
            }
        }

        private static void updateConfigXml(Session session)
        {
            // Write install path to config file
            string xmlPath = Path.Combine(getInstallDir(session), "Jitsi Meet Outlook Add-In.dll.config");

            XmlDocument document = new XmlDocument();
            document.Load(xmlPath);
            System.Xml.XPath.XPathNavigator navigator = document.CreateNavigator();


            if (getDomain(session).Length != 0)
            {
                session.Log($"Setting custom domain: {getDomain(session)}");
                navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='Domain']/value").SetValue(getDomain(session));
            }

            
            if (getRoomID(session).Length != 0)
            {
                session.Log($"Setting custom room ID: {getRoomID(session)}");
                navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='roomID']/value").SetValue(getRoomID(session));
            }

            session.Log($"Setting require name option: {getRequireDisplayName(session)}");
            navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='requireDisplayName']/value").SetValue(getRequireDisplayName(session));

            session.Log($"Setting audio muted option: {getStartWithAudioMuted(session)}");
            navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='startWithAudioMuted']/value").SetValue(getStartWithAudioMuted(session));

            session.Log($"Setting video muted option: {getStartWithVideoMuted(session)}");
            navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='startWithVideoMuted']/value").SetValue(getStartWithVideoMuted(session));

            session.Log($"Setting install directory: {getInstallDir(session)}");
            navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='installDirectory']/value").SetValue(getInstallDir(session));

            session.Log($"Setting display language: {getLanguage(session)}");
            navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='language']/value").SetValue(getLanguage(session));

            session.Log($"Saving settings to: {xmlPath}");
            document.Save(xmlPath);
        }

        private static string getInstallDir(Session session)
        {
            return Path.GetDirectoryName(session.CustomActionData["InstallDir"]);
        }

        private static string getDomain(Session session)
        {
            return session.CustomActionData["Domain"];
        }

        private static string getRoomID(Session session)
        {
            return session.CustomActionData["roomID"];
        }

        private static string getRequireDisplayName(Session session)
        {
            return getBooleanParameter(session, "requireDisplayName");
        }

        private static string getStartWithAudioMuted(Session session)
        {
            return getBooleanParameter(session, "startWithAudioMuted");
        }

        private static string getStartWithVideoMuted(Session session)
        {
            return getBooleanParameter(session, "startWithVideoMuted");
        }

        private static string getLanguage(Session session)
        {
            string[] availableLanguages = { "en", "fr" };
            string userLanguageInput = session.CustomActionData["language"];

            if (availableLanguages.Contains(userLanguageInput))
            {
                return userLanguageInput;
            }
            else
            {
                return "en";
            }

        }


        private static string getBooleanParameter(Session session, string parameter)
        {
            string userInput = session.CustomActionData[parameter];

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

        private static bool validBoolSettingInput(string input)
        {
            String[] xmlBoolean = { "true", "false" };

            if (xmlBoolean.Contains(input.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string ToTitleCase(string input)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}
