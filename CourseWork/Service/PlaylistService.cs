using CourseWork.Model;
using CourseWork.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Service
{
    public class PlaylistService
    {
        private IAppRepo _appRepo;
        public PlaylistService(IAppRepo appRepo)
        {
            _appRepo = appRepo;
        }

        public void AddPlaylist(string title, string description)
        {
            Playlist playlist = new Playlist()
            {
                Id = Guid.NewGuid().ToString(),
                Title = title,
                Description = description
            };
            _appRepo.SavePlaylist(playlist);
        }

        public List<Playlist> GetPlaylists()
        {
            return _appRepo.GetPlaylists();
        }

        public Playlist GetPlaylistById(string id)
        {
            return _appRepo.GetPlaylists().FirstOrDefault(g => g.Id == id);
        }

        public void DeletePlaylist(Playlist playlist)
        {
            _appRepo.DeletePlaylist(playlist);
        }

        public void AddMovieToPlaylist(Playlist playlist, Movie movie)
        {
            _appRepo.AddMovieToPlaylist(playlist, movie);
        }
    }
}
