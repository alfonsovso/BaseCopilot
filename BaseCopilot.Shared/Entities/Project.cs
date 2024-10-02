using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCopilot.Shared.Entities
{
    public  class Project : SoftDeleteableEntity
    {
        public required string Name { get; set; }
        public List<TaskEntry> TaskEntries { get; set; } = new List<TaskEntry>();
        public ProjectDetails? ProjectDetails { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
