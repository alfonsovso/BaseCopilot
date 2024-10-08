namespace BaseCopilot.API.Repositories
{
    public class TaskEntryRepository : ITaskEntryRepository
    {

        private readonly DataContext _context;

        public TaskEntryRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<TaskEntry>> CreateTaskEntry(TaskEntry taskEntry)
        {
            _context.TaskEntries.Add(taskEntry);
            await _context.SaveChangesAsync();
            return await GetAllTaskEntries();
        }

        public async Task<TaskEntry?> GetTaskEntryById(int id)
        {
            var taskEntry = await _context.TaskEntries
                .Include(te => te.Project)
                .ThenInclude(p => p.ProjectDetails)
                .FirstOrDefaultAsync(te => te.Id == id);
            return taskEntry;
        }

        public async Task<List<TaskEntry>> GetAllTaskEntries()
        {
            return await _context.TaskEntries
                .Include(te => te.Project)
                .ThenInclude(p => p.ProjectDetails)
                .ToListAsync();
        }

        public async Task<List<TaskEntry>> UpdateTaskEntry(int id, TaskEntry taskEntry)
        {
            var dbTaskEntry = await _context.TaskEntries.FindAsync(id);
            if (dbTaskEntry == null)
            {
                throw new EntityNotFoundException($"Entity with ID {id} was not found.");
            }
            dbTaskEntry.ProjectId = taskEntry.ProjectId;
            dbTaskEntry.Start = taskEntry.Start;
            dbTaskEntry.End = taskEntry.End;
            dbTaskEntry.UpdatedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return await GetAllTaskEntries();
        }

        public async Task<List<TaskEntry>?> DeleteTaskEntry(int id)
        {
            var dbTaskEntry = await _context.TaskEntries.FindAsync(id);
            if (dbTaskEntry == null)
            {
                return null;
            }
            _context.TaskEntries.Remove(dbTaskEntry);
            await _context.SaveChangesAsync();

            return await GetAllTaskEntries();
        }

        public async Task<List<TaskEntry>> GetTaskEntriesByProjectId(int projectId)
        {
            return await _context.TaskEntries
                .Where(te => te.ProjectId == projectId)
                .Include(te => te.Project)
                .ThenInclude(p => p.ProjectDetails)
                .ToListAsync();
        }
    }
}
