using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class TaiKhoan
    {
        [Key]
        public int IdTaiKhoan { get; set; }

        [Required]
        public string TenDangNhap { get; set; } = string.Empty;

        public string MatKhauHash { get; set; } = string.Empty; // Nên dùng IdentityUser để hash tự động
        public string VaiTro { get; set; } = "KhachHang"; // "KhachHang", "NhanVien", "Admin"
        public int? IdKhachHang { get; set; }
        public virtual KhachHang? KhachHang { get; set; }

        public int? IdNhanVien { get; set; }
        public virtual NhanVien? NhanVien { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.Now;
        public string? TrangThai { get; set; } = "Active";
    }
}
