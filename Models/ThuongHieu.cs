using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class ThuongHieu
    {
        [Key]
        public int IdThuongHieu { get; set; }

        [Required, StringLength(100)]
        public string TenThuongHieu { get; set; } = string.Empty;

        public string? MoTa { get; set; }
        public string? TrangThaiThuongHieu { get; set; } 
    }
}
