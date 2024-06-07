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
    public partial class ArtistInfoForm : Form
    {
        private MovieService _movieService;
        private ArtistService _artistService;
        private BindingSource bs;
        private Artist _currentArtist;
        public event EventHandler ArtistClosed;


        public ArtistInfoForm(Artist artist)
        {
            InitializeComponent();
            _currentArtist = artist;
            ArtistTitle.Text = artist.Name;
            ArtistBiography.Text = artist.Biography;
            ApplicationContext context = ApplicationContext.GetInstance();
            _movieService = context.MovieService;
            _artistService = context.ArtistService;
            LoadMovies();
        }

        private void ArtistInfoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadMovies()
        {
            BindingList<Movie> movies = _movieService.GetMovies();
            List<Movie> artistMovies = new List<Movie>();
            foreach (Movie movie in movies)
            {
                var mSquad = movie.Squad;
                foreach (var actor in mSquad)
                {
                    if (actor.ArtistName == _currentArtist.Name)
                    {
                        artistMovies.Add(movie);
                    }
                }
            }

            artistMovies = artistMovies.OrderBy(g => g.Title).ToList();
            bs = new BindingSource();
            bs.DataSource = artistMovies;
            ArtistGrid.DataSource = bs;
            ArtistGrid.ReadOnly = true;
        }

        private void AddArtistForm_ArtistEdited(object sender, EventArgs e)
        {
            _currentArtist = _artistService.GetArtistById(_currentArtist.Id);
            ArtistTitle.Text = _currentArtist.Name;
            ArtistBiography.Text = _currentArtist.Biography;

            UpdateMoviesWithNewArtist();

            LoadMovies();
        }

        private void UpdateMoviesWithNewArtist()
        {
            var movies = _movieService.GetMovies();
            foreach (var movie in movies)
            {
                foreach (var role in movie.Squad)
                {
                    if (role.Artist.Id == _currentArtist.Id)
                    {
                        role.Artist = _currentArtist;
                    }
                }
            }
        }

        private void EditArtistButton_Click(object sender, EventArgs e)
        {
            AddArtistForm addArtistForm = new AddArtistForm(_currentArtist);
            addArtistForm.ArtistEdited += AddArtistForm_ArtistEdited;
            addArtistForm.ShowDialog();
        }

        private void DeleteArtistButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this artist?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _artistService.DeleteArtist(_currentArtist);
                MessageBox.Show("Artist deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            ArtistClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
