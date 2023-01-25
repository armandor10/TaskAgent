using System;
using Microsoft.EntityFrameworkCore;

namespace TasksAPI.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        Task CommitAsync();
    }

    public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        TContext Context { get; }
    }
}

