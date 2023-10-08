using System.ComponentModel.DataAnnotations;

namespace api.cms.Models.Entity
{
    public class Gallery
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<Image>? Images { get; set; }
        [StringLength(10)]
        public string Status { get; set; } = "AKTIF";
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
