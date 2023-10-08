using System.ComponentModel.DataAnnotations;

namespace api.cms.Models.Entity
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Price { get; set; } = 0;
        public float TotalPrice { get; set; } = 0;
        public string Unit { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string Feature1 { get; set; } = string.Empty;
        public string Feature2 { get; set; } = string.Empty;
        public string Feature3 { get; set; } = string.Empty;
        public string Feature4 { get; set; } = string.Empty;
        public string Feature5 { get; set; } = string.Empty;
        public string Feature6 { get; set; } = string.Empty;
        public string ButtonName { get; set; } = string.Empty;
        public string ColorClass { get; set; } = string.Empty;
        [StringLength(10)]
        public string Status { get; set; } = "AKTIF";
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
