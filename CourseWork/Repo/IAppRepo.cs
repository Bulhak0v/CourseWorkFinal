namespace CourseWork.Repo;
using CourseWork.Model;
using System.ComponentModel;

public interface IAppRepo
{
    BindingList<Movie> GetMovies();
    void SaveMovie(Movie movie);
    void DeleteMovie(Movie movie);
    void UpdateMovie(Movie movie);
    List<Studio> GetStudios();
    void SaveStudio(Studio studio);
    void DeleteStudio(Studio studio);
    void UpdateStudio(Studio studio);
    List<Artist> GetArtists();
    void SaveArtist(Artist artist);
    void UpdateArtist(Artist artist);
    void DeleteArtist(Artist artist);
    List<Genre> GetGenres();
    void SaveGenre(Genre genre);
    void UpdateGenre(Genre genre);
    void DeleteGenre(Genre genre);
    List<Playlist> GetPlaylists();
    void SavePlaylist(Playlist playlist);
    void DeletePlaylist(Playlist playlist);
    void AddMovieToPlaylist(Playlist playlist, Movie movie);
}