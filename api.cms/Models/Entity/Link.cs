using System.ComponentModel.DataAnnotations;

namespace api.cms.Models.Entity
{
    public class Link
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Key { get; set; } = string.Empty;
        [StringLength(400)]
        public string Value { get; set; } = string.Empty;
        [StringLength(20)]
        public string IconName { get; set; } = string.Empty;
        [StringLength(10)]
        public string ColorClass { get; set; } = string.Empty;
        [StringLength(10)]
        public string Status { get; set; } = "AKTIF";
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    } 
}
