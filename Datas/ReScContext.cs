using Microsoft.EntityFrameworkCore;

namespace ReSchedule
{
    public class ReScContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tugas> listTugas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;initial Catalog=DB_ReSc;Integrated Security=True");
        }
    }
}
