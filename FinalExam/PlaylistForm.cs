using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using static FinalExam.PlaySongForm;

namespace FinalExam
{
    public partial class PlaylistForm : Form
    {
        private Dictionary<string, List<Song>> playlists = new Dictionary<string, List<Song>>();

        public PlaylistForm()
        {
            InitializeComponent();
            LoadPlaylistsFromJson();
            InitializeUI();

        }

        private void LoadPlaylistsFromJson()
        {
            string jsonFilePath = Path.Combine(Application.StartupPath, "Resources", "songs.json");

            if (!File.Exists(jsonFilePath))
            {
                MessageBox.Show("Songs JSON file not found!");
                return;
            }

            try
            {
                string jsonContent = File.ReadAllText(jsonFilePath);
                var songsData = JsonSerializer.Deserialize<SongsData>(jsonContent);

                if (songsData.Songs.Count == 0)
                {
                    MessageBox.Show("No songs found.");
                }
                else
                {
                    foreach (var song in songsData.Songs)
                    {
                        foreach (var playlistName in song.Playlists)
                        {
                            if (!playlists.ContainsKey(playlistName))
                            {
                                playlists[playlistName] = new List<Song>();
                            }
                            playlists[playlistName].Add(song);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading songs: {ex.Message}");
            }
        }


        private void InitializeUI()
        {
            foreach (var playlist in playlists.Keys)
            {
                comboBoxPlaylists.Items.Add(playlist);
            }

            if (comboBoxPlaylists.Items.Count > 0)
            {
                comboBoxPlaylists.SelectedIndex = 0;
            }

            comboBoxPlaylists.SelectedIndexChanged += ComboBoxPlaylists_SelectedIndexChanged;
            listBoxSongs.DoubleClick += DataGridViewSongs_DoubleClick;

            if (comboBoxPlaylists.SelectedItem != null)
            {
                LoadSongs(comboBoxPlaylists.SelectedItem.ToString());
            }
        }

        private void ComboBoxPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPlaylist = comboBoxPlaylists.SelectedItem.ToString();
            LoadSongs(selectedPlaylist);
        }

        private void LoadSongs(string playlistName)
        {
            listBoxSongs.Rows.Clear();

            if (playlists.ContainsKey(playlistName))
            {
                foreach (var song in playlists[playlistName])
                {
                    listBoxSongs.Rows.Add(song.Name);
                }
            }
        }

        private void DataGridViewSongs_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxSongs.CurrentRow != null)
            {
                string selectedSongName = listBoxSongs.CurrentRow.Cells[0].Value.ToString();
                PlaySong(selectedSongName);
            }
        }

        private void PlaySong(string songName)
        {
            var selectedSong = playlists.SelectMany(p => p.Value).FirstOrDefault(s => s.Name == songName);

            if (selectedSong != null)
            {
                var playForm = new PlaySongForm(selectedSong.Url);
                playForm.Show();
            }
            else
            {
                MessageBox.Show("Song not found!");
            }
        }

        private void buttonAddPlaylist_Click(object sender, EventArgs e)
        {
            string playlistName = Prompt.ShowDialog("Enter playlist name:", "Add Playlist");

            if (!string.IsNullOrEmpty(playlistName) && !playlists.ContainsKey(playlistName))
            {
                playlists[playlistName] = new List<Song>();
                comboBoxPlaylists.Items.Add(playlistName);
            }
        }

        private List<Song> LoadSongsData()
        {
            string jsonFilePath = Path.Combine(Application.StartupPath, "Resources", "songs.json");
            string jsonContent = File.ReadAllText(jsonFilePath);

            var songsData = JsonSerializer.Deserialize<SongsData>(jsonContent);

            return songsData.Songs; 
        }


        private void AddMusicButton_Click(object sender, EventArgs e)
        {
            string selectedPlaylist = comboBoxPlaylists.SelectedItem.ToString();

            List<Song> songs = LoadSongsData();

            MusicSelection musicForm = new MusicSelection(songs);
            if (musicForm.ShowDialog() == DialogResult.OK)
            {
                List<Song> selectedSongs = musicForm.SelectedSongs;

                if (playlists.ContainsKey(selectedPlaylist))
                {
                    playlists[selectedPlaylist].AddRange(selectedSongs);
                }
                else
                {
                    playlists[selectedPlaylist] = selectedSongs;
                }

                LoadSongs(selectedPlaylist);
            }
        }
    }
}
