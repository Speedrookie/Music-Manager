using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicManager.Utils;
using MusicManager.Managers;

using TagLib;
using TagLib.Id3v2;
using Id3;

namespace MusicManager.Models
{
    class Song : File
    {
        public string NewFileName { get; set; }
        public string NewFilePath { get; set; }

        public string Artist { get; set; }
        public string Title { get; set; }

        public bool artistFound = false;
        public bool saved = false;

        private TagLib.File file;

        public Song(string fileName, string filePath) : base(fileName, filePath)
        {
            NewFileName = StringUtils.formatText(StringUtils.removeWords(StringUtils.removeChars(FileName)));
            setSongInfo();
        }

        /// <summary>
        /// Finds and sets song artist, sets determines song title then returns if artist was identified.
        /// </summary>
        /// <returns></returns>
        private void setSongInfo()
        {
            string s1, s2;

            if (NewFileName.Contains('-'))
            {
                //Dividing character between artist and song title.
                int div = NewFileName.IndexOf("-");

                //Split filename into artist and song name, lower and trim string.
                s1 = NewFileName.Substring(0, div).ToLower().Trim();
                s2 = NewFileName.Substring(div + 1, NewFileName.Length - (div + 1)).ToLower().Trim();

                //If substring 1 contains a matching artist set filename with artist first.
                if (LibraryManager.checkArtist(s1))
                {
                    Artist = StringUtils.formatText(s1);
                    Title = StringUtils.formatText(s2);
                    NewFileName = Artist + " - " + Title;

                    artistFound = true;
                }
                //If substring 2 contains a matching artist set filename with artist first.
                else if (LibraryManager.checkArtist(s2))
                {
                    Artist = StringUtils.formatText(s2);
                    Title = StringUtils.formatText(s1);
                    NewFileName = Artist + " - " + Title;

                    artistFound = true;
                }
                else
                {
                    Artist = StringUtils.formatText(s1);
                    Title = StringUtils.formatText(s2);
                    NewFileName = Artist + " - " + Title;
                }
            }
        }

        /// <summary>
        /// Sets meta data of artist and song title on file.
        /// </summary>
        public void setMetaData()
        {
            file = TagLib.File.Create(FilePath);
            if (!Artist.Equals("") && !Title.Equals(""))
            {
                try
                {
                    file.Tag.Performers = new[] { Artist };
                    file.Tag.Title = Title;
                    file.Save();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Clears all file meta data.
        /// </summary>
        public void clearMetaData()
        {
            file.RemoveTags(TagTypes.Id3v2);
        }
    }
}
