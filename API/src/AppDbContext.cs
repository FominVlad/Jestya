using AuthApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
                new Group { Id = 1, GroupName = "Users" },
                new Group { Id = 2, GroupName = "Admins" });

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, GroupId = 1, RoleName = "User" },
                new Role { Id = 2, GroupId = 1, RoleName = "SuperUser" },
                new Role { Id = 3, GroupId = 2, RoleName = "Admin" },
                new Role { Id = 4, GroupId = 2, RoleName = "SuperAdmin" });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
