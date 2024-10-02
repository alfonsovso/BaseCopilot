namespace BaseCopilot.API.Services
{
    public interface IProjectService
    {
        Task<List<ProjectResponse>> CreateProject(ProjectCreateRequest project);
        Task<ProjectResponse?> GetProjectById(int id);
        Task<List<ProjectResponse>> GetAllProjects();
        Task<List<ProjectResponse>?> UpdateProject(int id, ProjectUpdateRequest project);
        Task<List<ProjectResponse>?> DeleteProject(int id);
    }
}
