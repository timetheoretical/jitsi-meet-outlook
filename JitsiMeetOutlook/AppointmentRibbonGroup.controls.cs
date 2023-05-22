﻿using System.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Word = Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;
using JitsiMeetOutlook.Entities;
using Microsoft.Office.Interop.Word;
using System.Collections.Generic;

namespace JitsiMeetOutlook
{
    public partial class AppointmentRibbonGroup
    {
        private Outlook.AppointmentItem appointmentItem;
        private string oldDomain;

        private void initialise()
        {
            // Set language
            setLanguage();

            // Assign the domain prevailing at appointment item launch
            Properties.Settings.Default.Reload();
            oldDomain = Properties.Settings.Default.Domain;

            // Assign the relevant appointment item
            Outlook.Inspector inspector = (Outlook.Inspector)this.Context;
            appointmentItem = inspector.CurrentItem as Outlook.AppointmentItem;

            if (appointmentItem.Location == Properties.Settings.Default.appName)
            {
                groupJitsiMeetControls.Visible = true;
                groupNewMeeting.Visible = false;
                Utils.RunInThread(() =>
                {
                    InitializeRibbonWithCurrentData();
                });
            }
            else
            {
                groupNewMeeting.Visible = true;
                groupJitsiMeetControls.Visible = false;
            }


        }


        private async void InitializeRibbonWithCurrentData()
        {
            var roomId = Utils.findRoomId(appointmentItem.Body, oldDomain);
            if (roomId != string.Empty)
            {
                // The Meeting already exists
                if (roomId != null)
                {
                    fieldRoomID.Text = roomId;
                }

                var url = Utils.GetUrl(appointmentItem.Body, oldDomain);
                if (Utils.SettingIsActive(url, "requireDisplayName"))
                {
                    buttonRequireDisplayName.Checked = true;
                }
                if (Utils.SettingIsActive(url, "startWithAudioMuted"))
                {
                    buttonStartWithAudioMuted.Checked = true;
                }
                if (Utils.SettingIsActive(url, "startWithVideoMuted"))
                {
                    buttonStartWithVideoMuted.Checked = true;
                }

            }
            else
            {
                // New Meeting
                await appendNewMeetingText();
                if (Properties.Settings.Default.requireDisplayName)
                {
                    toggleRequireName();
                    buttonRequireDisplayName.Checked = true;
                }
                if (Properties.Settings.Default.startWithAudioMuted)
                {
                    toggleMuteOnStart();
                    buttonStartWithAudioMuted.Checked = true;
                }
                if (Properties.Settings.Default.startWithVideoMuted)
                {
                    toggleVideoOnStart();
                    buttonStartWithVideoMuted.Checked = true;
                }
            }

        }

        public async System.Threading.Tasks.Task appendNewMeetingText()
        {
            string roomId;
            if (Properties.Settings.Default.roomID.Length == 0)
            {
                roomId = JitsiUrl.generateRandomId();
            }
            else
            {
                roomId = Properties.Settings.Default.roomID;
            }
            fieldRoomID.Text = roomId;


            Word.Document wordDocument = appointmentItem.GetInspector.WordEditor as Word.Document;
            wordDocument.Select();
            var endSel = wordDocument.Application.Selection;
            endSel.Collapse(Word.WdCollapseDirection.wdCollapseEnd);

            var phoneNumbers = await Globals.ThisAddIn.JitsiApiService.getPhoneNumbers(roomId);
            var pinNumber = await Globals.ThisAddIn.JitsiApiService.getPIN(roomId);
            object missing = System.Reflection.Missing.Value;

            var link = JitsiUrl.getUrlBase() + roomId;




            endSel.InsertAfter("\n");
            endSel.MoveDown(Word.WdUnits.wdLine);
            endSel.InsertAfter("\n");
            endSel.MoveDown(Word.WdUnits.wdLine);
            endSel.InsertAfter("\n");
            endSel.MoveDown(Word.WdUnits.wdLine);
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.textBodyMessage))
            {
                endSel.InsertAfter(Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyMessage"));
            }
            else
            {
                endSel.InsertAfter(Properties.Settings.Default.textBodyMessage.Replace(@"\n", "\r\n"));
            }
            endSel.EndKey(Word.WdUnits.wdLine);
            wordDocument.Hyperlinks.Add(endSel.Range, link, ref missing, ref missing, link, ref missing);
            endSel.EndKey(Word.WdUnits.wdLine);
            endSel.InsertAfter("\n");
            endSel.MoveDown(Word.WdUnits.wdLine);

            if (phoneNumbers.NumbersEnabled)
            {
                // Add Phone Number Text if they are enabled
                endSel.InsertAfter(Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyMessagePhone"));
                endSel.EndKey(Word.WdUnits.wdLine);
                endSel.InsertAfter("\n");
                endSel.MoveDown(Word.WdUnits.wdLine);
                foreach (var entry in phoneNumbers.Numbers)
                {
                    endSel.InsertAfter(entry.Key + ": ");
                    endSel.EndKey(Word.WdUnits.wdLine);
                    for (int i = 0; i < entry.Value.Count; i++)
                    {
                        wordDocument.Hyperlinks.Add(endSel.Range, "tel:" + entry.Value[i], ref missing, ref missing, entry.Value[i], ref missing);
                        endSel.EndKey(Word.WdUnits.wdLine);
                        if (i < entry.Value.Count - 1)
                        {
                            endSel.InsertAfter(",");
                        }
                    }
                    endSel.InsertAfter("\n");
                    endSel.MoveDown(Word.WdUnits.wdLine);
                }
                endSel.InsertAfter(Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyPin") + pinNumber);
                endSel.EndKey(Word.WdUnits.wdLine);
            }
            endSel.InsertAfter("\n");
            endSel.MoveDown(Word.WdUnits.wdLine);
            endSel.InsertAfter("\n");
            endSel.MoveDown(Word.WdUnits.wdLine);

            IEnumerable<KeyValuePair<bool, string>> disclaimer;
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.textBodyDisclaimer))
            {
                disclaimer = Utils.SplitToTextAndHyperlinks(Globals.ThisAddIn.getElementTranslation("appointmentItem", "textBodyDisclaimer"));
            }
            else
            {
                disclaimer = Utils.SplitToTextAndHyperlinks(Properties.Settings.Default.textBodyDisclaimer.Replace(@"\n", "\r\n"));
            }
            foreach (var textblock in disclaimer)
            {
                if (textblock.Key)
                {
                    // Textblock is a link
                    wordDocument.Hyperlinks.Add(endSel.Range, textblock.Value, ref missing, ref missing, textblock.Value, ref missing);
                    endSel.EndKey(Word.WdUnits.wdLine);
                }
                else
                {
                    // Textblock is no link
                    endSel.InsertAfter(textblock.Value);
                    endSel.EndKey(Word.WdUnits.wdLine);
                }
            }
            endSel.EndKey(Word.WdUnits.wdLine);
            endSel.InsertAfter("\n");
            endSel.MoveDown(Word.WdUnits.wdLine);

            wordDocument.Select();
            endSel.Collapse(Word.WdCollapseDirection.wdCollapseStart);
        }

        public async void setRoomId(string newRoomId)
        {
            // Filter room id for illegal characters
            string newRoomIdLegal = JitsiUrl.filterLegalCharacters(newRoomId);
            fieldRoomID.Text = newRoomIdLegal;


            string newDomain = JitsiUrl.getDomain();
            Word.Document wordDocument = appointmentItem.GetInspector.WordEditor as Word.Document;
            string oldBody = wordDocument.Range().Text;


            // Update Domain if it was updated in the meantime
            object missing = System.Reflection.Missing.Value;
            Find findObject = wordDocument.Content.Find;
            findObject.ClearFormatting();
            findObject.Text = oldDomain;
            findObject.Replacement.ClearFormatting();
            findObject.Format = true;
            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, newDomain,
               WdReplace.wdReplaceAll, ref missing, ref missing, ref missing, ref missing);
            oldDomain = newDomain;

            var oldRoomId = Utils.findRoomId(oldBody, newDomain);

            Word.Hyperlinks wLinks = wordDocument.Hyperlinks;
            for (int i = 1; i <= wLinks.Count; i++)
            {
                if (wLinks[i].Address.Contains(oldDomain))
                {
                    var urlNew = wLinks[i].TextToDisplay.Replace(Utils.findRoomId(appointmentItem.Body, oldDomain), newRoomIdLegal);
                    wLinks[i].Address = fixUrl(urlNew);
                    wLinks[i].TextToDisplay = fixUrl(urlNew);
                }
            }



            // Update PIN 
            var newPIN = await Globals.ThisAddIn.JitsiApiService.getPIN(newRoomIdLegal);
            var oldPIN = await Globals.ThisAddIn.JitsiApiService.getPIN(oldRoomId);

            Find findPINObject = wordDocument.Content.Find;
            findPINObject.ClearFormatting();
            findPINObject.Text = oldPIN;
            findPINObject.Replacement.ClearFormatting();
            findPINObject.Format = true;

            findPINObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, newPIN,
                WdReplace.wdReplaceAll, ref missing, ref missing, ref missing, ref missing);

        }

        public void randomiseRoomId()
        {
            setRoomId(JitsiUrl.generateRandomId());
        }

        public void toggleMuteOnStart()
        {
            toggleSetting("startWithAudioMuted");
        }
        public void toggleVideoOnStart()
        {
            toggleSetting("startWithVideoMuted");
        }

        public void toggleRequireName()
        {
            toggleSetting("requireDisplayName");
        }


        private void addJitsiMeeting()
        {
            appointmentItem.Location = Properties.Settings.Default.appName;
            initialise();
        }

        private void toggleSetting(string setting)
        {
            // Find Jitsi URL in message
            Word.Document wordDocument = appointmentItem.GetInspector.WordEditor as Word.Document;

            Word.Hyperlinks wLinks = wordDocument.Hyperlinks;
            for (int i = 1; i <= wLinks.Count; i++)
            {
                if (wLinks[i].Address.Contains(oldDomain))
                {
                    var urlMatch = wLinks[i].TextToDisplay;
                    string urlNew;
                    if (Utils.SettingIsActive(urlMatch, setting))
                    {
                        urlNew = Regex.Replace(urlMatch, "(#|&)config\\." + setting + "=true", "");
                    }
                    else
                    {
                        // Otherwise add
                        if (urlMatch.Contains("#config"))
                        {
                            urlNew = urlMatch + "&config." + setting + "=true";
                        }
                        else
                        {
                            urlNew = urlMatch + "#config." + setting + "=true";
                        }
                    }
                    wLinks[i].Address = fixUrl(urlNew);
                    wLinks[i].TextToDisplay = fixUrl(urlNew);
                }
            }
        }

        private string fixUrl(string url)
        {
            string fixedUrl = url;

            // Make sure settings appear correctly
            int countHashConfig = url.Count(f => f == '#');
            int countAndConfig = url.Count(f => f == '&');

            if (countHashConfig == 0 && countAndConfig == 1)
            {
                fixedUrl = url.Replace("&config", "#config");
            }

            return fixedUrl;
        }
    }
}
