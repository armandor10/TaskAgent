using System;
using TasksAPI.Contracts;
using TasksAPI.Entities;
using TasksAPI.Repository;

namespace TasksAPI.BLL
{
    public class TaskBLL: ITaskBLL
    {
        private readonly ITasksRepository _repository;

        public TaskBLL(ITasksRepository repository)
        {
            this._repository = repository;
        }

        public async Task<IEnumerable<Tasks>> GetTasks()
        {
            return await _repository.GetAsync();
        }
    }
}

