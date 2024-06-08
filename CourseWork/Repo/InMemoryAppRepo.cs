namespace CourseWork.Repo;
using Model;
using System.ComponentModel;
using System.Drawing.Text;

public class InMemoryAppRepo: IAppRepo
{
    private readonly Model _model;

    public InMemoryAppRepo(Model model)
    {
        _model = model;
    }

    public BindingList<Movie> GetMovies()
    {
        return _model.Movies;
    }

    public void SaveMovie(Movie movie)
    {
        _model.AddMovie(movie);
    }
    public void DeleteMovie(Movie movie)
    {
        _model.DeleteMovie(movie);
    }

    public void UpdateMovie(Movie movie)
    {
        _model.UpdateMovie(movie);
    }

    public List<Studio> GetStudios()
    {
        return _model.Studios;
    }

    public void SaveStudio(Studio studio)
    {
        _model.AddStudio(studio);
    }
    
    public void DeleteStudio(Studio studio)
    {
        _model.DeleteStudio(studio);
    }

    public void UpdateStudio(Studio studio)
    {
        _model.UpdateStudio(studio);
    }
    public List<Artist> GetArtists()
    {
        return _model.Artists;
    }

    public void SaveArtist(Artist artist)
    {
        _model.AddArtist(artist);
    }
    
    public void UpdateArtist(Artist artist)
    {
        _model.UpdateArtist(artist);
    }

    public void DeleteArtist(Artist artist)
    {
        _model.DeleteArtist(artist);
    }

    public List<Genre> GetGenres()
    {
        return _model.Genres;
    }

    public void SaveGenre(Genre genre)
    {
        _model.AddGenre(genre);
    }

    public void UpdateGenre(Genre genre)
    {
        _model.UpdateGenre(genre);
    }

    public void DeleteGenre(Genre genre)
    {
        _model.DeleteGenre(genre);
    }

    public List<Playlist> GetPlaylists()
    {
        return _model.Playlists;
    }

    public void SavePlaylist(Playlist playlist)
    {
        _model.AddPlaylist(playlist);
    }

    public void DeletePlaylist(Playlist playlist)
    {
        _model.DeletePlaylist(playlist);
    }

    public void AddMovieToPlaylist(Playlist playlist, Movie movie)
    {
        _model.AddMovieToPlaylist(playlist, movie);
    }

    public void DeleteFromPlaylist(Movie movie, Playlist playlist)
    {
        _model.DeleteFromPlaylist(movie, playlist);
    }
}