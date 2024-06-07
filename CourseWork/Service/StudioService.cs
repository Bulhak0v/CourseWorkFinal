using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork.Model;
using CourseWork.Repo;

namespace CourseWork.Service
{
    public class StudioService
    {
        private IAppRepo _appRepo;
        
        public StudioService(IAppRepo appRepo)
        {
            _appRepo = appRepo;
        }
        public void AddStudio(string name, string address, string description)
        {
            Studio studio = new Studio
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Address = address,
                Description = description
            };

            _appRepo.SaveStudio(studio);
        }

        public List<Studio> GetStudios()
        {
           return _appRepo.GetStudios();
        }

        public void UpdateStudio(Studio studio)
        {
            _appRepo.UpdateStudio(studio);
        }

        public Studio GetStudioById(string id)
        {
            return _appRepo.GetStudios().FirstOrDefault(s => s.Id == id);
        }

        public void DeleteStudio(Studio studio)
        {
            _appRepo.DeleteStudio(studio);
        }
    }
}
