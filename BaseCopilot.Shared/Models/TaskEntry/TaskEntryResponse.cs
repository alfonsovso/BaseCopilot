﻿using BaseCopilot.Shared.Models.Project;

namespace BaseCopilot.Shared.Models.TaskEntry
{
    public class TaskEntryResponse
    {
        public int Id { get; set; }
        public required ProjectResponse Project { get; set; }
        public DateTime Start { get; set; } = DateTime.Now;
        public DateTime? End { get; set; }
    }
}
