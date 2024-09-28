using BaseCopilot.Shared.Entities;

namespace BaseCopilot.API.Repositories
{
    public class TaskEntryRepository : ITaskEntryRepository
    {

        private static List<TaskEntry> _taskEntry = new List<TaskEntry>
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

        public TaskEntry? GetTaskEntryById(int id)
        {
            return _taskEntry.FirstOrDefault(t => t.Id == id);
        }

        public List<TaskEntry> GetAllTaskEntries()
        {
            return _taskEntry;
        }

        public List<TaskEntry>? UpdateTaskEntry(int id, TaskEntry taskEntry)
        {
            var entryToUpdateIndex = _taskEntry.FindIndex(t => t.Id == id);
            if (entryToUpdateIndex == -1)
            {
                return null;
            }
            _taskEntry[entryToUpdateIndex] = taskEntry;
            return _taskEntry;
        }

        public List<TaskEntry>? DeleteTaskEntry(int id)
        {
            var entryToDelete = _taskEntry.FirstOrDefault(t => t.Id == id);
            if (entryToDelete == null)
            {
                return null;
            }
            _taskEntry.Remove(entryToDelete);
            return _taskEntry;
        }
    }
}
