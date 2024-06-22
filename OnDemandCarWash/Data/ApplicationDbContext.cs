using Microsoft.EntityFrameworkCore;
using OnDemandCarWash.Models;

namespace OnDemandCarWash.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Car>()
      .HasOne(c => c.user)
      .WithMany(u => u.car)
       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
          .HasOne(c => c.User);
           

            modelBuilder.Entity<Order>()
          .HasOne(o => o.user)
          .WithMany(u => u.order)
         .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
          .HasOne(o => o.car)
          .WithMany(c=>c.order)
          .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
          .HasOne(o => o.package)
          .WithMany(p => p.order)
          .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Payment>()
          .HasOne(p => p.user)
          .WithMany(u => u.payment)
          .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Review>()
          .HasOne(r => r.user)
          .WithMany(u => u.review)
          .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
