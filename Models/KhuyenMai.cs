using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class KhuyenMai
    {
        [Key]
        public int IdKhuyenMai { get; set; }

        [Required]
        public string MaKM { get; set; } = string.Empty;

        public string? MoTaKhuyenMai { get; set; }
        public decimal? MucGiamGia { get; set; }          // %, hoặc số tiền cố định
        public bool? ApDungVoiDonHang { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string? TrangThai { get; set; } = "Active";
    }
}
