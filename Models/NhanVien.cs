using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class NhanVien
    {
        [Key]
        public int IdNhanVien { get; set; }

        [Required]
        public string HoTenNhanVien { get; set; } = string.Empty;

        public string? ChucVu { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }           // Hash nếu cần
        public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>(); // Liên kết với hóa đơn/đơn hàng
        public virtual TaiKhoan? TaiKhoan { get; set; }
    }
}
