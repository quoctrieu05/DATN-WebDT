using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public enum PhuongThucThanhToan
    {
        COD,             // Thanh toán khi nhận hàng
        ChuyenKhoan,     // Chuyển khoản ngân hàng
        VNPay,
        MoMo,
        
    }
        

    public class ThanhToan
    {
        [Key]
        public int IdThanhToan { get; set; }

        public int IdHoaDon { get; set; }
        public virtual HoaDon? HoaDon { get; set; }

        public PhuongThucThanhToan HinhThuc { get; set; }
        public decimal SoTien { get; set; }
        public DateTime NgayThanhToan { get; set; } = DateTime.Now;
        public string? TrangThaiThanhToan { get; set; } = "Pending"; // Pending, Success, Failed
    }

}
