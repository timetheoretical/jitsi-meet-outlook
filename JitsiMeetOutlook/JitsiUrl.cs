// This Class generates a random url
// Based on: https://github.com/edenemmanuel/jitsiurl/blob/master/jitsiurl
// and on: https://github.com/jitsi/js-utils/blob/master/random/roomNameGenerator.js

using System;
using System.Security.Cryptography;
using System.Text;

using System.Text.Json;
using Diacritics.Extensions;
using System.Text.RegularExpressions;

namespace JitsiMeetOutlook
{
    public static class JitsiUrl

    {
        public static string generateRandomId()
        {
            if (Properties.Settings.Default.randomRoomIdGeneratorMode == "phrase")
            {
                return generateRandomPhrase();
            }
            else
            {
                return generateRandomString(16);
            }
        }
        public static string generateRandomPhrase()
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

        public static string filterLegalCharacters(string word)
        {
            // Remove diacritics
            string wordWithoutDiacritics = word.RemoveDiacritics();

            // Keep only letters of the latin alphabet
            string wordLatin = Regex.Replace(wordWithoutDiacritics, "[^a-zA-Z0-9_-]+", "");

            return wordLatin;
        }

        public static string generateRandomString(int size)
        {
            char[] chars = (
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789"
                ).ToCharArray();

            byte[] data = new byte[4 * size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                var rnd = BitConverter.ToUInt32(data, i * 4);
                var idx = rnd % chars.Length;

                result.Append(chars[idx]);
            }

            return result.ToString();
        }
    }
}
