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
      .HasOne(c => c.User)
      .WithMany(u => u.Car)
      .HasForeignKey(c => c.UserId)
       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
          .HasOne(c => c.User);
           

            modelBuilder.Entity<Order>()
          .HasOne(o => o.User)
          .WithMany(u => u.Order)
          .HasForeignKey(o => o.UserId)
          .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
          .HasOne(o => o.Car)
          .WithMany()
          .HasForeignKey(o => o.CarId)
          .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
          .HasOne(o => o.Package)
          .WithMany(p => p.Order)
          .HasForeignKey(o => o.PackageId)
          .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Payment>()
          .HasOne(p => p.User)
          .WithMany(u => u.Payment)
          .HasForeignKey(p => p.UserId)
          .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Review>()
          .HasOne(r => r.User)
          .WithMany(u => u.Review)
          .HasForeignKey(r => r.UserId)
          .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
