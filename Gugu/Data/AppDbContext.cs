using Gugu.Data.Base;
using Gugu.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Gugu.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>().HasKey(am => new
            {
                am.OrderId,
                am.ProductId
            });

            modelBuilder.Entity<OrderItem>().HasOne(m => m.Product).WithMany(am => am.OrderItems).HasForeignKey(m => m.ProductId);
            modelBuilder.Entity<OrderItem>().HasOne(m => m.Order).WithMany(am => am.OrderItems).HasForeignKey(m => m.OrderId);

            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
       
    }
}
