using Microsoft.EntityFrameworkCore;

namespace CustomerManager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<CustomerState> CustomerStates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.CustomerType)
                .WithMany(t => t.Customers)
                .HasForeignKey(c => c.CustomerTypeId);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.CustomerState)
                .WithMany(s => s.Customers)
                .HasForeignKey(c => c.CustomerStateId);
        }
    }
}
