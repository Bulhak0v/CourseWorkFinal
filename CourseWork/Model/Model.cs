using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


namespace CourseWork.Model;

public class Model
{
    public BindingList<Movie> Movies { get; set; } = new BindingList<Movie>();
    public List<Studio> Studios { get; set; } = new List<Studio>();
    public List<Genre> Genres { get; set; } = new List<Genre>();
    public List<Artist> Artists { get; set; } = new List<Artist>();
    public List<Playlist> Playlists { get; set; } = new List<Playlist>();


    public Model()
    {
        Movies = new BindingList<Movie>();
        Studios = new List<Studio>();
        Genres = new List<Genre>();
        Artists = new List<Artist>();
        Playlists = new List<Playlist>();
    }

    public void AddMovie(Movie movie)
    {
        Movies.Add(movie);
    }

    public void AddStudio(Studio studio)
    {
        Studios.Add(studio);
    }


    public void AddGenre(Genre genre)
    {
        Genres.Add(genre);
    }

    public void AddArtist(Artist artist)
    {
        Artists.Add(artist);
    }

    public void AddPlaylist(Playlist playlist)
    {
        Playlists.Add(playlist);
    }

    public void DeleteMovie(Movie movie)
    {
        Movies.Remove(movie);
    }

    public void UpdateMovie(Movie editedMovie)
    {
        //foreach (var movie in Movies)
        //{
        //    if (movie.Id == editedMovie.Id)
        //    {
        //        movie.Title = editedMovie.Title;
        //        movie.Year = editedMovie.Year;
        //        movie.Description = editedMovie.Description;
        //        movie.Genre = editedMovie.Genre;
        //        movie.Duration = editedMovie.Duration;
        //        movie.Score = editedMovie.Score;
        //        movie.Studio = editedMovie.Studio;
        //    }
        //}
    }

    public void UpdateGenre(Genre editedGenre)
    {
        //foreach (var genre in Genres)
        //{
        //    if(genre.Id == editedGenre.Id)
        //    {
        //        genre.Name = editedGenre.Name;
        //        genre.Description = editedGenre.Description;
        //    }
        //}
    }

    public void DeleteGenre(Genre genre)
    {
        Genres.Remove(genre);
    }

    public void DeleteStudio(Studio studio)
    {
        Studios.Remove(studio);
    }

    public void UpdateStudio(Studio editedStudio)
    {
        foreach (var studio in Studios)
        {
            if (studio.Id == editedStudio.Id)
            {
                studio.Name = editedStudio.Name;
                studio.Description = editedStudio.Description;
                studio.Address = editedStudio.Address;
            }
        }
    }

    public void UpdateArtist(Artist editedArtist)
    {
        foreach (var artist in Artists)
        {
            if (artist.Id == editedArtist.Id)
            {
                artist.Name = editedArtist.Name;
                artist.Biography = editedArtist.Biography;
            }
        }
    }

    public void DeleteArtist(Artist artist)
    {
        Artists.Remove(artist);
    }

    public void DeletePlaylist(Playlist playlist)
    {
        Playlists.Remove(playlist);
    }

    public void AddMovieToPlaylist(Playlist playlistToEdit, Movie movie)
    {
        foreach (var playlist in Playlists)
        {
            if (playlist.Id == playlistToEdit.Id)
            {
                if (playlist.Movies == null)
                {
                    playlist.Movies = new List<Movie>();
                }

                playlist.Movies.Add(movie);
            }
        }
    }

    public void DeleteFromPlaylist(Movie movieToRemove, Playlist playlistFromRemove)
    {
        var moviesToRemove = new List<Movie>();

        foreach (var cMovie in playlistFromRemove.Movies)
        {
            if (cMovie.Id == movieToRemove.Id)
            {
                moviesToRemove.Add(cMovie);
            }
        }

        foreach (var movie in moviesToRemove)
        {
            playlistFromRemove.Movies.Remove(movie);
        }
    }
}