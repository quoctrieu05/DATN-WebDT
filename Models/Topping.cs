using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class Topping
    {
        [Key]
        public int? IdTopping { get; set; }
        [Required]
        public string? TenTopping { get; set; }
        public decimal? GiaTopping { get; set; }
        public string? TrangThai { get; set; }
        public virtual ICollection<SanPhamChiTiet_Topping> SanPhamChiTiet_Toppings { get; set; }
        = new List<SanPhamChiTiet_Topping>();

    }
}
