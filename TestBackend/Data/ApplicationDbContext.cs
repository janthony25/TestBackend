using Microsoft.EntityFrameworkCore;
using TestBackend.Models;

namespace TestBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<tblCustomerList> Customers { get; set; }
        public DbSet<tblIssue> Issues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblCustomerList>(entity =>
            {
                entity.HasKey(e => e.CustomerId);
                
            }
            );
                
            base.OnModelCreating(modelBuilder);

        }
    }
}
