using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FinalExam
{
    public partial class PlaySongForm : Form
    {
        private List<Song> songs;
        private int currentSongIndex;
        private bool isPlaying;
        private WindowsMediaPlayer player;

        public PlaySongForm(string songUrl)
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            LoadSongsData();

            if (songs == null || songs.Count == 0)
            {
                MessageBox.Show("No songs loaded.");
                return;
            }

            currentSongIndex = songs.FindIndex(s => s.Url == songUrl);

            if (currentSongIndex == -1)
            {
                MessageBox.Show("Song not found.");
                return;
            }

            isPlaying = false;
            UpdateSongUI();
        }


        private void LoadSongsData()
        {
            string jsonFilePath = Path.Combine(Application.StartupPath, "Resources", "songs.json");
            string jsonContent = File.ReadAllText(jsonFilePath);
            var songsData = JsonSerializer.Deserialize<SongsData>(jsonContent);
            songs = songsData.Songs;
        }

        private void UpdateSongUI()
        {
            if (currentSongIndex >= 0 && currentSongIndex < songs.Count)
            {
                var currentSong = songs[currentSongIndex];
                SongName.Text = currentSong.Name;
                MusicPic.ImageLocation = currentSong.Image;
            }
        }

        private void PlayPauseSong()
        {
            if (isPlaying)
            {
                player.controls.pause();
                PlaySong.Text = "▶";
            }
            else
            {
                player.URL = songs[currentSongIndex].Url;
                player.controls.play();
                PlaySong.Text = "⏸";
            }
            isPlaying = !isPlaying;
        }

        private void PreviewsSong_Click(object sender, EventArgs e)
        {
            if (currentSongIndex > 0)
            {
                currentSongIndex--;  
            }
            else
            {
                currentSongIndex = songs.Count - 1;  
            }

            var currentSong = songs[currentSongIndex];
            player.URL = currentSong.Url;
            player.controls.play(); 
            PlaySong.Text = "⏸"; 

            UpdateSongUI();  
        }



        private void PlaySong_Click(object sender, EventArgs e)
        {
            PlayPauseSong();

        }

        private void NextSong_Click(object sender, EventArgs e)
        {
            currentSongIndex = (currentSongIndex + 1) % songs.Count; 
            UpdateSongUI();

            if (isPlaying)
            {
                PlayPauseSong();  
                PlayPauseSong();  
            }
        }
    }
}
