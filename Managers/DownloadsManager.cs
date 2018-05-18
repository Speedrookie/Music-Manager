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
    static class DownloadsManager
    {  
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<File> getDownloads()
        {
            List<File> files = new List<File>();

            foreach (string path in IOController.getFiles(Settings.Default.DownloadsPath))
            {
                //Add list of file extensions.
                if (IOController.getExtension(path).Equals(".mp3"))
                    files.Add(new File(IOController.getFileName(path), path));
            }

            return files;
        }
    }
}
