using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Service;
using CourseWork.Model;

namespace CourseWork.Forms
{
    public partial class AddToPlaylistForm : Form
    {
        private MovieService _movieService;
        private PlaylistService _playlistService;

        public AddToPlaylistForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _movieService = context.MovieService;
            _playlistService = context.PlaylistService;
        }

        private void AddToPlaylistForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
            LoadPlaylists();
        }

        private void LoadMovies()
        {
            BindingList<Movie> movies = new BindingList<Movie>(_movieService.GetMovies());
            var sortedMovies = movies.OrderBy(g => g.Title).ToList();
            MoviesBox.DataSource = sortedMovies;
            MoviesBox.DisplayMember = "Title";
            MoviesBox.ValueMember = "Title";
        }

        private void LoadPlaylists()
        {
            var playlists = _playlistService.GetPlaylists();
            playlists = playlists.OrderBy(g => g.Title).ToList();
            PlaylistBox.DataSource = playlists;
            PlaylistBox.DisplayMember = "Title";
            PlaylistBox.ValueMember = "Title";
        }

        private void AddPlaylistButton_Click(object sender, EventArgs e)
        {
            AddPlaylistForm addPlaylistForm = new AddPlaylistForm();
            addPlaylistForm.Show();
            Hide();
            addPlaylistForm.FormClosed += (s, args) =>
            {
                this.Show();
                AddPlaylistForm_PlaylistAdded(s, args);
            };
        }

        private void AddPlaylistForm_PlaylistAdded(object? sender, EventArgs e)
        {
            var playlists = _playlistService.GetPlaylists();
            playlists = playlists.OrderBy(g => g.Title).ToList();
            PlaylistBox.DataSource = null;
            PlaylistBox.DataSource = playlists;
            PlaylistBox.DisplayMember = "Title";
            PlaylistBox.ValueMember = "Title";
        }

        private void AddMovieToPlaylistButton_Click(object sender, EventArgs e)
        {
            Movie selectedMovie = (Movie)MoviesBox.SelectedItem;

            Playlist selectedPlaylist = (Playlist)PlaylistBox.SelectedItem;

            if (selectedMovie != null && selectedPlaylist != null)
            {
                _playlistService.AddMovieToPlaylist(selectedPlaylist, selectedMovie);
            }
            else
            {
                MessageBox.Show("Please select a movie and a playlist.");
            }

            MessageBox.Show("Movie successfully added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
