using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATN_WebDT.Models
{
    public class Imei
    {
        [Key]
        public int IdImei { get; set; }
        public string MaImei { get; set; } = string.Empty;
        public string? MoTa { get; set; }
        public bool TrangThai { get; set; }

        public int IdModelSanPham { get; set; }
        public SanPhamChiTiet? SanPhamCT { get; set; } = null!;

        public BaoHanh? BaoHanh { get; set; }
    }
}
