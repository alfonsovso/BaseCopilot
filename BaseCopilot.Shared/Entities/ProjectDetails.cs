using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCopilot.Shared.Entities
{
    public class ProjectDetails
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int ProjectId { get; set; }
        public required Project Project { get; set; }
    }
}
