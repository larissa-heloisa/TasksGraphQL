using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApi.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {

        private readonly Context _context;

        public TaskRepository(Context context)
        {
            _context = context;
        }
        public Task Create(Task task)
        {
            if (!task.Id.HasValue)
            {
                task.Id = Guid.NewGuid();
                _context.Tasks.Add(task);
            }

            _context.SaveChanges();

            return task;
        }

        public IQueryable<Task> GetAll()
        {
            return _context.Tasks.AsQueryable();
        }

        public Task GetById(Guid Id)
        {
            return _context.Tasks.SingleOrDefault(item => item.Id == Id);
        }
    }
}
