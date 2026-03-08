using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class NguyenLieu
    {
        [Key]
        public int?  IdNguyenLieu { get; set; }
        public string? TenNguyenLieu { get; set; }
        public string? DonVi { get; set; }
        public decimal? GiaNhap { get; set; }
        public int? SoLuongTon { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string? NhaCungCap { get; set; }
        public virtual ICollection<TonKho> TonKhos { get; set; } = new List<TonKho>();
        public virtual ICollection<ChiTietCongThuc> CTCTs { get; set; } = new List<ChiTietCongThuc>();
    }
}
