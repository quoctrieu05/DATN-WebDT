using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class NhomDoUong
    {
        [Key]
        public int IdNhom { get; set; }

        [Required, StringLength(100)]
        public string TenNhom { get; set; } = string.Empty;

        public string? MoTa { get; set; }
        public string? TrangThaiNhom { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();

    }
}
