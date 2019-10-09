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
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetailse> OrderDetailses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        //public DbSet<Cart> Cart { get; set; }
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
            foreach (string name in subject) modelBuilder.Entity<Subject>().HasData(new Subject { Id = Guid.NewGuid(), Name = name });
            foreach (string name in authors) modelBuilder.Entity<Author>().HasData(new Author{ Id = Guid.NewGuid(), Name = name });
            foreach (string name in publishingHouse) modelBuilder.Entity<PublishingHouse>().HasData(new PublishingHouse{ Id = Guid.NewGuid(), Name = name });
            modelBuilder.Entity<Library>().HasData(new Library[] 
            { 
                new Library{ Id = Guid.NewGuid(), Address = "Random Addres1", Name="Пушкинская библиотека", Phone = "2158484257" },
                new Library{ Id = Guid.NewGuid(), Address = "Random Addres2", Name="Детская библиотека", Phone = "88881584257" },
                new Library{ Id = Guid.NewGuid(), Address = "Random Addres3", Name="Новая библиотека", Phone = "9988484257" }
            });
            base.OnModelCreating(modelBuilder);
            
        }
        string[] authors = new string[]
        {
            "Лев Толстой",
            "Федор Достоевский",
            "Николай Гоголь",
            "Иван Бунин",
            "Александр Пушкин",
            "Антон Чехов",
            "Михаил Булгаков",
            "Владимир Набоков"
        };
        string[] subject = new string[]
        {
            "Фэнтези",
            "Женский роман",
            "Детективы – из российской жизни",
            "Кулинария",
            "Книги для детей – чем больше картинок, тем лучше",
            "Учебная и образовательная литература, литература по саморазвитию",
            "Бизнес-книга",
            "Эзотерика",
            "Мистический роман",
            "Патриотические и псевдоисторические романы"
        };
        string[] publishingHouse = new string[]
        {
            "Новое литературное обозрение",
            "Новый мир",
            "Октябрь",
            "Урал",
            "Арион",
            "Воздух",
            "Волга",
            "Дети Ра"
        };
        string[] bookName = new string[]
        {
            "Вой­на и мир",
            "Улисс",
            "1984",
            "Лоли­та",
            "Шум и ярость",
            "Неви­дим­ка",
            "К мая­ку",
            "Илли­а­да и Одис­сея",
            "Гор­дость и пред­убеж­де­ние",
            "Боже­ствен­ная коме­дия",
            "Кен­тер­бе­рий­ские рас­ска­зы",
            "Путе­ше­ст­вия Гул­ли­ве­ра",
            "Мид­дл­марч",
            "Рас­пад",
            "Над про­па­стью во ржи"
        };
    }
}
