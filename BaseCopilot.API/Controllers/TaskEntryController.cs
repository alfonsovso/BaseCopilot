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

        [HttpPost]
        public async Task<ActionResult<List<TaskEntryResponse>>> CreateTaskEntry(TaskEntryCreateRequest taskEntry)
        {
            return Ok(await _taskEntryService.CreateTaskEntry(taskEntry));
        }

        [HttpGet]
        public async Task<ActionResult<List<TaskEntryResponse>>> GetAllTaskEntries()
        {
            return Ok(await _taskEntryService.GetAllTaskEntries());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskEntryResponse>> GetTaskEntryById(int id)
        {
            var result = await _taskEntryService.GetTaskEntryById(id);
            if (result is null)
            {
                return NotFound("TaskEntry with the given ID was not found.");
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<TaskEntryResponse>>> UpdateTaskEntry(int id, TaskEntryUpdateRequest taskEntry)
        {
            var result = await _taskEntryService.UpdateTaskEntry(id, taskEntry);
            if (result is null)
            {
                return NotFound("TaskEntry with the given ID was not found.");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TaskEntryResponse>>> DeleteTaskEntry(int id)
        {
            var result = await _taskEntryService.DeleteTaskEntry(id);
            if (result is null)
            {
                return NotFound("TaskEntry with the given ID was not found.");
            }
            return Ok(result);
        }
    }
}
