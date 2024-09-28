using BaseCopilot.Shared.Entities;
using BaseCopilot.Shared.Models.TaskEntry;

namespace BaseCopilot.API.Services
{
    public interface ITaskEntryService
    {
        List<TaskEntryResponse> CreateTaskEntry(TaskEntryCreateRequest taskEntry);
        TaskEntryResponse? GetTaskEntryById(int id);
        List<TaskEntryResponse> GetAllTaskEntries();
        List<TaskEntryResponse>? UpdateTaskEntry(int id, TaskEntryUpdateRequest taskEntry);
        List<TaskEntryResponse>? DeleteTaskEntry(int id);
    }
}
