using BaseCopilot.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaseCopilot.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TaskEntryController : ControllerBase
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

        [HttpGet]
        public ActionResult<List<TaskEntry>> GetAllTaskEntries()
        {
            return Ok(_taskEntry);
        }
    }
}
