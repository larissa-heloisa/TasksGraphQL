using HotChocolate;
using TaskApi.BusinessRules.Handlers.Interfaces;
using TaskApi.BusinessRules.Requests;
using TaskApi.BusinessRules.Responses;

namespace TaskApi.Application
{
    public class Query
    {
        public ListTaskResponse GetTasks([Service] IGetAllTasksHandler handler)
        {
            return handler.Execute();
        }

        public TaskResponse GetTask([Service] IGetByIdTaskHandler handler, GetByIdTaskRequest request)
        {
            return handler.Execute(request);
        }
    }
}
