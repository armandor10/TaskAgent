using System;
using TasksAPI.Contracts;
using TasksAPI.DTO;
using TasksAPI.Entities;
using TasksAPI.Repository;

namespace TasksAPI.BLL
{
    public class TaskBLL: ITaskBLL
    {
        private readonly ITasksRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public TaskBLL(ITasksRepository repository, IUnitOfWork unitOfWork)
        {
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }

        public async Task<Guid> Create(TasksDTO dTO)
        {
            var entity = new Tasks { Name = dTO.Name };
            await _repository.CreateAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity.Id;
        }

        public async Task<IEnumerable<Tasks>> GetAll()
        {
            return await _repository.GetAsync();
        }
    }
}

