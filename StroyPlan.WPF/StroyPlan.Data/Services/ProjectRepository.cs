using StroyPlan.Core.Models;

namespace StroyPlan.Data.Services
{
    public class ProjectRepository
    {
        private readonly JsonStorageService _storageService;

        public ProjectRepository()
        {
            _storageService = new JsonStorageService();
        }

        public void SaveProject(string filePath, Project project)
        {
            _storageService.Save(filePath, project);
        }

        public Project? LoadProject(string filePath)
        {
            return _storageService.Load<Project>(filePath);
        }
    }
}