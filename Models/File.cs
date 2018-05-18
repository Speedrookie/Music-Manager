using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MusicManager.Managers;

//Author: Javan Poirier
//Date: 10/03/2017

//Class: File
//Description: Manages file names and paths.

namespace MusicManager.Models
{
    class File
    {
        public string FileName { get; private set; }
        public string FilePath { get; private set; }

        public File(string fileName, string filePath)
        {
            FileName = fileName;
            FilePath = filePath;
        }

        /// <summary>
        /// Cleans filename of blacklisted characters.
        /// </summary>
        public Song createSong()
        {
            Song song = new Song(FileName, FilePath);
            return song;
        }
    }
}
