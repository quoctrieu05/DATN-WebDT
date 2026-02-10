using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class GioHangChiTiet
    {
        [Key]
        public int IdGioHangChiTiet { get; set; }

        public int IdGioHang { get; set; }
        public virtual GioHang? GioHang { get; set; }

        public int IdModelSanPham { get; set; }
        public virtual SanPhamChiTiet? SanPhamCT { get; set; }

        public int SoLuong { get; set; }
    }
}
