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
            catch (Exception err)
            {
                session.Log("An issue was encountered in UpdateConfigXml:\n" + err);
                return ActionResult.Failure;
            }
        }

        private static void updateConfigXml(Session session)
        {
            // Write install path to config file
            string xmlPath = Path.Combine(getInstallDir(session), "JitsiMeetOutlookAddIn.dll.config");

            session.Log($"Executing on file: {xmlPath}");
            if (!File.Exists(xmlPath))
            {
                session.Log($"File to patch does not exist: {xmlPath}");
                return;
            }

            // TODO: Implement new settings

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

            session.Log($"Setting random ID generator mode: {getLanguage(session)}");
            navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='randomRoomIdGeneratorMode']/value").SetValue(getRandomRoomIdGeneratorMode(session));

            if (getConferenceMapperEndpoint(session).Length != 0)
            {
                session.Log($"Setting custom ConferenceMapperEndpoint: {getConferenceMapperEndpoint(session)}");
                navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='conferenceMapperEndpoint']/value").SetValue(getConferenceMapperEndpoint(session));
            }

            if (getPhoneNumberListEndpoint(session).Length != 0)
            {
                session.Log($"Setting custom phoneNumberListEndpoint: {getPhoneNumberListEndpoint(session)}");
                navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='phoneNumberListEndpoint']/value").SetValue(getPhoneNumberListEndpoint(session));
            }

            if (getConferenceSchedulerEndpoint(session).Length != 0)
            {
                session.Log($"Setting custom conferenceSchedulerEndpoint: {getConferenceSchedulerEndpoint(session)}");
                navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='conferenceSchedulerEndpoint']/value").SetValue(getConferenceSchedulerEndpoint(session));
            }

            if (getConferenceSchedulerEndpointSecret(session).Length != 0)
            {
                if (getConferenceSchedulerEndpointSecret(session).Length < 8)
                {
                    session.Log($"WARNING: The secret is to short. This will throw errors in the application.");
                }
                session.Log($"Setting custom conferenceSchedulerEndpointSecret: {getConferenceSchedulerEndpointSecret(session)}");
                navigator.SelectSingleNode(@"/configuration/userSettings/JitsiMeetOutlook.Properties.Settings/setting[@name='conferenceSchedulerEndpointSecret']/value").SetValue(getConferenceSchedulerEndpointSecret(session));
            }

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

        private static string getConferenceMapperEndpoint(Session session)
        {
            return session.CustomActionData["conferenceMapperEndpoint"];
        }

        private static string getPhoneNumberListEndpoint(Session session)
        {
            return session.CustomActionData["phoneNumberListEndpoint"];
        }

        private static string getConferenceSchedulerEndpoint(Session session)
        {
            return session.CustomActionData["conferenceSchedulerEndpoint"];
        }

        private static string getConferenceSchedulerEndpointSecret(Session session)
        {
            return session.CustomActionData["conferenceSchedulerEndpointSecret"];
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
            string[] availableLanguages = { "en", "cz", "de", "es", "fr", "ru" };
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

        private static string getRandomRoomIdGeneratorMode(Session session)
        {
            string[] availableModes = { "phrase", "string" };
            string userModeInput = session.CustomActionData["randomRoomIdGeneratorMode"];

            if (availableModes.Contains(userModeInput))
            {
                return userModeInput;
            }
            else
            {
                return "phrase";
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
