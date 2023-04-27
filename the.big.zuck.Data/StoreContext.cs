using the.big.zuck.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace the.big.zuck.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }

        public DbSet<Item> Items { get; set; }
    }
}