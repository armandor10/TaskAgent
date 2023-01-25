using System;
using TasksAPI.DTO;
using TasksAPI.Entities;

namespace TasksAPI.Contracts
{
    public interface ITaskBLL
    {
        Task<IEnumerable<Tasks>> GetAll();
        Task<Guid> Create(TasksDTO dTO);
    }
}

