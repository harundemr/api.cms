using Microsoft.EntityFrameworkCore;

namespace api.cms.Models.Entity
{
    public class CmsDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=185.8.128.26;Database=harundem_db;User Id=harundem_user;Password=2Aa29d36.+-a;TrustServerCertificate=True");
        }
    }
}
