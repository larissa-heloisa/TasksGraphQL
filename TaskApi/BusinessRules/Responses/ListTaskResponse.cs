using System.Collections.Generic;

namespace TaskApi.BusinessRules.Responses
{
    public class ListTaskResponse
    {
        public List<TaskResponseItem> Payloads { get; set; }
    }
}
