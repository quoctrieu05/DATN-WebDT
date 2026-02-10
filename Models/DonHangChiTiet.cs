using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class DonHangChiTiet
    {
        [Key]
        public int IdDonHangChiTiet { get; set; }

        public int IdDonHang { get; set; }
        public virtual DonHang? DonHang { get; set; }

        public int IdModelSanPham { get; set; }
        public virtual SanPhamChiTiet? SanPhamCT { get; set; }
        public int IdKhuyenMai { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }

        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }    
       public decimal ThanhTien { get; set; }
    }
}

