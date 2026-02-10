using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class DiaChi
    {
        [Key]
        public int Id { get; set; }

        public int? IdKhachHang { get; set; }
        public virtual KhachHang? KhachHang { get; set; }

        public string TenNguoiNhan { get; set; } = string.Empty;
        public string SoDienThoaiNguoiNhan { get; set; } = string.Empty;
        public string ThanhPho { get; set; } = string.Empty;
        public string QuanHuyen { get; set; } = string.Empty;
        public string PhuongXa { get; set; } = string.Empty;
        public string DiaChiChiTiet { get; set; } = string.Empty;
        public string? TrangThai { get; set; }
    }
}
