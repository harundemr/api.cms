using System.ComponentModel.DataAnnotations;

namespace api.cms.Models.Entity
{
    public class Image
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [StringLength(200)]
        public string Url { get; set; } = string.Empty;
        [StringLength(10)]
        public string Status { get; set; } = "AKTIF"; 
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
