using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class HoaDonChiTiet
    {
        [Key]
        public int IdHoaDonChiTiet { get; set; }

        public int IdHoaDon { get; set; }
        public virtual HoaDon? HoaDon { get; set; }

        public int? IdModelSanPham { get; set; }
        public virtual SanPhamChiTiet? SanPhamCT { get; set; }

        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
    }
}
