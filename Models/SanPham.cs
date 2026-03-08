using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class SanPham
    {
        [Key]
        public int IdSanPham { get; set; }

        [Required]
        public string TenSanPham { get; set; } = string.Empty;

        public int IdNhomDoUong { get; set; }
        public virtual NhomDoUong? NhomDoUong { get; set; }

        public string? MoTa { get; set; }
        public decimal GiaGoc { get; set; }
        public decimal? GiaYeuThich { get; set; }   // Giá khuyến mãi
        public string? GiaGocVAT { get; set; }
        public string? TrangThaiSP { get; set; }
        public virtual ICollection<SanPhamChiTiet> ModelSanPhams { get; set; } = new List<SanPhamChiTiet>();
        public virtual ICollection<AnhSanPham> AnhSanPhams { get; set; } = new List<AnhSanPham>();
    }
}
