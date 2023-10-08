using System.ComponentModel.DataAnnotations;

namespace api.cms.Models.Entity
{
    public class Statistics
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [StringLength(200)]
        public string? Image { get; set; }
        [StringLength(20)]
        public string? Key1 { get; set; }
        public int? Value1 { get; set; }
        [StringLength(20)]
        public string? IconName1 { get; set; }
        [StringLength(20)]
        public string? Key2 { get; set; }
        public int? Value2 { get; set; }
        [StringLength(20)]
        public string? IconName2 { get; set; }
        [StringLength(20)]
        public string? Key3 { get; set; }
        public int? Value3 { get; set; }
        [StringLength(20)]
        public string? IconName3 { get; set; }
        [StringLength(20)]
        public string? Key4 { get; set; }
        public int? Value4 { get; set; }
        [StringLength(20)]
        public string? IconName4 { get; set; }
        [StringLength(10)]
        public string ColorClass { get; set; } = string.Empty;
        [StringLength(10)]
        public string Status { get; set; } = "AKTIF";
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
