using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATN_WebDT.Models
{
    public class KhachHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdKhachHang { get; set; }

        public string? HoTenKhachHang { get; set; }
        public string? DiaChiKhachHang { get; set; }
        public string? SoDienThoaiKhachHang { get; set; }
        public string? EmailKhachHang { get; set; }
        public string? Password { get; set; }           // Nên hash nếu không dùng Identity
        public string? DefaultImageKhachHang { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
        public virtual TaiKhoan? TaiKhoan { get; set; } // Liên kết 1-1 hoặc 1-n
        public virtual ICollection<DiaChi> Diachi { get; set; } = new List<DiaChi>();
    }
}
