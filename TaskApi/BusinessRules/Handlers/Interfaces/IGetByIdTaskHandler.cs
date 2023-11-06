using TaskApi.BusinessRules.Requests;
using TaskApi.BusinessRules.Responses;

namespace TaskApi.BusinessRules.Handlers.Interfaces
{
    public interface IGetByIdTaskHandler
    {
        TaskResponse Execute(GetByIdTaskRequest request);
    }
}
