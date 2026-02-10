using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class ROM
    {
        [Key]
        public int IdROM { get; set; }

        public string DungLuongROM { get; set; } = string.Empty;
        public string? MoTaROM { get; set; }
    }
}
