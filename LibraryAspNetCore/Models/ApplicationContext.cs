using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PublishingHouse> PublishingHouses { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookInLibrary> BooksInLibraries { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Role Admin = new Role { Id = Guid.NewGuid(), Name = "Admin" };
            Role Moder = new Role { Id = Guid.NewGuid(), Name = "Moder" };
            modelBuilder.Entity<Role>().HasData(new Role[]
            {
                Admin,
                Moder,
                new Role{Id = Guid.NewGuid(), Name="User"}
            });
            modelBuilder.Entity<User>().HasData(new User[] 
            { 
                new User{Id = Guid.NewGuid(), RoleId = Admin.Id, DateOfBirth = DateTime.Now, EMail="Admin@gmail.com", FirstName="", LastName="", Login="Admin", Password="adm"},
                new User{Id = Guid.NewGuid(), RoleId = Moder.Id, DateOfBirth = DateTime.Now, EMail="Moder@gmail.com", FirstName="", LastName="", Login="Moder", Password="mod"}
            });
        }
    }
}
