using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.Service;

namespace CourseWork.Forms
{
    public partial class StudioInfoForm : Form
    {
        private MovieService _movieService;
        private StudioService _studioService;
        private BindingSource bs;
        private Studio _currentStudio;
        public event EventHandler StudioClosed;
        public StudioInfoForm(Studio studio)
        {
            InitializeComponent();
            _currentStudio = studio;
            StudioTitle.Text = studio.Name;
            StudioDescription.Text = studio.Description;
            StudioAddress.Text = studio.Address;
            StudioId.Text = studio.Id;
            ApplicationContext context = ApplicationContext.GetInstance();
            _movieService = context.MovieService;
            _studioService = context.StudioService;
            LoadMovies();
        }

        private void LoadMovies()
        {
            BindingList<Movie> movies = _movieService.GetMovies();
            List<Movie> sortedMovies = new List<Movie>();

            foreach(var movie in movies)
            {
                if (movie.Studio.Name == _currentStudio.Name)
                {
                    sortedMovies.Add(movie);
                }
            }

            sortedMovies = sortedMovies.OrderBy(g => g.Title).ToList();

            bs = new BindingSource();
            bs.DataSource = sortedMovies;
            StudioGrid.DataSource = bs;
            StudioGrid.ReadOnly = true;
        }



        private void StudioInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void EditStudioButton_Click(object sender, EventArgs e)
        {
             AddStudioForm addStudioForm = new AddStudioForm(_currentStudio);
             addStudioForm.StudioEdited += AddStudioForm_StudioEdited;
             addStudioForm.ShowDialog();
            
        }

        private void AddStudioForm_StudioEdited(object sender, EventArgs e)
        {
            _currentStudio = _studioService.GetStudioById(_currentStudio.Id);
            StudioTitle.Text = _currentStudio.Name;
            StudioDescription.Text = _currentStudio.Description;
            StudioAddress.Text = _currentStudio.Address;

            UpdateMoviesWithNewStudio();

            LoadMovies();
        }

        private void UpdateMoviesWithNewStudio()
        {
            List<Movie> movies = _movieService.GetMovies().Where(m => m.Studio.Id == _currentStudio.Id).ToList();
            foreach (var movie in movies)
            {
                movie.Studio = _currentStudio;
            }
        }

        private void DeleteStudioButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this studio?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _studioService.DeleteStudio(_currentStudio);
                MessageBox.Show("Studio deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            StudioClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
