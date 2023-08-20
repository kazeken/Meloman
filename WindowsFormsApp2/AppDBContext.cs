using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class AppDBContext : DbContext
    {
        public DbSet<Organizations> Organizations { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=TestBD1;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organizations>().HasData(
                new Organizations { Id = 1, Name = "LTD IVC", INN = "001122", Address = "ЖК Керемет, корп.6", Note = "Fintech" },
                new Organizations { Id = 2, Name = "JSC BCC", INN = "654321", Address = "пр.Аль-Фараби, 10", Note = "Finance" },
                new Organizations { Id = 3, Name = "JSC Halyk Bank", INN = "123456", Address = "ул.Назарбаева, 20", Note = "Finance" },
                new Organizations { Id = 4, Name = "JSC Ayt Otel", INN = "003322", Address = "ул. Желтоксан, 181", Note = "Hotel" });

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, OrganizationsId = 1, LastName = "Zhiyentay", FirstName = "Azamat", MiddleName = "Salimzhanuly", IIN = "990101200020" },
                new Employee { Id = 2, OrganizationsId = 2, LastName = "Abdulla", FirstName = "Sultan", MiddleName = "Abdulla", IIN = "890101200021" },
                new Employee { Id = 3, OrganizationsId = 2, LastName = "Kumar", FirstName = "Anil", MiddleName = "Anadan", IIN = "790101200030" },
                new Employee { Id = 4, OrganizationsId = 3, LastName = "Lexus", FirstName = "Aleksei", MiddleName = "Olegovich", IIN = "690101200001" },
                new Employee { Id = 5, OrganizationsId = 3, LastName = "Pernebayev", FirstName = "Nurzhan", MiddleName = "Abibullauly", IIN = "960306200020" },
                new Employee { Id = 6, OrganizationsId = 4, LastName = "Yertay", FirstName = "Dias", MiddleName = "Yerasuly", IIN = "900501200020" },
                new Employee { Id = 7, OrganizationsId = 4, LastName = "Ali", FirstName = "Adbi", MiddleName = "Aliyev", IIN = "000110200020" });
        }

    }
}
