using BaseCopilot.Shared.Entities;

namespace BaseCopilot.API.Repositories
{
    public class TaskEntryRepository : ITaskEntryRepository
    {

        private List<TaskEntry> _taskEntry = new List<TaskEntry>
        {
            new TaskEntry
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                End = DateTime.Now.AddHours(1),
            }
        };

        public List<TaskEntry> CreateTaskEntry(TaskEntry taskEntry)
        {
            _taskEntry.Add(taskEntry);
            return _taskEntry;
        }

        public List<TaskEntry> GetAllTaskEntries()
        {
            return _taskEntry;
        }
    }
}
