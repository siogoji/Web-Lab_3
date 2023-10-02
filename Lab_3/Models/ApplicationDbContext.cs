using Microsoft.EntityFrameworkCore;

namespace Lab_3.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Trainer> Trainers { get; set; }
    }
}
