using AirCraftFactory.Models;
using Microsoft.EntityFrameworkCore;

namespace AirCraftFactory.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Air> Airs { get; set; }

        public DbSet<AirType> AirTypes { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().HasKey(u => new { u.RoleId, u.UserId });
        }
    }
}
