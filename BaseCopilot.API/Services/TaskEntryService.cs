using BaseCopilot.API.Repositories;
using BaseCopilot.Shared.Entities;
using BaseCopilot.Shared.Models.TaskEntry;
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
        public List<TaskEntryResponse> CreateTaskEntry(TaskEntryCreateRequest taskEntry)
        {
            var newEntry = new TaskEntry
            {
                Name = taskEntry.Name,
                Description = taskEntry.Description,
                Start = taskEntry.Start,
                End = taskEntry.End,
            };
            var result = _taskEntryRepository.CreateTaskEntry(newEntry);
            return result.Select(t => new TaskEntryResponse
            {
                Id = t.Id,
                Name = t.Name,
                Description = t.Description,
                Start = t.Start,
                End = t.End
            }).ToList();
        }

        public List<TaskEntryResponse> GetAllTaskEntries()
        {
            var result = _taskEntryRepository.GetAllTaskEntries();
            return result.Select(t => new TaskEntryResponse
            {
                Id = t.Id,
                Name = t.Name,
                Description = t.Description,
                Start = t.Start,
                End = t.End
            }).ToList();
        }
    }
}
