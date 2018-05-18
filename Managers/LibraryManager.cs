using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicManager.Models;
using MusicManager.Utils;
using MusicManager.Utils.Settings;

namespace MusicManager.Managers
{
    class LibraryManager
    { 
        public static Song addSong(File file)
        {
            return file.createSong();
        }

        private static void saveSong(Song song)
        {
            string newPath;
            string libraryPath = Settings.Default.LibraryPath;
            string downloadsPath = Settings.Default.DownloadsPath;

            if (checkArtist(song.Artist.ToLower())) newPath = libraryPath + "\\" + song.Artist + "\\" + song.FileName;
            else newPath = libraryPath + "\\" + IOController.createFolder(libraryPath, song.Artist) + "\\" + song.FileName;

            try
            {
                IOController.moveFile(song.FilePath, newPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checks if string is equal to a library artist, returns boolean.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool checkArtist(string s)
        {
            //Get list of artists from folder names.
            List<string> libraryArtists = IOController.getFolderNames(Settings.Default.LibraryPath);

            //Check each artist.
            foreach (string artist in libraryArtists)
            {
                string name = artist.ToLower();
                if (s.Equals(name))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Creates folder from artist name returns path.
        /// </summary>
        /// <param name="artist"></param>
        /// <returns></returns>
        private static string newArtist(string artist)
        {
            return IOController.createFolder(Settings.Default.LibraryPath, artist);
        }
    }
}
