using Microsoft.EntityFrameworkCore;
using projectEF.Models;

namespace projectEF
{
    public class TaskContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tasks> Tasks { get; set; }

        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            
        }
    }
}