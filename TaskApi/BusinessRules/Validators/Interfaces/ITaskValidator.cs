using FluentValidation;
using TaskApi.BusinessRules.Requests;

namespace TaskApi.BusinessRules.Validators.Interfaces
{
    public interface ITaskValidator : IValidator<UpsertTaskRequest>
    {
    }
}
