using System;
using TasksAPI.Entities;

namespace TasksAPI.Contracts
{
    public interface ITasksRepository: IGenericRepository<Tasks>
    {
    }
}

