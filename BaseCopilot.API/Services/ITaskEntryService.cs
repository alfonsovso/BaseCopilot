using BaseCopilot.Shared.Entities;
using BaseCopilot.Shared.Models.TaskEntry;

namespace BaseCopilot.API.Services
{
    public interface ITaskEntryService
    {
        List<TaskEntryResponse> GetAllTaskEntries();
        List<TaskEntryResponse> CreateTaskEntry(TaskEntryCreateRequest taskEntry);
    }
}
