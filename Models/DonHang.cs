using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class DonHang
    {
        [Key]
        public int IdDonHang { get; set; }

        public int? IdKhachHang { get; set; }           // Có thể null nếu nhân viên tạo
        public virtual KhachHang? KhachHang { get; set; }

        public int? IdNhanVien { get; set; }            // Nhân viên xử lý/nhân viên bán
        public virtual NhanVien? NhanVien { get; set; }

        public DateTime NgayDat { get; set; } = DateTime.Now;
        public string? TrangThaiDonHang { get; set; }   // Pending, Processing, Shipped,...
        public string? DiaChiGiaoHang { get; set; }
        public string? TrangThaiHoaDon { get; set; }
        public string? GhiChu { get; set; }
        public string? PhuongThucThanhToan { get; set; }

        public virtual ICollection<DonHangChiTiet> DonHangChiTiets { get; set; } = new List<DonHangChiTiet>();
        public virtual HoaDon? HoaDon { get; set; }
    }
}
