namespace FinalExam
{
    partial class PlaylistForm
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
            comboBoxPlaylists = new ComboBox();
            buttonAddPlaylist = new Button();
            listBoxSongs = new DataGridView();
            SongName = new DataGridViewTextBoxColumn();
            label1 = new Label();
            AddMusicButton = new Button();
            ((System.ComponentModel.ISupportInitialize)listBoxSongs).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPlaylists
            // 
            comboBoxPlaylists.FormattingEnabled = true;
            comboBoxPlaylists.Location = new Point(47, 142);
            comboBoxPlaylists.Name = "comboBoxPlaylists";
            comboBoxPlaylists.Size = new Size(421, 33);
            comboBoxPlaylists.TabIndex = 0;
            // 
            // buttonAddPlaylist
            // 
            buttonAddPlaylist.BackColor = Color.LightSkyBlue;
            buttonAddPlaylist.FlatAppearance.BorderSize = 0;
            buttonAddPlaylist.FlatStyle = FlatStyle.Flat;
            buttonAddPlaylist.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddPlaylist.ForeColor = SystemColors.ButtonHighlight;
            buttonAddPlaylist.Location = new Point(47, 201);
            buttonAddPlaylist.Name = "buttonAddPlaylist";
            buttonAddPlaylist.Size = new Size(192, 71);
            buttonAddPlaylist.TabIndex = 1;
            buttonAddPlaylist.Text = "Add A Playlist";
            buttonAddPlaylist.UseVisualStyleBackColor = false;
            buttonAddPlaylist.Click += buttonAddPlaylist_Click;
            // 
            // listBoxSongs
            // 
            listBoxSongs.BackgroundColor = Color.LightSkyBlue;
            listBoxSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBoxSongs.Columns.AddRange(new DataGridViewColumn[] { SongName });
            listBoxSongs.Location = new Point(47, 305);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.RowHeadersWidth = 120;
            listBoxSongs.RowTemplate.Height = 33;
            listBoxSongs.Size = new Size(421, 372);
            listBoxSongs.TabIndex = 2;
            // 
            // SongName
            // 
            SongName.HeaderText = "Song Name";
            SongName.MinimumWidth = 8;
            SongName.Name = "SongName";
            SongName.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(121, 71);
            label1.Name = "label1";
            label1.Size = new Size(275, 36);
            label1.TabIndex = 3;
            label1.Text = "Choose your Playlist";
            // 
            // AddMusicButton
            // 
            AddMusicButton.BackColor = Color.LightSkyBlue;
            AddMusicButton.FlatAppearance.BorderSize = 0;
            AddMusicButton.FlatStyle = FlatStyle.Flat;
            AddMusicButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AddMusicButton.ForeColor = SystemColors.ButtonHighlight;
            AddMusicButton.Location = new Point(276, 201);
            AddMusicButton.Name = "AddMusicButton";
            AddMusicButton.Size = new Size(192, 71);
            AddMusicButton.TabIndex = 4;
            AddMusicButton.Text = "Add Music";
            AddMusicButton.UseVisualStyleBackColor = false;
            AddMusicButton.Click += AddMusicButton_Click;
            // 
            // PlaylistForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(521, 745);
            Controls.Add(AddMusicButton);
            Controls.Add(label1);
            Controls.Add(listBoxSongs);
            Controls.Add(buttonAddPlaylist);
            Controls.Add(comboBoxPlaylists);
            Name = "PlaylistForm";
            Text = "playlist";
            ((System.ComponentModel.ISupportInitialize)listBoxSongs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPlaylists;
        private Button buttonAddPlaylist;
        private DataGridView listBoxSongs;
        private DataGridViewTextBoxColumn SongName;
        private Label label1;
        private Button AddMusicButton;
    }
}