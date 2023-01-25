using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using TasksAPI.Entities;

namespace TasksAPI.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Tasks> Tasks { get; set; }

    }
}

