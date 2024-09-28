using BaseCopilot.API.Repositories;
using BaseCopilot.Shared.Entities;
using BaseCopilot.Shared.Models.TaskEntry;
using Mapster;

namespace BaseCopilot.API.Services
{
    public class TaskEntryService : ITaskEntryService
    {
        private readonly ITaskEntryRepository _taskEntryRepository;

        public TaskEntryService(ITaskEntryRepository taskEntryRepository)
        {
            _taskEntryRepository = taskEntryRepository;
        }
        public List<TaskEntryResponse> CreateTaskEntry(TaskEntryCreateRequest request)
        {
            var newEntry = request.Adapt<TaskEntry>();
            var result = _taskEntryRepository.CreateTaskEntry(newEntry);
            return result.Adapt<List<TaskEntryResponse>>();
        }

        public TaskEntryResponse? GetTaskEntryById(int id)
        {
            var result = _taskEntryRepository.GetTaskEntryById(id);
            if (result is null)
            {
                return null;
            }
            return result.Adapt<TaskEntryResponse>();
        }

        public List<TaskEntryResponse> GetAllTaskEntries()
        {
            var result = _taskEntryRepository.GetAllTaskEntries();
            return result.Adapt<List<TaskEntryResponse>>();
        }

        public List<TaskEntryResponse>? UpdateTaskEntry(int id, TaskEntryUpdateRequest request)
        {
            var updatedEntry = request.Adapt<TaskEntry>();
            var result = _taskEntryRepository.UpdateTaskEntry(id, updatedEntry);
            if (result is null)
            {
                return null;
            }
            return result.Adapt<List<TaskEntryResponse>>();
        }

        public List<TaskEntryResponse>? DeleteTaskEntry(int id)
        {
            var result = _taskEntryRepository.DeleteTaskEntry(id);
            if (result is null)
            {
                return null;
            }
            return result.Adapt<List<TaskEntryResponse>>();
        }
    }
}
