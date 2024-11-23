using Microsoft.EntityFrameworkCore;
using Task = TaskManagementAPI.Models.Task;

namespace TaskManagementAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Task> Tasks { get; set; }
    }
}
