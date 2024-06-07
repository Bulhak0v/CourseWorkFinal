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
    public partial class GenreInfoForm : Form
    {
        private MovieService _movieService;
        private GenreService _genreService;
        private BindingSource bs;
        private Genre _currentGenre;
        private bool sortAscending = true;
        public event EventHandler GenreClosed;

        public GenreInfoForm(Genre genre)
        {
            InitializeComponent();
            _currentGenre = genre;
            GenreTitle.Text = genre.Name;
            GenreDescription.Text = genre.Description;
            ApplicationContext context = ApplicationContext.GetInstance();
            _movieService = context.MovieService;
            _genreService = context.GenreService;
            LoadMovies();
        }

        private void LoadMovies()
        {
            List<Movie> movies = _movieService.GetMovies().Where(m => m.Genre.Name == _currentGenre.Name).ToList();
            movies = movies.OrderBy(g => g.Title).ToList();

            GenreGrid.ReadOnly = true;
            GenreGrid.AllowUserToOrderColumns = true;

            bs = new BindingSource();
            bs.DataSource = new BindingList<Movie>(movies);
            GenreGrid.DataSource = bs;
        }


        private void GenreInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void EditGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreForm addGenreForm = new AddGenreForm(_currentGenre);
            addGenreForm.GenreEdited += AddGenreForm_GenreEdited;
            addGenreForm.ShowDialog();
        }

        private void AddGenreForm_GenreEdited(object sender, EventArgs e)
        {
            _currentGenre = _genreService.GetGenreById(_currentGenre.Id);
            GenreTitle.Text = _currentGenre.Name;
            GenreDescription.Text = _currentGenre.Description;

            UpdateMoviesWithNewGenre();

            LoadMovies();
        }

        private void UpdateMoviesWithNewGenre()
        {
            List<Movie> movies = _movieService.GetMovies().Where(m => m.Genre.Id == _currentGenre.Id).ToList();
            foreach (var movie in movies)
            {
                movie.Genre = _currentGenre;
            }
        }

        private void DeleteGenreButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this genre?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _genreService.DeleteGenre(_currentGenre);
                MessageBox.Show("Genre deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            GenreClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
