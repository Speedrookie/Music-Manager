using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace MusicManager.Utils
{
    static class IOController
    {

        /// <summary>
        /// Returns list of directory paths from path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<string> getPaths(string path)
        {
            return new List<string>(Directory.GetDirectories(path));
        }

        /// <summary>
        /// Returns list of directories from path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<string> getFiles(string path)
        {
            return new List<string>(Directory.EnumerateFiles(path));
        }

        /// <summary>
        /// Get folder name from file path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string getFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        /// <summary>
        /// Get folder name from file path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string getFolderName(string path)
        {
            return Path.GetDirectoryName(path);
        }

        public static List<string> getFolderNames(string path)
        {
            List<string> folders = getPaths(path);
            List<string> names = new List<string>();
            foreach(string folder in folders)
            {
                names.Add(new DirectoryInfo(folder).Name);
            }
            return names;
        }

        /// <summary>
        /// Gets file extension.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string getExtension(string path)
        {
            return Path.GetExtension(path);
        }

        /// <summary>
        /// Creates folder at path and returns directory path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string createFolder(string path, string name)
        {
            try
            {
                return Directory.CreateDirectory(path + "\\" + name).ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Moves file from old to new path.
        /// </summary>
        /// <param name="oldPath"></param>
        /// <param name="newPath"></param>
        public static void moveFile(string oldPath, string newPath)
        {
            try
            {
                newPath = Path.ChangeExtension(newPath, ".mp3");
                File.Move(oldPath, newPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// <summary>
        /// Returns bool result of valid path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool checkPath(string path)
        {
            return Directory.Exists(path);
        }
    }
}
