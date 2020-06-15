// This Class generates a random url
// Based on: https://github.com/edenemmanuel/jitsiurl/blob/master/jitsiurl
// and on: https://github.com/jitsi/js-utils/blob/master/random/roomNameGenerator.js

using System;
using System.Text.Json;
using Diacritics.Extensions;
using System.Text.RegularExpressions;

namespace JitsiMeetOutlook
{
    public static class JitsiUrl

    {

        public static string generateUrl()
        {
            return getUrlBase() + randomListElement(getAdjectiveList()) + randomListElement(getPluralNounList()) + randomListElement(getVerbList()) + randomListElement(getAdverbList());
        }

        public static string generateRoomId()
        {
            return randomListElement(getAdjectiveList()) + randomListElement(getPluralNounList()) + randomListElement(getVerbList()) + randomListElement(getAdverbList());
        }

        public static string getUrlBase()
        {
            string urlBase = "https://" + getDomain() + "/";
            return urlBase;
        }

        public static string getDomain()
        {
            Properties.Settings.Default.Reload();
            string domain = Properties.Settings.Default.Domain;
            return domain;
        }

        private static string randomListElement(JsonElement list)
        {
            int index = random.Next(list.GetArrayLength());
            string word = list[index].GetString();

            return filterLegalCharacters(word);
        }

        private static Random random = new Random();

        // The list of plural nouns.
        private static JsonElement getPluralNounList()
        {
            return Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("roomNameGenerator").GetProperty("pluralNoun");
        }

        // The list of verbs.
        private static JsonElement getVerbList()
        {
            return Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("roomNameGenerator").GetProperty("verb");
        }

        // The list of adverbs.
        private static JsonElement getAdverbList()
        {
            return Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("roomNameGenerator").GetProperty("adverb");
        }

        // The list of adjectives.
        private static JsonElement getAdjectiveList()
        {
            return Globals.ThisAddIn.getLanguageJsonRoot().GetProperty("roomNameGenerator").GetProperty("adjective");
        }

        private static string filterLegalCharacters(string word)
        {
            // Remove diacritics
            string wordWithoutDiacritics = word.RemoveDiacritics();

            // Keep only letters of the latin alphabet
            string wordLatin = Regex.Replace(wordWithoutDiacritics, "[^a-zA-Z]+", "");

            return wordLatin;
        }
    }
}
