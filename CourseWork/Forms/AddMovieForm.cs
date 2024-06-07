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
    public partial class AddMovieForm : Form
    {
        private MovieService _movieService;
        private GenreService _genreService;
        private StudioService _studioService;
        private ArtistService _artistService;
        private Movie _movieToEdit;
        private List<FilmCreationRole> _filmCreationRoles;
        private List<Artist> _artists;
        public event EventHandler MovieAdded;
        public event EventHandler MovieEdited;


        public AddMovieForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _movieService = context.MovieService;
            _genreService = context.GenreService;
            _studioService = context.StudioService;
            _artistService = context.ArtistService;
            _filmCreationRoles = new List<FilmCreationRole>();

           
        }

        public AddMovieForm(Movie movieToEdit) : this()
        {
            _movieToEdit = movieToEdit;
            _filmCreationRoles = movieToEdit.Squad ?? new List<FilmCreationRole>();
            LoadMovieData(movieToEdit);
        }

        private void LoadMovieData(Movie movie)
        {
            NewMovieTitle.Text = movie.Title;
            NewMovieYear.Value = movie.Year;
            NewMovieDescription.Text = movie.Description;
            NewMovieGenre.SelectedItem = movie.Genre;
            NewMovieDuration.Value = movie.Duration;
            NewMovieScore.Value = movie.Score;
            NewMovieStudio.SelectedItem = movie.Studio;
            UpdateDataGridView();
        }
        private void ArtistLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewMovieTitle.Text))
            {
                MessageBox.Show("Please enter the movie title.");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewMovieGenre.Text))
            {
                MessageBox.Show("Please enter the movie genre.");
                return;
            }
            if (NewMovieDuration.Value <= 0)
            {
                MessageBox.Show("Please enter a valid duration for the movie.");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewMovieStudio.Text))
            {
                MessageBox.Show("Please enter the movie studio.");
                return;
            }

            if (_movieToEdit == null)
            {
                _movieService.AddMovie(NewMovieTitle.Text, NewMovieYear.Value,
                NewMovieDescription.Text, NewMovieGenre.Text, NewMovieDuration.Value,
                NewMovieScore.Value, NewMovieStudio.Text, _filmCreationRoles);


                MovieAdded.Invoke(this, EventArgs.Empty);
            }
            else
            {
                foreach (var genre in _genreService.GetGenres())
                {
                    if (genre.Name == NewMovieGenre.Text)
                    {
                        _movieToEdit.Genre = genre;
                    }
                }

                foreach (var studio in _studioService.GetStudios())
                {
                    if (studio.Name == NewMovieStudio.Text)
                    {
                        _movieToEdit.Studio = studio;
                    }
                }

                _movieToEdit.Title = NewMovieTitle.Text;
                _movieToEdit.Year = (int)NewMovieYear.Value;
                _movieToEdit.Description = NewMovieDescription.Text;
                //_movieToEdit.Genre.Name = NewMovieGenre.Text;
                _movieToEdit.Duration = (int)NewMovieDuration.Value;
                _movieToEdit.Score = (int)NewMovieScore.Value;
                //_movieToEdit.Studio.Name = NewMovieStudio.Text;
                _movieToEdit.Squad = _filmCreationRoles;
                //_movieService.UpdateMovie(_movieToEdit);

                MovieEdited?.Invoke(this, EventArgs.Empty);
            }

            Close();
        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            LoadGenres();
            LoadStudios();
            LoadArtists();
            RoleName.DataSource = Enum.GetValues(typeof(RoleName));

            ArtistsGrid.AutoGenerateColumns = false;
            ArtistsGrid.ReadOnly = true;
            ArtistsGrid.Columns.Clear();
            ArtistsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ArtistName",
                HeaderText = "Artist"
            });
            ArtistsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoleName",
                HeaderText = "Role"
            });


        }

        private void LoadGenres()
        {
            var genres = _genreService.GetGenres();
            genres = genres.OrderBy(g => g.Name).ToList();
            NewMovieGenre.DataSource = genres;
            NewMovieGenre.DisplayMember = "Name";
            NewMovieGenre.ValueMember = "Name";
        }

        private void LoadStudios()
        {
            var studios = _studioService.GetStudios();
            studios = studios.OrderBy(g => g.Name).ToList();
            NewMovieStudio.DataSource = studios;
            NewMovieStudio.DisplayMember = "Name";
            NewMovieStudio.ValueMember = "Name";
        }

        private void LoadArtists()
        {
            var artists = _artistService.GetArtists();
            artists = artists.OrderBy(g => g.Name).ToList();
            ArtistName.DataSource = artists;
            ArtistName.DisplayMember = "Name";
            ArtistName.ValueMember = "Name";
        }



        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreForm addGenreForm = new AddGenreForm();
            addGenreForm.GenreAdded += AddGenreForm_GenreAdded;
            addGenreForm.ShowDialog();
        }

        private void AddGenreForm_GenreAdded(object sender, EventArgs e)
        {
            ReloadGenres();
        }

        private void ReloadGenres()
        {
            var genres = _genreService.GetGenres();
            genres = genres.OrderBy(g => g.Name).ToList();
            NewMovieGenre.DataSource = null;
            NewMovieGenre.DataSource = genres;
            NewMovieGenre.DisplayMember = "Name";
            NewMovieGenre.ValueMember = "Name";
        }

        private void NewStudioButton_Click(object sender, EventArgs e)
        {
            AddStudioForm addStudioForm = new AddStudioForm();
            addStudioForm.StudioAdded += AddStudioForm_StudioAdded;
            addStudioForm.ShowDialog();
        }

        private void AddStudioForm_StudioAdded(object sender, EventArgs e)
        {
            ReloadStudios();
        }

        private void ReloadStudios()
        {
            var studios = _studioService.GetStudios();
            studios = studios.OrderBy(g => g.Name).ToList();
            NewMovieStudio.DataSource = null;
            NewMovieStudio.DataSource = studios;
            NewMovieStudio.DisplayMember = "Name";
            NewMovieStudio.ValueMember = "Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddArtistForm addArtistForm = new AddArtistForm();
            addArtistForm.ArtistAdded += AddArtistForm_ArtistAdded;
            addArtistForm.ShowDialog();
        }

        private void AddArtistForm_ArtistAdded(object? sender, EventArgs e)
        {
            ReloadArtists();
        }

        private void ReloadArtists()
        {
            var artists = _artistService.GetArtists();
            artists = artists.OrderBy(g => g.Name).ToList();
            ArtistName.DataSource = null;
            ArtistName.DataSource = artists;
            ArtistName.DisplayMember = "Name";
            ArtistName.ValueMember = "Name";
        }

        private void AddToDataGrid_Click(object sender, EventArgs e)
        {
            Artist selectedArtist = (Artist)ArtistName.SelectedItem;
            RoleName selectedRole = (RoleName)RoleName.SelectedItem;

            var filmRole = new FilmCreationRole
            {
                Artist = selectedArtist,
                Movie = _movieToEdit,
                RoleName = selectedRole
            };

            _filmCreationRoles.Add(filmRole);
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            ArtistsGrid.AutoGenerateColumns = false;

            ArtistsGrid.DataSource = null;
            ArtistsGrid.DataSource = _filmCreationRoles;
        }

        private void DeleteArtistButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this artist", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (ArtistsGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = ArtistsGrid.SelectedRows[0];
                    FilmCreationRole selectedMovie = (FilmCreationRole)selectedRow.DataBoundItem;
                    _filmCreationRoles.Remove(selectedMovie);
                    UpdateDataGridView();
                }
            }
            
        }
    }
}
    