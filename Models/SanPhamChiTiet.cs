using NuGet.Protocol;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;

namespace DATN_WebDT.Models
{
    public class SanPhamChiTiet
    {
        [Key]
        public int IdSanPhamChiTiet { get; set; }

        [Required]
        public string TenModel { get; set; } = string.Empty;

        public int IdSanPham { get; set; }              // FK đến SanPham (nếu có nhiều model cho 1 sp)
        public virtual SanPham? SanPham { get; set; }
        public string? TenBienThe { get; set; } 

        public string? SizeCoc { get; set; }
        public string? DoNgot { get; set; }
        public string? Doda { get; set; }

        public string? GiaModel { get; set; }           
        public string? TrangThai { get; set; }
        public ICollection<AnhSanPham> AnhSanPhams { get; set; } = new List<AnhSanPham>();
        public ICollection<GioHangChiTiet> GioHangChiTiets { get; set; } = new List<GioHangChiTiet>();
        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; } = new List<DonHangChiTiet>();
        public virtual ICollection<SanPhamChiTiet_Topping> SanPhamChiTiet_Toppings { get; set; } = new List<SanPhamChiTiet_Topping>();
        public virtual ICollection<ChiTietCongThuc> CTCTs { get; set; } = new List<ChiTietCongThuc>();

    }
}
