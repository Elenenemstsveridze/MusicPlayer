using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalExam.PlaySongForm;

namespace FinalExam
{
    public partial class MusicSelection : Form
    {
        private List<Song> allSongs;


        public MusicSelection(List<Song> songs)
        {
            InitializeComponent();
            allSongs = songs;
        }

        private void MusicSelection_Load(object sender, EventArgs e)
        {
            foreach (var song in allSongs)
            {
                checkedListBoxSongs.Items.Add(song.Name);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            List<Song> selectedSongs = new List<Song>();
            foreach (var checkedItem in checkedListBoxSongs.CheckedItems)
            {
                string songName = checkedItem.ToString();
                Song selectedSong = allSongs.FirstOrDefault(s => s.Name == songName);
                if (selectedSong != null)
                {
                    selectedSongs.Add(selectedSong);
                }
            }

            SelectedSongs = selectedSongs;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public List<Song> SelectedSongs { get; private set; }
    }
}