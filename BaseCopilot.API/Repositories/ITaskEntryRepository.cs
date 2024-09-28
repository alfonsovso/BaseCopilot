using BaseCopilot.Shared.Entities;
using BaseCopilot.Shared.Models.TaskEntry;

namespace BaseCopilot.API.Repositories
{
    public interface ITaskEntryRepository
    {
        List<TaskEntry> GetAllTaskEntries();
        List<TaskEntry> CreateTaskEntry(TaskEntry taskEntry);
    }
}
