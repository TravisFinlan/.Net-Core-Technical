using Microsoft.EntityFrameworkCore;

namespace TFinlanTechnical.Models
{
    public class FinlanDBContext : DbContext 
    {
        public FinlanDBContext(DbContextOptions<FinlanDBContext> options) : base(options) { }

        public DbSet<ToDo> toDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
