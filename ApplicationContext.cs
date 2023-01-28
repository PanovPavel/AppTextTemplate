using ConsoleApp27.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<TemplateMessage> TemplateMessages => Set<TemplateMessage>();
        public DbSet<Value> Values => Set<Value>();
        public DbSet<Variable> Variables => Set<Variable>();

        public ApplicationContext() {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                string connectString = getConnectionString();
                optionsBuilder.UseSqlServer(connectString);
                optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
            }
            catch(Exception ex)
            {
                optionsBuilder.UseSqlServer(connectString);
                optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            #region
            //Создание первоначальных данных в таблице
            {
                /*
                Company google = new Company("Google") { Id = 1 };
                modelBuilder.Entity<Company>().HasData(google);
                User tom = new User("Ivan", 19) { CompanyId = google.Id };
                User alice = new User("Alice", 25);
                User sam = new User("Sam", 26);
                modelBuilder.Entity<User>().HasData(tom, alice, sam);
                */
            }
            // modelBuilder.Entity<User>().Property(u => u.Id).HasDefaultValue(Guid.NewGuid());// значение по умолчанию
            {
                // включение сущностей в модель
                //modelBuilder.Entity<User>();
                //modelBuilder.Ignore<Company>(); исключение сузности из DB
                //modelBuilder.Entity<User>().Ignore(u => u.Address); исключение свойства из DB
                //modelBuilder.Entity<User>().Property("Id").HasField("id"); устанавливает выражение как свойство
                //modelBuilder.Entity<User>().HasKey(u => new { u.PassportSeria, u.PassportNumber}); составной ключ
                //modelBuilder.Entity<User>().HasAlternateKey(u => u.Passport); уникальное значение
                //modelBuilder.Entity<User>().HasIndex(u => u.Passport); задание индексов
                //Ограничение значения свойства
                //modelBuilder.Entity<User>().HasCheckConstraint("Age", "Age > 0 AND Age < 120", c => c.HasName("CK_User_Age"));
                //modelBuilder.Entity<User>().Property(b => b.Name).HasMaxLength(50);
                //Установка навигационных свойства
                //modelBuilder.Entity<User>().HasOne(u => u.Company).WithMany(c => c.Users).HasForeignKey(u => u.CompanyInfoKey);
                #endregion

            }
        }
        string getConnectionString()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appSettingsConnect.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            return connectionString;
        }
    }
}

