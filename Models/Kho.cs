using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class Kho
    {
        [Key]
        public int IdKho { get; set; }

        [Required]
        public string TenKho { get; set; } = string.Empty;

        public string DiaChiKho { get; set; } = string.Empty;
        public string? DienThoaiKho { get; set; }
        public string? TrangThai { get; set; } = "Hoạt động";

        public virtual ICollection<TonKho> TonKhos { get; set; } = new List<TonKho>();
    }
}
