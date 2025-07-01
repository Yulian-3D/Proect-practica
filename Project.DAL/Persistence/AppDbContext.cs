using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.DAL.Entities;
using Project.DAL.Persistence.Seeding;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace Project.DAL.Persistence
{
    public class AppDbContext : IdentityDbContext<User, UserRole, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemTrade> ItemTrades { get; set; }
        public DbSet<UserItem> UserItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<int>>().HasNoKey();
            modelBuilder.Entity<IdentityUserRole<int>>().HasKey(r => new { r.UserId, r.RoleId });
            modelBuilder.Entity<IdentityUserToken<int>>().HasNoKey();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        public void SeedData()
        {
            if (!Items.Any())
            {
                ItemsSeeding.SeedingInit();
                Items.AddRange(ItemsSeeding.Items);
                ItemTrades.AddRange(ItemsSeeding.ItemTrades);
                UserItems.AddRange(ItemsSeeding.UserItems);

                SaveChanges();
            }
        }
    }
}
