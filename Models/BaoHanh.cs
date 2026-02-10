using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATN_WebDT.Models
{
    public class BaoHanh
    {
        [Key]
        public int IdBaoHanh { get; set; }

        public int IdImei { get; set; }  
        public virtual Imei? Imei { get; set; }

        public int IdKhachHang { get; set; }
        public virtual KhachHang? KhachHang { get; set; }

        public DateTime NgayNhan { get; set; }          // Ngày nhận bảo hành
        public DateTime? NgayTra { get; set; }          // Ngày trả
        public string? TrangThai { get; set; }
        public string? MoTaLoi { get; set; }
        public string? XuLyPhatSinh { get; set; }
        public string? ChiPhiPhatSinh { get; set; }
    }
}
