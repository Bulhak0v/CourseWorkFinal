using CourseWork.Model;
using CourseWork.Repo;
using System.ComponentModel;

namespace CourseWork.Service;

public class MovieService
{
    private IAppRepo _appRepo;
    //private GenreService _genreService;

    public MovieService(IAppRepo appRepo)
    {
        _appRepo = appRepo;
    }

    public void AddMovie(string title, decimal year, string description, string genre, decimal duration, decimal score, string studio, List<FilmCreationRole> roles)
    {
        var genres = _appRepo.GetGenres();
        var movieGenre = genres.FirstOrDefault(g => g.Name.Equals(genre, StringComparison.OrdinalIgnoreCase));

        var studios = _appRepo.GetStudios();
        var movieStudio = studios.FirstOrDefault(c => c.Name.Equals(studio, StringComparison.OrdinalIgnoreCase));

        if (movieGenre == null)
        {
            movieGenre = new Genre() { Name = genre};
        }

        if (movieStudio == null)
        {
            movieStudio = new Studio() { Name = studio};
        }

        Movie newMovie = new Movie {
            Id = Guid.NewGuid().ToString(),
            Title = title,
            Year = Convert.ToInt32(year),
            Description = description,
            Genre = movieGenre,
            Score = Convert.ToInt32(score),
            Duration = Convert.ToInt32(duration),
            Studio = movieStudio,
            Squad = roles
        };
        _appRepo.SaveMovie(newMovie);

        if (movieGenre.Id == null) 
        {
            _appRepo.SaveGenre(movieGenre);
        }

        if (movieStudio.Id == null)
        {
            _appRepo.SaveStudio(movieStudio);
        }
    }

    public void DeleteMovie(Movie movie)
    {
        _appRepo.DeleteMovie(movie);
    }

    public BindingList<Movie> GetMovies()
    {
        return _appRepo.GetMovies();
    }

    public void UpdateMovie(Movie editedMovie)
    {
        _appRepo.UpdateMovie(editedMovie);
    }

}