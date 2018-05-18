using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MusicManager.Utils
{
    static class StringUtils
    {
        public static string cleanText()
        {
            return "";
        }

        public static string removeChars(string fileName)
        {
            //Gathers all blacklisted characters
            string[] blacklist = new string[Utils.Settings.Settings.Default.CharBlacklist.Count];
            Utils.Settings.Settings.Default.CharBlacklist.CopyTo(blacklist, 0);

            //Char array of blacklisted characters
            char[] chars = blacklist.SelectMany(c => c.ToCharArray()).ToArray();

            foreach (string character in blacklist)
            {
                if (fileName.Contains(character))
                {
                    //Handle brackets
                    if (character.IndexOfAny(new char[] { '(', '{', '[' }) != -1)
                    {

                        string closing = "";

                        if (character == "(") closing = ")";
                        else if (character == "{") closing = "}";
                        else if (character == "[") closing = "]";

                        int start = fileName.IndexOf(character);
                        fileName = fileName.Remove(start, (fileName.IndexOf(closing) + 1) - start);
                    }

                    //Handle tilde
                    if (character == "~")
                    {
                        fileName = fileName.Replace("~", "-");
                    }

                    //Handle periods
                    if (character == ".")
                    {
                        fileName = fileName.Replace(".", "");
                    }

                    fileName = fileName.Replace(character, "");
                }
            }
            return fileName;
        }

        public static string removeWords(string fileName)
        {
            string[] blacklist = new string[Utils.Settings.Settings.Default.WordBlacklist.Count];
            Utils.Settings.Settings.Default.WordBlacklist.CopyTo(blacklist, 0);

            foreach (string word in blacklist)
            {
                if (fileName.ToLower().Contains(word))
                    fileName = fileName.ToLower().Replace(word, "");
            }

            return fileName;
        }

        /// <summary>
        /// Formats text to Pascal
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string formatText(string text)
        {
            //Capitalizes first character in every word, long I know.
            //https://stackoverflow.com/questions/1943273/convert-all-first-letter-to-upper-case-rest-lower-for-each-word
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }
    }
}
