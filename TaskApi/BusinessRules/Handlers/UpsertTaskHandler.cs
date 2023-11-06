using System;
using TaskApi.BusinessRules.Requests;
using TaskApi.BusinessRules.Responses;
using TaskApi.BusinessRules.Validators.Interfaces;
using TaskApi.Infrastructure.Repositories;

namespace TaskApi.BusinessRules.Handlers
{
    public class UpsertTaskHandler : IUpsertTaskHandler
    {
        private readonly ITaskRepository _repository;
        private readonly ITaskValidator _validator;
        public UpsertTaskHandler(ITaskRepository repository, ITaskValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public UpsertTaskResponse Execute(UpsertTaskRequest request)
        {
            var validatorResult = _validator.Validate(request);
            if (!validatorResult.IsValid)
            {
                return new UpsertTaskResponse
                {
                    Errors = validatorResult.Errors
                };
            }

            Task entity;

            if (request.Id.HasValue)
            {
                entity = _repository.GetById(request.Id.Value);
                if (entity == null)
                    throw new Exception("Tarefa não encontrada");
            }
            else
            {
                entity = new Task();
            }

            entity.Title = request.Title;
            entity.Description = request.Description;
            entity.Done = request.Done;
            if (request.Done)
                entity.DateDone = DateTime.Now;
            else
                entity.DateDone = null;

            _repository.Create(entity);

            return new UpsertTaskResponse
            {
                Payload = new UpsertTaskPayload
                {
                    Id = entity.Id.Value,
                    Title = entity.Title,
                    Description = entity.Description,
                    Done = entity.Done,
                    DateDone = entity.DateDone,
                }
            };
        }
    }
}
