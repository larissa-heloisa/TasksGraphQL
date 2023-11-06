using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.BusinessRules.Handlers.Interfaces;
using TaskApi.BusinessRules.Requests;
using TaskApi.BusinessRules.Responses;
using TaskApi.Infrastructure.Repositories;

namespace TaskApi.BusinessRules.Handlers
{
    public class GetByIdTaskHandler : IGetByIdTaskHandler
    {
        private readonly ITaskRepository _repository;

        public GetByIdTaskHandler(ITaskRepository repository)
        {
            _repository = repository;
        }

        public TaskResponse Execute(GetByIdTaskRequest request)
        {
            var task = _repository.GetById(request.Id);
            if (task == null)
                throw new Exception("Tarefa não encontrada");

            return new TaskResponse
            {
                Payload = new TaskResponseItem
                {
                    Id = task.Id.Value,
                    Title = task.Title,
                    Description = task.Description,
                    Done = task.Done,
                    DateDone = task.DateDone
                }
            };
        }
    }
}
