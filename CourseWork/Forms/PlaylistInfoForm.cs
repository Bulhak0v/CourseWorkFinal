using CourseWork.Model;
using CourseWork.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class PlaylistInfoForm : Form
    {
        private MovieService _movieService;
        private PlaylistService _playlistService;
        private BindingSource bs;
        private Playlist _currentPlaylist;
        private bool sortAscending = true;
        public event EventHandler PlaylistClosed;

        public PlaylistInfoForm(Playlist playlist)
        {
            InitializeComponent();
            _currentPlaylist = playlist;
            PlaylistTitle.Text = playlist.Title;
            PlaylistDescription.Text = playlist.Description;
            ApplicationContext context = ApplicationContext.GetInstance();
            _movieService = context.MovieService;
            _playlistService = context.PlaylistService;
            LoadMovies();
        }

        private void LoadMovies()
        {
            if (_currentPlaylist.Movies != null)
            {
                List<Movie> movies = _currentPlaylist.Movies.OrderBy(m => m.Title).ToList();

                PlaylistGrid.ReadOnly = true;
                PlaylistGrid.AllowUserToOrderColumns = true;

                bs = new BindingSource();
                bs.DataSource = new BindingList<Movie>(movies);
                PlaylistGrid.DataSource = bs;
            }
            else
            {
                PlaylistGrid.DataSource = null;
            }
        }

        private void PlaylistInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void AddPlaylistForm_PlaylistEdited(object sender, EventArgs e)
        {
            _currentPlaylist = _playlistService.GetPlaylistById(_currentPlaylist.Id);
            PlaylistTitle.Text = _currentPlaylist.Title;
            PlaylistDescription.Text = _currentPlaylist.Description;

            LoadMovies();
        }

        private void DeletePlaylistButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this playlist?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _playlistService.DeletePlaylist(_currentPlaylist);
                MessageBox.Show("Playlist deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void EditPlaylistButton_Click(object sender, EventArgs e)
        {
            AddPlaylistForm addPlaylistForm = new AddPlaylistForm(_currentPlaylist);
            addPlaylistForm.PlaylistEdited += AddPlaylistForm_PlaylistEdited;
            addPlaylistForm.ShowDialog();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            PlaylistClosed?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            if (PlaylistGrid.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this movie?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = PlaylistGrid.SelectedRows[0];
                    Movie selectedMovie = (Movie)selectedRow.DataBoundItem;
                    _playlistService.DeleteFromPlaylist(selectedMovie, _currentPlaylist);
                    bs.Remove(selectedMovie);
                    MessageBox.Show("Movie deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to delete.", "No Movie Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
