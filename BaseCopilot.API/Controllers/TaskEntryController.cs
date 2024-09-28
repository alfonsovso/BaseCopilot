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

        [HttpGet("{id}")]
        public ActionResult<TaskEntryResponse> GetTaskEntryById(int id)
        {
            var result = _taskEntryService.GetTaskEntryById(id);
            if (result is null)
            {
                return NotFound("TaskEntry with the given ID was not found.");
            }
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<List<TaskEntryResponse>> CreateTaskEntry(TaskEntryCreateRequest taskEntry)
        {
            return Ok(_taskEntryService.CreateTaskEntry(taskEntry));
        }

        [HttpPut("{id}")]
        public ActionResult<List<TaskEntryResponse>> UpdateTaskEntry(int id, TaskEntryUpdateRequest taskEntry)
        {
            var result = _taskEntryService.UpdateTaskEntry(id, taskEntry);
            if (result is null)
            {
                return NotFound("TaskEntry with the given ID was not found.");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<TaskEntryResponse>> DeleteTaskEntry(int id)
        {
            var result = _taskEntryService.DeleteTaskEntry(id);
            if (result is null)
            {
                return NotFound("TaskEntry with the given ID was not found.");
            }
            return Ok(result);
        }
    }
}
