using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class HoaDon
    {
        [Key]
        public int IdHoaDon { get; set; }

        public int? IdKhuyenMai { get; set; }
        public virtual KhuyenMai? KhuyenMai { get; set; }

        public int? IdKhachHang { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public int? IdNhanVien { get; set; }
        public virtual NhanVien? NhanVien { get; set; }

        public decimal? TongTien { get; set; }
        public DateTime NgayLapHoaDon { get; set; } = DateTime.Now;
        public string? TrangThaiHoaDon { get; set; } = "Chưa thanh toán";

        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();
    }
}
