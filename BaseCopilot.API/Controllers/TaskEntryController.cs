using BaseCopilot.API.Repositories;
using BaseCopilot.API.Services;
using BaseCopilot.Shared.Entities;
using BaseCopilot.Shared.Models.TaskEntry;
using Microsoft.AspNetCore.Mvc;

namespace BaseCopilot.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TaskEntryController : ControllerBase
    {
        private readonly ITaskEntryService _taskEntryService;

        public TaskEntryController(ITaskEntryService taskEntryService)
        {
            _taskEntryService = taskEntryService;
        }

        [HttpGet]
        public ActionResult<List<TaskEntryResponse>> GetAllTaskEntries()
        {
            return Ok(_taskEntryService.GetAllTaskEntries());
        }

        [HttpPost]
        public ActionResult<List<TaskEntryResponse>> CreateTaskEntry(TaskEntryCreateRequest taskEntry)
        {
            return Ok(_taskEntryService.CreateTaskEntry(taskEntry));
        }
    }
}
