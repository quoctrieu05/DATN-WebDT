using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class ManHinh
    {
        [Key]
        public int IdManHinh { get; set; }

        public string CongNgheManHinh { get; set; } = string.Empty;
        public string KichThuocManHinh { get; set; } = string.Empty;
        public string DoPhanGiai { get; set; } = string.Empty;
        public string? TinhNangManHinh { get; set; }
        public string? MoTaManHinh { get; set; }
    }
}
