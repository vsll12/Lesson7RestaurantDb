using Lesson7Practice.Models;
using Microsoft.EntityFrameworkCore;


namespace Lesson7Practice.Data
{
    internal class AppDbContext : DbContext
    {
        string connectionString = "Data Source=DESKTOP-7F74UDB;Initial Catalog=NewAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Dish> dishes { get; set; }
        public DbSet<Ingredient> ingredients { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Restaurant> restaurants { get; set; }
        public DbSet<MediaMenu> mediaMenus { get; set; }
        public DbSet<MediaUser> mediaUsers { get; set; }
        public DbSet<MediaRestaurant> mediaRestaurants { get; set; }

    }
}

