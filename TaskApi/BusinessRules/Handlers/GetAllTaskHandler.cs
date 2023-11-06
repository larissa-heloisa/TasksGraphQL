using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.BusinessRules.Handlers.Interfaces;
using TaskApi.BusinessRules.Responses;
using TaskApi.Infrastructure.Repositories;

namespace TaskApi.BusinessRules.Handlers
{
    public class GetAllTaskHandler : IGetAllTasksHandler
    {
        private readonly ITaskRepository _repository;

        public GetAllTaskHandler(ITaskRepository repository)
        {
            _repository = repository;
        }
        public ListTaskResponse Execute()
        {
            var tasks = _repository.GetAll()
                .Select(q => new TaskResponseItem
                {
                    Id = q.Id.Value,
                    Title = q.Title,
                    Description = q.Description,
                    Done = q.Done,
                    DateDone = q.DateDone
                })
                .ToList();

            return new ListTaskResponse
            {
                Payloads = tasks
            };
        }
    }

}
