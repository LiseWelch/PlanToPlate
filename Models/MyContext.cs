using Microsoft.EntityFrameworkCore;

namespace Project.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<User> Users {get;set;}
        public DbSet<Recipe> Recipes {get;set;}
        public DbSet<Ingriedient> Ingriedients {get;set;}
        public DbSet<RIAssoc> RIAssocs {get;set;}
        public DbSet<Week> Weeks {get;set;}
        public DbSet<Day> Days {get;set;}
        public DbSet<Breakfast> Breakfasts {get;set;}
        public DbSet<Lunch> Lunches {get;set;}
        public DbSet<Dinner> Dinners {get;set;}
        
    }
}