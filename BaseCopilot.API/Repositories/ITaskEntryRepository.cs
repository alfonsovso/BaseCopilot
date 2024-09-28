using BaseCopilot.Shared.Entities;
using BaseCopilot.Shared.Models.TaskEntry;

namespace BaseCopilot.API.Repositories
{
    public interface ITaskEntryRepository
    {
        List<TaskEntry> CreateTaskEntry(TaskEntry taskEntry);
        TaskEntry? GetTaskEntryById(int id);
        List<TaskEntry> GetAllTaskEntries();
        List<TaskEntry>? UpdateTaskEntry(int id, TaskEntry taskEntry);
        List<TaskEntry>? DeleteTaskEntry(int id);
    }
}
