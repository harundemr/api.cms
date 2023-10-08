using System.ComponentModel.DataAnnotations;

namespace api.cms.Models.Entity
{
    public class Company
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [StringLength(200)]
        public string? Slogan { get; set; }
        [StringLength(20)]
        public string? PhoneNumber { get; set; }
        [StringLength(200)]
        public string? Email { get; set; }
        public string? About { get; set; }
        [StringLength(200)]
        public Image? Logo1 { get; set; }
        [StringLength(200)]
        public Image? Logo2 { get; set; }
        [StringLength(10)]
        public string Status { get; set; } = "AKTIF";
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public ICollection<Link>? Links { get; set; }
        public ICollection<Banner>? Banners { get; set; }
        public ICollection<Section>? Sections { get; set; }
        public Statistics? Statistics { get; set; }
        public ICollection<Service>? Services { get; set; }
        public ICollection<Referance>? Referances { get; set; }
        public ICollection<News>? News { get; set; }
        public Gallery? Galleries { get; set; }

    }


}
