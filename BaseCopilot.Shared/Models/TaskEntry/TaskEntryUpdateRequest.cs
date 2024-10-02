namespace BaseCopilot.Shared.Models.TaskEntry
{
    public class TaskEntryUpdateRequest
    {
        public int ProjectId { get; set; }
        public DateTime Start { get; set; } = DateTime.Now;
        public DateTime? End { get; set; }
    }
}
