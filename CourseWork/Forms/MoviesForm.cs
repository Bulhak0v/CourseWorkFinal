using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.Service;

namespace CourseWork.Forms
{
    public partial class MoviesForm : Form
    {

        private MovieService _movieService;
        private GenreService _genreService;
        private StudioService _studioService;
        private ArtistService _artistService;
        private AddMovieForm _addMovieForm;
        private BindingSource bs;
        private bool sortAscending = true;

        public MoviesForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _movieService = context.MovieService;
            _genreService = context.GenreService;
            _studioService = context.StudioService;
            _artistService = context.ArtistService;

            MoviesGrid.ReadOnly = true;
            MoviesGrid.AllowUserToOrderColumns = true;
            MoviesGrid.ColumnHeaderMouseClick += MoviesGrid_ColumnHeaderMouseClick;

            bs = new BindingSource();
            bs.DataSource = _movieService.GetMovies();
            MoviesGrid.DataSource = bs;

            var genres = _genreService.GetGenres();
            genres = genres.OrderBy(g => g.Name).ToList();
            GenreBox.DataSource = genres;

            var studios = _studioService.GetStudios();
            studios = studios.OrderBy(g => g.Name).ToList();
            StudioBox.DataSource = studios;

            var artists = _artistService.GetArtists();
            artists = artists.OrderBy(g => g.Name).ToList();
            ActorBox.DataSource = artists;
            ActorBox.DisplayMember = "Name";
            ActorBox.ValueMember = "Name";

            var directors = _artistService.GetArtists();
            directors = directors.OrderBy(g => g.Name).ToList();
            DirectorBox.DataSource = directors;
            DirectorBox.DisplayMember = "Name";
            DirectorBox.ValueMember = "Name";
        }

        private void MoviesGrid_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = MoviesGrid.Columns[e.ColumnIndex].DataPropertyName;
            BindingList<Movie> movies = (BindingList<Movie>)bs.DataSource;

            if (columnName == "Title" || columnName == "Description" || columnName == "Year" || columnName == "Score" || columnName == "Duration")
            {
                movies = new BindingList<Movie>(sortAscending
                    ? movies.OrderBy(m => typeof(Movie).GetProperty(columnName).GetValue(m, null)).ToList()
                    : movies.OrderByDescending(m => typeof(Movie).GetProperty(columnName).GetValue(m, null)).ToList());

                bs.DataSource = movies;
                sortAscending = !sortAscending;
                bs.ResetBindings(false);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            DurationToValue.Value = 500;
            YearsToValue.Value = 2024;
            GenreBox.Text = "";
            StudioBox.Text = "";
            ActorBox.Text = "";
            DirectorBox.Text = "";
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            _addMovieForm = new AddMovieForm();
            _addMovieForm.MovieAdded += AddMovieForm_MovieAdded;
            _addMovieForm.ShowDialog();
        }


        private void AddMovieForm_MovieAdded(object sender, EventArgs e)
        {
            //List<Movie> newMovies = _movieService.GetMovies();
            //List<Movie> dataSourceList = (List<Movie>)MoviesGrid.DataSource;
            //dataSourceList.Clear();
            //newMovies.ForEach(dataSourceList.Add);

            bs.ResetBindings(false);
            // ОноDлення dataGridView
            //MoviesGrid.Refresh();

        }

        private void EditMovieForm_MovieEdited(object sender, EventArgs e)
        {
            bs.ResetBindings(false);
        }

        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this movie?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (MoviesGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = MoviesGrid.SelectedRows[0];
                    Movie selectedMovie = (Movie)selectedRow.DataBoundItem;
                    _movieService.DeleteMovie(selectedMovie);
                    bs.Remove(selectedMovie);
                }
                MessageBox.Show("Movie deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditMovie_Click(object sender, EventArgs e)
        {
            if (MoviesGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = MoviesGrid.SelectedRows[0];
                Movie selectedMovie = (Movie)selectedRow.DataBoundItem;
                AddMovieForm editMovieForm = new AddMovieForm(selectedMovie);
                editMovieForm.MovieEdited += EditMovieForm_MovieEdited;
                editMovieForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a movie to edit.");
            }
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenresForm genresForm = new GenresForm();
            genresForm.Show();
            Hide();
            genresForm.FormClosed += (s, args) => this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudiosForm studiosForm = new StudiosForm();
            studiosForm.Show();
            Hide();
            studiosForm.FormClosed += (s, args) => this.Show();
        }

        private void artistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtistsForm artistsForm = new ArtistsForm();
            artistsForm.Show();
            Hide();
            artistsForm.FormClosed += (s, args) => this.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (DurationFromValue.Value > DurationToValue.Value)
            {
                MessageBox.Show("Please enter the correct duration values");
                return;
            }

            if (YearsFromValue.Value > YearsToValue.Value)
            {
                MessageBox.Show("Please enter the correct year values");
                return;
            }

            if (ScoreFromValue.Value > ScoreToValue.Value)
            {
                MessageBox.Show("Please enter the correct score values");
                return;
            }

            BindingList<Movie> filteredMovies = new BindingList<Movie>(
    _movieService.GetMovies()
        .Where(movie => movie.Duration >= DurationFromValue.Value && movie.Duration <= DurationToValue.Value)
        .Where(movie => movie.Year >= YearsFromValue.Value && movie.Year <= YearsToValue.Value)
        .Where(movie => string.IsNullOrEmpty(GenreBox.Text) || movie.Genre.Name == GenreBox.Text)
        .Where(movie => string.IsNullOrEmpty(StudioBox.Text) || movie.Studio.Name == StudioBox.Text)
        .Where(movie => movie.Score >= ScoreFromValue.Value && movie.Score <= ScoreToValue.Value)
        .Where(movie => string.IsNullOrEmpty(ActorBox.Text) || movie.Squad.Any(artist => artist.ArtistName == ActorBox.Text))
.Where(movie => string.IsNullOrEmpty(DirectorBox.Text) || movie.Squad.Any(director => director.ArtistName == DirectorBox.Text && director.RoleName == RoleName.Director)).ToList()
);

            bs.DataSource = null;
            bs.DataSource = filteredMovies;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            bs.DataSource = _movieService.GetMovies();
            DurationToValue.Value = 500;
            DurationFromValue.Value = 0;
            YearsToValue.Value = 2024;
            YearsFromValue.Value = 1895;
            ScoreFromValue.Value = 1;
            ScoreToValue.Value = 10;
            GenreBox.Text = "";
            StudioBox.Text = "";
            ActorBox.Text = "";
            DirectorBox.Text = "";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Movie searchedMovie = new Movie();
            foreach (var movie in _movieService.GetMovies())
            {
                if (movie.Title == SearchMovieTitle.Text)
                {
                    searchedMovie = movie;
                }
            }

            if (searchedMovie.Title != SearchMovieTitle.Text)
            {
                MessageBox.Show($"{SearchMovieTitle.Text} not found", "Not found", MessageBoxButtons.OK);
                SearchHistory.Items.Add(SearchMovieTitle.Text);
            }
            else
            {
                MessageBox.Show($"Title: {searchedMovie.Title}\n" +
                    $"Year: {searchedMovie.Year}\nDuration:{searchedMovie.Duration}\n" +
                    $"Genre: {searchedMovie.Genre.Name}\nStudio: {searchedMovie.Studio.Name}\n" +
                    $"Description: {searchedMovie.Description}\nScore: {searchedMovie.Score}", "Movie", MessageBoxButtons.OK);

                SearchHistory.Items.Add(SearchMovieTitle.Text);
            }
        }

        private void SaveMovies_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                DefaultExt = "txt",
                AddExtension = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in MoviesGrid.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < MoviesGrid.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value?.ToString() ?? string.Empty);
                                if (i < MoviesGrid.Columns.Count - 1)
                                {
                                    writer.Write("\t");
                                }
                            }
                            writer.WriteLine();
                        }
                    }
                }
                MessageBox.Show("Films saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PickUpButton_Click(object sender, EventArgs e)
        {
            List<Movie> allMovies = new List<Movie>();
            foreach (DataGridViewRow row in MoviesGrid.Rows)
            {
                if (row.DataBoundItem != null)
                {
                    allMovies.Add((Movie)row.DataBoundItem);
                }
            }

            int targetDuration = (int)PickUpDuration.Value;

            Random random = new Random();
            List<Movie> selectedMovies = new List<Movie>();
            int currentDuration = 0;

            while (currentDuration < targetDuration && allMovies.Count > 0)
            {
                int index = random.Next(allMovies.Count);
                Movie selectedMovie = allMovies[index];

                if (currentDuration + selectedMovie.Duration <= targetDuration)
                {
                    selectedMovies.Add(selectedMovie);
                    currentDuration += selectedMovie.Duration;
                    allMovies.RemoveAt(index);
                }
                else
                {
                    allMovies.RemoveAt(index);
                }
            }

            bs.DataSource = selectedMovies;
            MoviesGrid.DataSource = bs;
            bs.ResetBindings(false);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
            Hide();
            aboutProgram.FormClosed += (s, args) => this.Show();
        }

        private void AddToPlaylistButton_Click(object sender, EventArgs e)
        {
            AddToPlaylistForm addToPlaylistForm = new AddToPlaylistForm();
            addToPlaylistForm.Show();
            Hide();
            addToPlaylistForm.FormClosed += (s, args) => this.Show();
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaylistsForm playlistForm = new PlaylistsForm();
            playlistForm.Show();
            Hide();
            playlistForm.FormClosed += (s, args) => this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
            Hide();
            statisticsForm.FormClosed += (s, args) => this.Show();
        }
    }
}
