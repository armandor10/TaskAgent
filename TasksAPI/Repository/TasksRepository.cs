using System;
using Microsoft.EntityFrameworkCore;
using TasksAPI.Contracts;
using TasksAPI.DAL;
using TasksAPI.Entities;

namespace TasksAPI.Repository
{
    public class TasksRepository: GenericRepository<Tasks>, ITasksRepository 
    {
        public TasksRepository(ApplicationContext context): base(context)
        {
        }
    }
}

