using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class GioHang
    {
        [Key]
        public int IdGioHang { get; set; }

        public int IdKhachHang { get; set; }
        public virtual KhachHang? KhachHang { get; set; }

        public DateTime? NgayTao { get; set; } = DateTime.Now;
        public string? TrangThai { get; set; } = "Active";

        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; } = new List<GioHangChiTiet>();
    }
}
