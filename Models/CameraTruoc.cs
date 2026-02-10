using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class CameraTruoc
    {
        [Key]
        public int IdCameraTruoc { get; set; }

        public string DoPhanGiaiCameraTruoc { get; set; } = string.Empty;
        public string? TinhNangCameraTruoc { get; set; }
        public string? QuayVideoCameraTruoc { get; set; }
    }
}
