using TaskApi.BusinessRules.Responses;

namespace TaskApi.BusinessRules.Handlers.Interfaces
{
    public interface IGetAllTasksHandler
    {
        ListTaskResponse Execute();
    }
}
