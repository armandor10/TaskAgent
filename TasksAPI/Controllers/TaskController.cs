using System;
using Microsoft.AspNetCore.Mvc;
using TasksAPI.Contracts;

namespace TasksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskBLL _taskBLL;

        public TaskController(ITaskBLL taskBLL)
        {
            this._taskBLL = taskBLL;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _taskBLL.GetTasks());
        }
    }
}

