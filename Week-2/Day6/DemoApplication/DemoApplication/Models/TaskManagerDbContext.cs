using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DemoApplication.Models
{
    public class TaskManagerDbContext:DbContext
    {
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options)
        : base(options)
        {
        }
        public DbSet<UserInfo> userInfo { get; set; }
        public DbSet<Authentication> authentication { get; set; }
        public DbSet<Comments> comments { get; set; }   

    }
}
