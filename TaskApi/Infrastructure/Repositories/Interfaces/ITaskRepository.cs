using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApi.Infrastructure.Repositories
{
    public interface ITaskRepository
    {
        IQueryable<Task> GetAll();
        Task GetById(Guid Id);
        Task Create(Task task);

    }
}
