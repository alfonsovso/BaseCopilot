using BaseCopilot.API.Repositories;
using BaseCopilot.Shared.Entities;
using BaseCopilot.Shared.Models.TaskEntry;
using Mapster;
using System.Formats.Tar;

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

        public List<TaskEntryResponse> GetAllTaskEntries()
        {
            var result = _taskEntryRepository.GetAllTaskEntries();
            return result.Adapt<List<TaskEntryResponse>>();
        }
    }
}
