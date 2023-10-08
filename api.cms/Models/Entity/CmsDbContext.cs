using Microsoft.EntityFrameworkCore;

namespace api.cms.Models.Entity
{
    public class CmsDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Referance> Referances { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Section> Sections { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=185.8.128.26;Database=harundem_db;User Id=harundem_user;Password=2Aa29d36.+-a;TrustServerCertificate=True");
        }
    }
}
