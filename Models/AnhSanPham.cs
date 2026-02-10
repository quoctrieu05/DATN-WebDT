using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class AnhSanPham
    {
        [Key]
        public int IdAnh { get; set; }

        public int IdModelSanPham { get; set; }
        public virtual SanPhamChiTiet? SanPhamCT { get; set; }

        public string DuongDan { get; set; } = string.Empty;
    }
}
