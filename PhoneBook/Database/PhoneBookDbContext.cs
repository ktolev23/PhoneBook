using Microsoft.EntityFrameworkCore;
using PhoneBook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Database
{
    public class PhoneBookDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<UserToContact> UserToContacts { get; set; }
        public PhoneBookDbContext() 
        {
            Users = this.Set<User>();
            Contacts = this.Set<Contact>();
            UserToContacts = this.Set<UserToContact>();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PhoneBookDb;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Username = "ktolev",
                    Password = "0000",
                    FirstName = "Konstantin",
                    LastName = "Tolev"
                });

        }
    }
}
