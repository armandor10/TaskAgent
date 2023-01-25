using System;
using Microsoft.AspNetCore.Mvc;
using TasksAPI.Contracts;
using TasksAPI.DTO;

namespace TasksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskBLL _taskBLL;
        private readonly ILogger<TaskController> _logger;

        public TaskController(ITaskBLL taskBLL, ILogger<TaskController> logger)
        {
            this._taskBLL = taskBLL;
            this._logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _taskBLL.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create(TasksDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    _logger.LogError("Object sent from client is null.");
                    return BadRequest("TaskDto object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid object sent from client.");
                    return BadRequest("Invalid model object");
                }
                return CreatedAtAction("Get", new { id = await _taskBLL.Create(dto) });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside Create action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

