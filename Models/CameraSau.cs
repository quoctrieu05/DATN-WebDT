using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class CameraSau
    {
        [Key]
        public int IdCameraSau { get; set; }

        public string DoPhanGiaiCameraSau { get; set; } = string.Empty;
        public string? SoLuongOngKinh { get; set; }
        public string? QuayVideoCameraSau { get; set; }
        public string? MoTaCameraSau { get; set; }
    }
}
