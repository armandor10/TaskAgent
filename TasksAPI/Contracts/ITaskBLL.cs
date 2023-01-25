using System;
using TasksAPI.Entities;

namespace TasksAPI.Contracts
{
    public interface ITaskBLL
    {
        Task<IEnumerable<Tasks>> GetTasks();
    }
}

