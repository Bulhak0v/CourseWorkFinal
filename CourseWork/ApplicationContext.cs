using CourseWork.Model;
using CourseWork.Repo;
using CourseWork.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseWork
{
    public class ApplicationContext
    {
        private static ApplicationContext _instance;
        private static readonly string DataFilePath = "data.json";

        private Model.Model _model;
        public MovieService MovieService { get; }
        public GenreService GenreService { get;}
        public StudioService StudioService { get;}
        public ArtistService ArtistService { get; }
        public PlaylistService PlaylistService { get; }

        private ApplicationContext()
        {
            LoadModel();
            // Create repo
            IAppRepo appRepo = new InMemoryAppRepo(_model);

            // Create services
            MovieService = new MovieService(appRepo);
            GenreService = new GenreService(appRepo);
            StudioService = new StudioService(appRepo);
            ArtistService = new ArtistService(appRepo);
            PlaylistService = new PlaylistService(appRepo);

            // If the model was not loaded, initialize default data
            if (_model.Genres.Count == 0 && _model.Studios.Count == 0 && _model.Artists.Count == 0)
            {
                InitializeDefaultData();
            }

            Console.WriteLine("Context initialized");
        }

        public static ApplicationContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ApplicationContext();
            }
            return _instance;
        }

        private void InitializeDefaultData()
        {
            GenreService.AddGenre("Romantic", "Default");
            GenreService.AddGenre("Action", "Default");
            GenreService.AddGenre("Fantasy", "Default");
            GenreService.AddGenre("Drama", "Default");
            GenreService.AddGenre("Comedy", "Default");

            StudioService.AddStudio("Disney", "Burbank, California, 500 S Buena Vista St, United States", "Default");
            StudioService.AddStudio("Warner Bros", "Burbank, California,4000 Warner Boulevard, United States", "Default");
            StudioService.AddStudio("Paramount", "1515 Broadway, New York City, New York, 10036, United States", "Default");
            StudioService.AddStudio("Lionsgate", "2700 Colorado Ave, Ste 200, Santa Monica, CA", "Default");
            StudioService.AddStudio("20th Century Fox", "500 S Buena Vista St, Burbank, CA 91521", "Default");

            // MovieService.AddMovie("Titanic", 1998, "Default", "Romantic", 188, 9, "Paramount");
            // MovieService.AddMovie("La-la-land", 2016, "Default", "Romantic", 188, 8, "Lionsgate");

            ArtistService.AddArtist("Ryan Gosling", "Default");
            ArtistService.AddArtist("Dwayne Johnson", "The Rock");
            ArtistService.AddArtist("Christian Bale", "Psycho");
        }

        public void LoadModel()
        {
            if (File.Exists(DataFilePath))
            {
                var jsonData = File.ReadAllText(DataFilePath);
                _model = JsonSerializer.Deserialize<Model.Model>(jsonData);
            }
        }

        public void SaveModel()
        {
                var options = new JsonSerializerOptions { WriteIndented = true };
                var jsonData = JsonSerializer.Serialize(_model, options);
                File.WriteAllText(DataFilePath, jsonData);
        } 
    }
}
