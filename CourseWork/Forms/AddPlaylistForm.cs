using CourseWork.Model;
using CourseWork.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class AddPlaylistForm : Form
    {
        private PlaylistService _playlistService;
        private List<Playlist> _playlistList;
        private Playlist _playlistToEdit;
        public event EventHandler PlaylistAdded;
        public event EventHandler PlaylistEdited;

        public AddPlaylistForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _playlistService = context.PlaylistService;

            _playlistList = _playlistService.GetPlaylists();
        }

        public AddPlaylistForm(Playlist playlistToEdit) : this()
        {
            _playlistToEdit = playlistToEdit;
            LoadPlaylistData(playlistToEdit);
        }

        private void LoadPlaylistData(Playlist playlistToEdit)
        {
            NewPlaylistTitle.Text = playlistToEdit.Title;
            NewPlaylistDescription.Text = playlistToEdit.Description;
        }

        private void AddPlaylistForm_Load(object sender, EventArgs e)
        {
            // Any additional initialization if needed
        }

        private void AddPlaylistButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewPlaylistTitle.Text))
            {
                MessageBox.Show("Please enter the playlist title");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewPlaylistDescription.Text))
            {
                MessageBox.Show("Please enter the playlist description");
                return;
            }

            if (_playlistToEdit == null)
            {
                foreach (var cPlaylist in _playlistList)
                {
                    if (NewPlaylistTitle.Text == cPlaylist.Title)
                    {
                        MessageBox.Show("There already is a playlist with this title. Enter another title");
                        return;
                    }
                }

                _playlistService.AddPlaylist(NewPlaylistTitle.Text, NewPlaylistDescription.Text);
                PlaylistAdded?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if (_playlistToEdit.Title == NewPlaylistTitle.Text && _playlistToEdit.Description == NewPlaylistDescription.Text)
                {
                    MessageBox.Show("No changes detected.");
                    return;
                }
                _playlistToEdit.Title = NewPlaylistTitle.Text;
                _playlistToEdit.Description = NewPlaylistDescription.Text;
                PlaylistEdited?.Invoke(this, EventArgs.Empty);
            }

            this.Close();
        }
    }
}
