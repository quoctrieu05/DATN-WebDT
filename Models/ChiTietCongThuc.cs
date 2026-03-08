using System.ComponentModel.DataAnnotations.Schema;

namespace DATN_WebDT.Models
{
    public class ChiTietCongThuc
    {
        public int IdSanPhamChiTiet { get; set; }
        [ForeignKey("IdSanPhamChiTiet")]
        public virtual SanPhamChiTiet SanPhamChiTiet { get; set; } = null!;

        public int IdNguyenLieu { get; set; }
        [ForeignKey("IdNguyenLieu")]
        public virtual NguyenLieu NguyenLieu { get; set; } = null!;

        [Column(TypeName = "decimal(18,3)")]
        public decimal SoLuongCanDung { get; set; }  // 0.020 (kg/lít/phần)

        public string DonVi { get; set; } = "kg";  // Đồng bộ với DonVi của NguyenLieu

        // Optional: Ghi chú công thức
        public string? GhiChu { get; set; }
    }
}
