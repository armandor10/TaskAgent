using System;
using Microsoft.EntityFrameworkCore;
using TasksAPI.Contracts;

namespace TasksAPI.DAL
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext, IDisposable
    {
        public UnitOfWork(TContext context, ILogger<UnitOfWork<TContext>> logger)
        {
            Context = context ?? throw new ArgumentException(nameof(context));
            _logger = logger;
        }

        public TContext Context { get; }

        private ILogger<UnitOfWork<TContext>> _logger;

        public async Task CommitAsync()
        {
            try
            {
                await Context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error trying to update database");
            }
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}

