using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MusicManager.Models;
using MusicManager.Managers;
using MusicManager.Utils;
using MusicManager.Utils.Settings;

namespace MusicManager
{
    public partial class frmMusicManager : Form
    {
        private List<File> files = new List<File>();
        private List<Song> songs = new List<Song>();

        public frmMusicManager()
        {
            InitializeComponent();           
        }

        public void frmMusicManager_Load(object sender, EventArgs e)
        {
            frmSettings.checkSettingsPaths();
            initLists();
        }

        #region Buttons
        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            //Create duplicate list for objects to count, for not to disturb the almighty foreach loop.
            List<Song> songsList = new List<Song>(songs);
            foreach (Song song in songsList.Where(s => s.saved == true))
            {
                if (song.Artist != "" && song.Title != "" && song.NewFileName != "")
                {
                    try
                    {
                        song.setMetaData();
                        if (song.artistFound == false)
                        {
                            IOController.createFolder(Settings.Default.LibraryPath, song.Artist);                         
                        }
                        IOController.moveFile(song.FilePath, song.NewFilePath);

                        songs.Remove(song);
                        initLists();
                        //refreshLists();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("A file is missing information. Continue with other files?", "Error", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        continue;
                    else
                        break;
                }
            }

            dgvMusic.ClearSelection();
            clearInfo();
        }

        /// <summary>
        /// Adds a single file download to songs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = lstDownloads.SelectedIndex;
            if (i > -1)
            {
                //Song song = LibraryManager.addSong(files[i]);
                songs.Add(files[i].createSong());
                files.Remove(files[i]);

                //create delegate
                initLists();
                //refreshLists();
            }
            else MessageBox.Show("You must select a song to add frist.", "Error");
        }

        /// <summary>
        /// Adds all file downloads to songs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (File file in files)
            {
                songs.Add(LibraryManager.addSong(file));
            }
            files.Clear();

            initLists();
            //refreshLists();
        }

        /// <summary>
        /// Removes single song from songs and adds back to files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = dgvMusic.CurrentCell.RowIndex;
            if (i > -1)
            {
                files.Add(songs[i]);
                songs.Remove(songs[i]);

                initLists();
                //refreshLists();

                //Clear selection and info
                dgvMusic.ClearSelection();
                clearInfo();
            }
            else MessageBox.Show("You must select a song to add frist.", "Error");
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (Song song in songs)
            {
                files.Add(song);
            }
            songs.Clear();

            initLists();
            //refreshLists();

            //Clear selection and info
            dgvMusic.ClearSelection();
            clearInfo();
        }

        /// <summary>
        /// Calls refresh of downloads list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            initLists();
            //refreshLists();

            //Clear list views
            lstDownloads.ClearSelected();
            dgvMusic.ClearSelection();

            clearInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = dgvMusic.CurrentCell.RowIndex;
            saveSong(i);
            initLists();
            //refreshLists();

            //Clear selection and select previous.
            dgvMusic.ClearSelection();
            dgvMusic.Rows[i].Selected = true;
        }

        private void saveSong(int i)
        {
            //Save song
            saveInfo(songs[i]);           

            //Disables save button to notify user of saved entry
            btnSave.Enabled = false;
            dgvMusic.Select();
        }
        #endregion

        #region ListViews
        private void lstDownloads_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstDownloads.SelectedIndex;
            if (i > -1)
            {
                clearInfo();
                dgvMusic.ClearSelection();
                lstDownloads.SelectedIndex = i;
                txtOldFileName.Text = files[i].FileName;
            }
        }

        private void dgvMusic_SelectionChanged(object sender, EventArgs e)
        {         
            int i = dgvMusic.CurrentCell.RowIndex;
            if (i > -1)
            {
                //Clear list box selections.
                lstDownloads.ClearSelected();

                if (songs.ElementAtOrDefault(i) != null)
                    updateInfo(songs[i]);

                btnSave.Enabled = true;
            }
        }

        private void refreshLists()
        {
            lstDownloads.Items.Clear();
            dgvMusic.Rows.Clear();

            //Sort both lists by file name.
            files.OrderBy(n => n.FileName);
            songs.OrderBy(n => n.FileName);

            foreach (File file in files)
            {
                lstDownloads.Items.Add(file.FileName);
            }

            foreach (Song song in songs)
            {   
                dgvMusic.Rows.Add(song.saved, song.NewFileName);
            }
        }

        /// <summary>
        /// Refreshes both downloads and songs list.
        /// </summary>
        private void initLists()
        {
            //Clear both downloads and songs lists
            lstDownloads.Items.Clear();
            dgvMusic.Rows.Clear();

            //Get all files in downloads
            files = DownloadsManager.getDownloads();

            //Sort both lists by file name.
            files.OrderBy(n => n.FileName);
            songs.OrderBy(n => n.FileName);

            List<File> removeFiles = new List<File>();
            foreach (File file in files)
            {
                //If file matches a song in list remove from files and add to listbox.
                foreach (Song song in songs)
                {
                    if (file.FilePath.Equals(song.FilePath))
                    {
                        removeFiles.Add(file);
                        dgvMusic.Rows.Add(song.saved, song.NewFileName);
                    }
                }
                lstDownloads.Items.Add(file.FileName);
            }

            foreach (File file in removeFiles)
                files.Remove(file);

            refreshLists();
        }
        #endregion

        #region Info
        private void clearInfo()
        {
            artistTextBox.Text = "";
            titleTextBox.Text = "";
            fileNameTextBox.Text = "";
            txtOldFileName.Text = "";
            chkArtist.Checked = false;
            btnSave.Enabled = false;
        }

        private void updateInfo(Song song)
        {
            artistTextBox.Text = song.Artist;
            titleTextBox.Text = song.Title;
            fileNameTextBox.Text = song.NewFileName;
            txtOldFileName.Text = song.FileName;
            chkArtist.Checked = song.artistFound ? true : false;
        }

        private void saveInfo(Song song)
        {
            song.Artist = artistTextBox.Text;
            song.Title = titleTextBox.Text;
            song.NewFileName = fileNameTextBox.Text;
            song.NewFilePath = Settings.Default.LibraryPath + "\\" + song.Artist + "\\" + song.NewFileName;
            song.saved = true;
        }

        /// <summary>
        /// Updates text in file info.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="i"></param>
        private void updateText(string text, int i)
        {
            string artist = "";
            string title = "";

            if (i == 0)
            {
                artist = text;
                title = titleTextBox.Text;
            }
            else
            {
                artist = artistTextBox.Text;
                title = text;
            }

            fileNameTextBox.Text = artist + " - " + title;
        }
        #endregion

        #region Textboxes
        /// <summary>
        /// Updates filename text from edited Artist field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void artistTextBox_TextChanged(object sender, EventArgs e)
        {
            updateText(artistTextBox.Text, 0);
        }

        /// <summary>
        /// Updates filename text from edited Title field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleTextBox_TextChanged(object sender, EventArgs e)
       {
            updateText(titleTextBox.Text, 1);
        }
        #endregion

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }
    }
}
