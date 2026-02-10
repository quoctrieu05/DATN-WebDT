using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;

namespace DATN_WebDT.Models
{
    public class SanPhamChiTiet
    {
        [Key]
        public int IdModelSanPham { get; set; }

        [Required]
        public string TenModel { get; set; } = string.Empty;

        public int IdSanPham { get; set; }              // FK đến SanPham (nếu có nhiều model cho 1 sp)
        public virtual SanPham? SanPham { get; set; }

        public int? IdManHinh { get; set; }
        public virtual ManHinh? ManHinh { get; set; }

        public int? IdCameraTruoc { get; set; }
        public virtual CameraTruoc? CameraTruoc { get; set; }

        public int? IdCameraSau { get; set; }
        public virtual CameraSau? CameraSau { get; set; }

        public int? IdPin { get; set; }
        public virtual Pin? Pin { get; set; }

        public int? IdRAM { get; set; }
        public virtual RAM? RAM { get; set; }

        public int? IdROM { get; set; }
        public virtual ROM? ROM { get; set; }

        public string? MauSac { get; set; }
        public string? GiaModel { get; set; }           
        public string? TrangThai { get; set; }
        public ICollection<AnhSanPham> AnhSanPhams { get; set; } = new List<AnhSanPham>();
        public ICollection<Imei> Imeis { get; set; } = new List<Imei>();
        public ICollection<GioHangChiTiet> GioHangChiTiets { get; set; } = new List<GioHangChiTiet>();
        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; } = new List<DonHangChiTiet>();
    }
}
