using System.ComponentModel.DataAnnotations.Schema;

namespace DATN_WebDT.Models
{
    public class SanPhamChiTiet_Topping
    {
        public int IdSanPhamChiTiet { get; set; }
        public SanPhamChiTiet SanPhamChiTiet { get; set; } = null!;

        public int IdTopping { get; set; }
        public Topping Topping { get; set; } = null!;

        public int SoLuong { get; set; } = 1;  // Số phần topping mặc định
        public decimal? GiaThem { get; set; }  // Giá topping lúc gắn (nếu fix, không dùng GiaTopping của Topping)
        public string? GhiChu { get; set; }
    }
}
