using BaseCopilot.Shared.Exceptions;
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
        public async Task<List<TaskEntryResponse>> CreateTaskEntry(ProjectCreateRequest request)
        {
            var newEntry = request.Adapt<TaskEntry>();
            var result = await _taskEntryRepository.CreateTaskEntry(newEntry);
            return result.Adapt<List<TaskEntryResponse>>();
        }

        public async Task<TaskEntryResponse?> GetTaskEntryById(int id)
        {
            var result = await _taskEntryRepository.GetTaskEntryById(id);
            if (result is null)
            {
                return null;
            }
            return result.Adapt<TaskEntryResponse>();
        }

        public async Task<List<TaskEntryResponse>> GetAllTaskEntries()
        {
            var result = await _taskEntryRepository.GetAllTaskEntries();
            return result.Adapt<List<TaskEntryResponse>>();
        }

        public async Task<List<TaskEntryResponse>?> UpdateTaskEntry(int id, TaskEntryUpdateRequest request)
        {
            try
            {
                var updatedEntry = request.Adapt<TaskEntry>();
                var result = await _taskEntryRepository.UpdateTaskEntry(id, updatedEntry);
                return result.Adapt<List<TaskEntryResponse>>();
            }
            catch (EntityNotFoundException)
            {
                return null;
            }
        }

        public async Task<List<TaskEntryResponse>?> DeleteTaskEntry(int id)
        {
            var result = await _taskEntryRepository.DeleteTaskEntry(id);
            if (result is null)
            {
                return null;
            }
            return result.Adapt<List<TaskEntryResponse>>();
        }

        public async Task<List<TaskEntryByProjectResponse>> GetTaskEntriesByProjectId(int projectId)
        {
            var result = await _taskEntryRepository.GetTaskEntriesByProjectId(projectId);
            return result.Adapt<List<TaskEntryByProjectResponse>>();
        }
    }
}
