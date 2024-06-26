using Microsoft.EntityFrameworkCore;

namespace Crawl.Data
{
    public class AddressContext : DbContext
    {
        public AddressContext(DbContextOptions<AddressContext> options) : base(options) { }

        #region DbSet
        public DbSet<District>? District {  get; set; }
        public DbSet<Province>? Province { get; set; }
        public DbSet<Ward>? Ward { get; set; }
        #endregion
    }
}
