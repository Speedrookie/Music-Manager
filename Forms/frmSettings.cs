using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MusicManager.Utils;
using MusicManager.Utils.Settings;

namespace MusicManager
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            loadPaths();
            loadBlacklists();
        }

        private void btnMusicPath_Click(object sender, EventArgs e)
        {
            fbdSettings.ShowDialog();
            txtLibraryPath.Text = fbdSettings.SelectedPath.ToString();
        }

        private void btnDownloadPath_Click(object sender, EventArgs e)
        {
            fbdSettings.ShowDialog();
            txtDownloadsPath.Text = fbdSettings.SelectedPath.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveDirectories();
            saveBlacklists();
        }

        /// <summary>
        /// Loads paths into settings textboxes.
        /// </summary>
        private void loadPaths()
        {
            txtLibraryPath.Text = Settings.Default.LibraryPath;
            txtDownloadsPath.Text = Settings.Default.DownloadsPath;
        }

        /// <summary>
        /// Clears and loads blacklist values.
        /// </summary>
        private void loadBlacklists()
        {
            lstChars.Items.Clear();
            lstWords.Items.Clear();

            string[] chars = new string[Settings.Default.CharBlacklist.Count];
            Settings.Default.CharBlacklist.CopyTo(chars, 0);

            string[] words = new string[Settings.Default.WordBlacklist.Count];
            Settings.Default.WordBlacklist.CopyTo(words, 0);

            lstChars.Items.AddRange(chars);
            lstWords.Items.AddRange(words);
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            Settings.Default.CharBlacklist.Add(txtText.Text.Trim());
            txtText.Text = "";
            loadBlacklists();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            Settings.Default.WordBlacklist.Add(txtText.Text.Trim());
            txtText.Text = "";
            loadBlacklists();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstChars.SelectedIndex > -1)
            {
                Settings.Default.CharBlacklist.RemoveAt(lstChars.SelectedIndex);
            }
            else if (lstWords.SelectedIndex > -1)
            {
                Settings.Default.WordBlacklist.RemoveAt(lstWords.SelectedIndex);
            }
            loadBlacklists();
        }

        private void saveDirectories()
        {
            string libraryPath = txtLibraryPath.Text;
            string downloadsPath = txtDownloadsPath.Text;

            if (IOController.checkPath(libraryPath) && IOController.checkPath(downloadsPath))
            {
                //Set directory paths in settings file if directories are valid.
                Settings.Default.LibraryPath = libraryPath;
                Settings.Default.DownloadsPath = downloadsPath;
                Settings.Default.Save();

                //Make a delagate
                //musicManager.getDownloads();
                //musicManager.refreshDownloads();

                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("One or more directories are invalid.", "Error", MessageBoxButtons.OK);
            }
        }

        private void saveBlacklists()
        {
            Settings.Default.CharBlacklist.Clear();
            Settings.Default.WordBlacklist.Clear();

            string[] chars = new string[lstChars.Items.Count];
            lstChars.Items.CopyTo(chars, 0);

            string[] words = new string[lstWords.Items.Count];
            lstWords.Items.CopyTo(words, 0);

            Settings.Default.CharBlacklist.AddRange(chars);
            Settings.Default.WordBlacklist.AddRange(words);
        }

        private void lstChars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Index must be stored and re-assigned or listbox will give you grief.
            int i = lstChars.SelectedIndex;
            lstWords.SelectedIndex = -1;
            lstChars.SelectedIndex = i;
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Index must be stored and re-assigned or listbox will give you grief.
            int i = lstWords.SelectedIndex;
            lstChars.SelectedIndex = -1;
            lstWords.SelectedIndex = i;
        }

        /// <summary>
        /// Checks settings paths for downloads and library are valid.
        /// </summary>
        public static void checkSettingsPaths()
        {
            string libraryPath = Settings.Default.LibraryPath;
            string downloadsPath = Settings.Default.DownloadsPath;

            if (!IOController.checkPath(libraryPath) || !IOController.checkPath(downloadsPath))
            {
                frmSettings frmSettings = new frmSettings();
                frmSettings.ShowDialog();
            }
        }
    }
}
