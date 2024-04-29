using Microsoft.EntityFrameworkCore;
using SystemOfTasks.Data.Map;
using SystemOfTasks.Models;

namespace SystemOfTasks.Data
{
    public class SistemaDeTarefasDBContext : DbContext
    {
        public SistemaDeTarefasDBContext(DbContextOptions<SistemaDeTarefasDBContext> options) 
        : base(options)
            { 
            }
        public DbSet<UserModel> User { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TaskMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
