using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using studentfest.Models;

namespace studentfest.Data
{
    public class SqlContext: IdentityDbContext<User>
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)

        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<ResidentalAddress> ResidentalAddresses { get; set; }
        public DbSet<ContactDetails> ContactDetails { get; set; }
        public DbSet<DeliveryAddress> DeliveryAddresses { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
