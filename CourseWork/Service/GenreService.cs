using CourseWork.Model;
using CourseWork.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CourseWork.Service
{
    public class GenreService
    {
        private IAppRepo _appRepo;
        public GenreService(IAppRepo appRepo)
        {
            _appRepo = appRepo;
        }

        public void AddGenre(string name, string description)
        {
            Genre genre = new Genre
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Description = description
            };
            _appRepo.SaveGenre(genre);
        }

        public List<Genre> GetGenres()
        {
            return _appRepo.GetGenres();
        }

        public Genre GetGenreById(string id)
        {
            return _appRepo.GetGenres().FirstOrDefault(g => g.Id == id);
        }

        public void DeleteGenre(Genre genre)
        {
            _appRepo.DeleteGenre(genre);
        }
    }
}
