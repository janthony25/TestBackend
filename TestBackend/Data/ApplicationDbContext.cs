using Microsoft.EntityFrameworkCore;
using TestBackend.Models;

namespace TestBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<IssueModel> Issues { get; set; }
    }
}
