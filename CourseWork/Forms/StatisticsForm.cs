using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.Service;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork.Forms
{
    public partial class StatisticsForm : Form
    {
        private MovieService _movieService;
        private GenreService _genreService;
        private StudioService _studioService;
        private ArtistService _artistService;

        public StatisticsForm()
        {
            InitializeComponent();
            ApplicationContext context = ApplicationContext.GetInstance();
            _movieService = context.MovieService;
            _genreService = context.GenreService;
            _studioService = context.StudioService;
            _artistService = context.ArtistService;
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            var movies = _movieService.GetMovies();

            var genreStats = movies
                .GroupBy(m => m.Genre.Name)
                .Select(g => new { Genre = g.Key, Count = g.Count() })
                .ToList();
            GenresChart.DataSource = genreStats;
            GenresChart.Series[0].XValueMember = "Genre";
            GenresChart.Series[0].YValueMembers = "Count";
            GenresChart.DataBind();

            var studioStats = movies
                .GroupBy(m => m.Studio.Name)
                .Select(s => new { Studio = s.Key, Count = s.Count() })
                .ToList();
            StudiosChart.DataSource = studioStats;
            StudiosChart.Series[0].XValueMember = "Studio";
            StudiosChart.Series[0].YValueMembers = "Count";
            StudiosChart.DataBind();

            var actorStats = movies
                .SelectMany(m => m.Squad)
                .Where(a => a.RoleName == RoleName.Actor)
                .GroupBy(a => a.ArtistName)
                .Select(a => new { Actor = a.Key, Count = a.Count() })
                .ToList();
            ArtistsChart.DataSource = actorStats;
            ArtistsChart.Series[0].XValueMember = "Actor";
            ArtistsChart.Series[0].YValueMembers = "Count";
            ArtistsChart.DataBind();

            var directorStats = movies
                .SelectMany(m => m.Squad)
                .Where(a => a.RoleName == RoleName.Director)
                .GroupBy(a => a.ArtistName)
                .Select(a => new { Director = a.Key, Count = a.Count() })
                .ToList();
            DirectorsChart.DataSource = directorStats;
            DirectorsChart.Series[0].XValueMember = "Director";
            DirectorsChart.Series[0].YValueMembers = "Count";
            DirectorsChart.DataBind();  
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
