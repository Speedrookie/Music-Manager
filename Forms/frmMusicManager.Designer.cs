namespace MusicManager
{
    partial class frmMusicManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label artistLabel;
            System.Windows.Forms.Label fileNameLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusicManager));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDownloads = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.chkArtist = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOldName = new System.Windows.Forms.Label();
            this.txtOldFileName = new System.Windows.Forms.TextBox();
            this.dgvMusic = new System.Windows.Forms.DataGridView();
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            artistLabel = new System.Windows.Forms.Label();
            fileNameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Location = new System.Drawing.Point(14, 269);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new System.Drawing.Size(33, 13);
            artistLabel.TabIndex = 25;
            artistLabel.Text = "Artist:";
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new System.Drawing.Point(12, 297);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new System.Drawing.Size(82, 13);
            fileNameLabel.TabIndex = 27;
            fileNameLabel.Text = "New File Name:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(240, 269);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 31;
            titleLabel.Text = "Title:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(530, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Downloads:";
            // 
            // lstDownloads
            // 
            this.lstDownloads.FormattingEnabled = true;
            this.lstDownloads.HorizontalScrollbar = true;
            this.lstDownloads.Location = new System.Drawing.Point(12, 53);
            this.lstDownloads.Name = "lstDownloads";
            this.lstDownloads.Size = new System.Drawing.Size(209, 134);
            this.lstDownloads.TabIndex = 6;
            this.lstDownloads.SelectedIndexChanged += new System.EventHandler(this.lstDownloads_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(65, 193);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(247, 79);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(41, 23);
            this.btnAddAll.TabIndex = 10;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(247, 134);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(41, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(247, 161);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(41, 23);
            this.btnRemoveAll.TabIndex = 12;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.Location = new System.Drawing.Point(384, 193);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(75, 23);
            this.btnAddMusic.TabIndex = 13;
            this.btnAddMusic.Text = "Add Music";
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Music:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(247, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(443, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // artistTextBox
            // 
            this.artistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songBindingSource, "Artist", true));
            this.artistTextBox.Location = new System.Drawing.Point(70, 266);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(158, 20);
            this.artistTextBox.TabIndex = 26;
            this.artistTextBox.TextChanged += new System.EventHandler(this.artistTextBox_TextChanged);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songBindingSource, "FileName", true));
            this.fileNameTextBox.Enabled = false;
            this.fileNameTextBox.Location = new System.Drawing.Point(96, 294);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(334, 20);
            this.fileNameTextBox.TabIndex = 28;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(272, 266);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(158, 20);
            this.titleTextBox.TabIndex = 32;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // chkArtist
            // 
            this.chkArtist.AutoSize = true;
            this.chkArtist.Enabled = false;
            this.chkArtist.Location = new System.Drawing.Point(49, 269);
            this.chkArtist.Name = "chkArtist";
            this.chkArtist.Size = new System.Drawing.Size(15, 14);
            this.chkArtist.TabIndex = 33;
            this.chkArtist.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(15, 254);
            this.label3.MaximumSize = new System.Drawing.Size(500, 2);
            this.label3.MinimumSize = new System.Drawing.Size(450, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 2);
            this.label3.TabIndex = 34;
            this.label3.Text = "test";
            // 
            // lblOldName
            // 
            this.lblOldName.AutoSize = true;
            this.lblOldName.Location = new System.Drawing.Point(12, 228);
            this.lblOldName.Name = "lblOldName";
            this.lblOldName.Size = new System.Drawing.Size(57, 13);
            this.lblOldName.TabIndex = 35;
            this.lblOldName.Text = "File Name:";
            // 
            // txtOldFileName
            // 
            this.txtOldFileName.Enabled = false;
            this.txtOldFileName.Location = new System.Drawing.Point(75, 225);
            this.txtOldFileName.Name = "txtOldFileName";
            this.txtOldFileName.Size = new System.Drawing.Size(443, 20);
            this.txtOldFileName.TabIndex = 36;
            // 
            // dgvMusic
            // 
            this.dgvMusic.AllowUserToAddRows = false;
            this.dgvMusic.AllowUserToDeleteRows = false;
            this.dgvMusic.AllowUserToResizeColumns = false;
            this.dgvMusic.AllowUserToResizeRows = false;
            this.dgvMusic.BackgroundColor = System.Drawing.Color.White;
            this.dgvMusic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusic.ColumnHeadersVisible = false;
            this.dgvMusic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colName});
            this.dgvMusic.Location = new System.Drawing.Point(312, 53);
            this.dgvMusic.MultiSelect = false;
            this.dgvMusic.Name = "dgvMusic";
            this.dgvMusic.ReadOnly = true;
            this.dgvMusic.RowHeadersVisible = false;
            this.dgvMusic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMusic.RowTemplate.Height = 17;
            this.dgvMusic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusic.Size = new System.Drawing.Size(206, 134);
            this.dgvMusic.TabIndex = 8;
            this.dgvMusic.SelectionChanged += new System.EventHandler(this.dgvMusic_SelectionChanged);
            // 
            // songBindingSource
            // 
            this.songBindingSource.DataSource = typeof(MusicManager.Models.Song);
            // 
            // fileBindingSource
            // 
            this.fileBindingSource.DataSource = typeof(MusicManager.Models.File);
            // 
            // colCheck
            // 
            this.colCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCheck.FillWeight = 25F;
            this.colCheck.Frozen = true;
            this.colCheck.HeaderText = "Checked";
            this.colCheck.MinimumWidth = 25;
            this.colCheck.Name = "colCheck";
            this.colCheck.ReadOnly = true;
            this.colCheck.Width = 25;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colName.Frozen = true;
            this.colName.HeaderText = "File Name";
            this.colName.MinimumWidth = 200;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // frmMusicManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 326);
            this.Controls.Add(this.dgvMusic);
            this.Controls.Add(this.txtOldFileName);
            this.Controls.Add(this.lblOldName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkArtist);
            this.Controls.Add(artistLabel);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(fileNameLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMusic);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstDownloads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMusicManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicManager";
            this.Load += new System.EventHandler(this.frmMusicManager_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDownloads;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource fileBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource songBindingSource;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.CheckBox chkArtist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOldName;
        private System.Windows.Forms.TextBox txtOldFileName;
        private System.Windows.Forms.DataGridView dgvMusic;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}

