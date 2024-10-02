namespace BaseCopilot.API.Services
{
    public interface ITaskEntryService
    {
        Task<List<TaskEntryResponse>> CreateTaskEntry(ProjectCreateRequest taskEntry);
        Task<TaskEntryResponse?> GetTaskEntryById(int id);
        Task<List<TaskEntryResponse>> GetAllTaskEntries();
        Task<List<TaskEntryResponse>?> UpdateTaskEntry(int id, TaskEntryUpdateRequest taskEntry);
        Task<List<TaskEntryResponse>?> DeleteTaskEntry(int id);
        Task<List<TaskEntryByProjectResponse>> GetTaskEntriesByProjectId(int projectId);
    }
}
