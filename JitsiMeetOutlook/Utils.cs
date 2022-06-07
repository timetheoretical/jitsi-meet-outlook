using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JitsiMeetOutlook
{
    public class Utils
    {
        private static string escapeDomain(string domain)
        {
            string escapedDomain = Regex.Escape(domain);
            if (!escapedDomain.EndsWith("/"))
            {
                escapedDomain += "/";
            }
            return escapedDomain;
        }

        public static string GetUrl(string oldBody, string domain)
        {
            return Regex.Match(oldBody, "http[s]*://" + escapeDomain(domain) + "[\\w\\/#%\\.=]+").Value;
        }

        public static bool SettingIsActive(string url, string setting)
        {
            return url.Contains("config." + setting + "=true");
        }


        public static string findRoomId(string body, string domain)
        {
            string roomId = Regex.Match(body, "(?<=" + escapeDomain(domain) + ")\\S+?(?=(#config|&config|\\s))").Value; // Match all non-blanks after jitsi url and before config or end
            return roomId;
        }

        public static void RunInThread(Action function)
        {
            try
            {
                ThreadStart s = new ThreadStart(() =>
                {
                    try
                    {
                        function();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An Error occured within JitsiOutlook: " + ex.Message);
                    }
                });
                Thread ss = new Thread(s);
                ss.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured within JitsiOutlook: " + ex.Message);
            }
        }
    }
}
