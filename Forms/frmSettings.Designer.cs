namespace MusicManager
{
    partial class frmSettings
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
            this.btnLibraryPath = new System.Windows.Forms.Button();
            this.txtLibraryPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownloadsPath = new System.Windows.Forms.Button();
            this.txtDownloadsPath = new System.Windows.Forms.TextBox();
            this.fbdSettings = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.lstChars = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLibraryPath
            // 
            this.btnLibraryPath.Location = new System.Drawing.Point(304, 30);
            this.btnLibraryPath.Name = "btnLibraryPath";
            this.btnLibraryPath.Size = new System.Drawing.Size(75, 23);
            this.btnLibraryPath.TabIndex = 3;
            this.btnLibraryPath.Text = "Browse...";
            this.btnLibraryPath.UseVisualStyleBackColor = true;
            this.btnLibraryPath.Click += new System.EventHandler(this.btnMusicPath_Click);
            // 
            // txtLibraryPath
            // 
            this.txtLibraryPath.Enabled = false;
            this.txtLibraryPath.Location = new System.Drawing.Point(18, 33);
            this.txtLibraryPath.Name = "txtLibraryPath";
            this.txtLibraryPath.Size = new System.Drawing.Size(269, 20);
            this.txtLibraryPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Music Library:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Downloads Library:";
            // 
            // btnDownloadsPath
            // 
            this.btnDownloadsPath.Location = new System.Drawing.Point(304, 90);
            this.btnDownloadsPath.Name = "btnDownloadsPath";
            this.btnDownloadsPath.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadsPath.TabIndex = 7;
            this.btnDownloadsPath.Text = "Browse...";
            this.btnDownloadsPath.UseVisualStyleBackColor = true;
            this.btnDownloadsPath.Click += new System.EventHandler(this.btnDownloadPath_Click);
            // 
            // txtDownloadsPath
            // 
            this.txtDownloadsPath.Enabled = false;
            this.txtDownloadsPath.Location = new System.Drawing.Point(18, 90);
            this.txtDownloadsPath.Name = "txtDownloadsPath";
            this.txtDownloadsPath.Size = new System.Drawing.Size(269, 20);
            this.txtDownloadsPath.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(396, 154);
            this.tabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLibraryPath);
            this.tabPage1.Controls.Add(this.btnLibraryPath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnDownloadsPath);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtDownloadsPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Directories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.btnWord);
            this.tabPage2.Controls.Add(this.btnChar);
            this.tabPage2.Controls.Add(this.txtText);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lstWords);
            this.tabPage2.Controls.Add(this.lstChars);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(388, 128);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Blacklists";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(166, 91);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(212, 61);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(34, 23);
            this.btnWord.TabIndex = 7;
            this.btnWord.Text = ">";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(146, 62);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(34, 23);
            this.btnChar.TabIndex = 6;
            this.btnChar.Text = "<";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(146, 35);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 20);
            this.txtText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "List of blacklisted characters and words to be excluded from file names.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Words:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Characters:";
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.Location = new System.Drawing.Point(258, 47);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(116, 69);
            this.lstWords.TabIndex = 1;
            this.lstWords.SelectedIndexChanged += new System.EventHandler(this.lstWords_SelectedIndexChanged);
            // 
            // lstChars
            // 
            this.lstChars.FormattingEnabled = true;
            this.lstChars.Location = new System.Drawing.Point(15, 47);
            this.lstChars.Name = "lstChars";
            this.lstChars.Size = new System.Drawing.Size(120, 69);
            this.lstChars.TabIndex = 0;
            this.lstChars.SelectedIndexChanged += new System.EventHandler(this.lstChars_SelectedIndexChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 205);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLibraryPath;
        private System.Windows.Forms.TextBox txtLibraryPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownloadsPath;
        private System.Windows.Forms.TextBox txtDownloadsPath;
        private System.Windows.Forms.FolderBrowserDialog fbdSettings;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.ListBox lstChars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnRemove;
    }
}