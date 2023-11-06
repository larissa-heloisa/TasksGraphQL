using Microsoft.EntityFrameworkCore;

namespace TaskApi.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }

    }
}
