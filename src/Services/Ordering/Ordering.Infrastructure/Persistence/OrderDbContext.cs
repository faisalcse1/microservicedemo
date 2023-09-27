using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Models;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
        }

        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            await OrderContextSeed.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Order> Orders { get; set; }

    }
}
