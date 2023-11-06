using TaskApi.BusinessRules.Requests;
using TaskApi.BusinessRules.Responses;

namespace TaskApi.BusinessRules.Handlers
{
    public interface IUpsertTaskHandler
    {
        UpsertTaskResponse Execute(UpsertTaskRequest request);
    }
}
