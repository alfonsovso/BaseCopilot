namespace BaseCopilot.API.Repositories
{
    public interface ITaskEntryRepository
    {
        Task<List<TaskEntry>> CreateTaskEntry(TaskEntry taskEntry);
        Task<TaskEntry?> GetTaskEntryById(int id);
        Task<List<TaskEntry>> GetAllTaskEntries();
        Task<List<TaskEntry>> UpdateTaskEntry(int id, TaskEntry taskEntry);
        Task<List<TaskEntry>?> DeleteTaskEntry(int id);
    }
}
