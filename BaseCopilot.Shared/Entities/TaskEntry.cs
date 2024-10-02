namespace BaseCopilot.Shared.Entities
{
    public class TaskEntry : BaseEntity
    {
        public int? ProjectId { get; set; }
        public Project? Project { get; set; }
        public DateTime Start {  get; set; } = DateTime.Now;
        public DateTime? End { get; set; }
    }
}
