using HotChocolate;
using TaskApi.BusinessRules.Handlers;
using TaskApi.BusinessRules.Requests;
using TaskApi.BusinessRules.Responses;

namespace TaskApi.Application
{
    public class Mutation
    {
        public UpsertTaskResponse UpsertTask([Service] IUpsertTaskHandler handler, UpsertTaskRequest request)
        {
            return handler.Execute(request);
        }
    }
}
