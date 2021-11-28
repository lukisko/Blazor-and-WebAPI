using Microsoft.EntityFrameworkCore;
using Entities.Model;

namespace Database
{
    public class NewAdultContext : DbContext
    {
        public DbSet<Adult> Adults {get;set;}
        public DbSet<Job> Jobs {get;set;}
        public DbSet<Person> Persons {get;set;}
        public DbSet<User> Users {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source = Database.db");
        }
        
    }
}