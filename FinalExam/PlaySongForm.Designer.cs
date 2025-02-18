namespace FinalExam
{
    partial class PlaySongForm
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
            MusicPic = new PictureBox();
            SongName = new Label();
            PreviewsSong = new Button();
            NextSong = new Button();
            PlaySong = new Button();
            ((System.ComponentModel.ISupportInitialize)MusicPic).BeginInit();
            SuspendLayout();
            // 
            // MusicPic
            // 
            MusicPic.BackColor = Color.LightCyan;
            MusicPic.Location = new Point(33, 45);
            MusicPic.Name = "MusicPic";
            MusicPic.Size = new Size(382, 354);
            MusicPic.TabIndex = 0;
            MusicPic.TabStop = false;
            // 
            // SongName
            // 
            SongName.AutoSize = true;
            SongName.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SongName.ForeColor = SystemColors.ButtonHighlight;
            SongName.Location = new Point(33, 459);
            SongName.Name = "SongName";
            SongName.Size = new Size(73, 36);
            SongName.TabIndex = 1;
            SongName.Text = "smth";
            // 
            // PreviewsSong
            // 
            PreviewsSong.BackColor = Color.LightSkyBlue;
            PreviewsSong.FlatAppearance.BorderSize = 0;
            PreviewsSong.FlatStyle = FlatStyle.Flat;
            PreviewsSong.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PreviewsSong.ForeColor = SystemColors.ButtonHighlight;
            PreviewsSong.Location = new Point(33, 553);
            PreviewsSong.Name = "PreviewsSong";
            PreviewsSong.Size = new Size(79, 71);
            PreviewsSong.TabIndex = 2;
            PreviewsSong.Text = "◁";
            PreviewsSong.UseVisualStyleBackColor = false;
            PreviewsSong.Click += PreviewsSong_Click;
            // 
            // NextSong
            // 
            NextSong.BackColor = Color.LightSkyBlue;
            NextSong.FlatAppearance.BorderSize = 0;
            NextSong.FlatStyle = FlatStyle.Flat;
            NextSong.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NextSong.ForeColor = SystemColors.ButtonHighlight;
            NextSong.Location = new Point(336, 553);
            NextSong.Name = "NextSong";
            NextSong.Size = new Size(79, 71);
            NextSong.TabIndex = 3;
            NextSong.Text = "▷";
            NextSong.UseVisualStyleBackColor = false;
            NextSong.Click += NextSong_Click;
            // 
            // PlaySong
            // 
            PlaySong.BackColor = Color.LightSkyBlue;
            PlaySong.FlatAppearance.BorderSize = 0;
            PlaySong.FlatStyle = FlatStyle.Flat;
            PlaySong.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PlaySong.ForeColor = SystemColors.ButtonHighlight;
            PlaySong.Location = new Point(187, 553);
            PlaySong.Name = "PlaySong";
            PlaySong.Size = new Size(79, 71);
            PlaySong.TabIndex = 4;
            PlaySong.Text = "▶";
            PlaySong.UseVisualStyleBackColor = false;
            PlaySong.Click += PlaySong_Click;
            // 
            // PlaySongForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(452, 678);
            Controls.Add(PlaySong);
            Controls.Add(NextSong);
            Controls.Add(PreviewsSong);
            Controls.Add(SongName);
            Controls.Add(MusicPic);
            Name = "PlaySongForm";
            Text = "PlaySongForm";
            ((System.ComponentModel.ISupportInitialize)MusicPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MusicPic;
        private Label SongName;
        private Button PreviewsSong;
        private Button NextSong;
        private Button PlaySong;
    }
}