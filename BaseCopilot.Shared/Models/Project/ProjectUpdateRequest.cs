namespace BaseCopilot.Shared.Models.Project
{
    public class ProjectUpdateRequest
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
