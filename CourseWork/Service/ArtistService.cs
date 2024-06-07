using CourseWork.Model;
using CourseWork.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Service
{
    public class ArtistService
    {
        private IAppRepo _appRepo;
        public ArtistService(IAppRepo appRepo)
        {
            _appRepo = appRepo;
        }

        public void AddArtist(string name, string biography)
        {
            Artist artist = new Artist
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Biography = biography
            };
            _appRepo.SaveArtist(artist);
        }

        public List<Artist> GetArtists()
        {
            return _appRepo.GetArtists();
        }

        public void UpdateArtist(Artist artist)
        {
            _appRepo.UpdateArtist(artist);
        }

        public Artist GetArtistById(string id)
        {
            return _appRepo.GetArtists().FirstOrDefault(a => a.Id == id);
        }

        public void DeleteArtist(Artist artist)
        {
            _appRepo.DeleteArtist(artist);
        }
    }
}
