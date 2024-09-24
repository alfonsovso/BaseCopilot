namespace BaseCopilot.Shared.Entities
{
    public class TaskEntry
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public DateTime Start {  get; set; } = DateTime.Now;
        public DateTime? End { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
