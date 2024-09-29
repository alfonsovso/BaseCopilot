namespace BaseCopilot.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<TaskEntry> TaskEntries{ get; set; }
    }
}
