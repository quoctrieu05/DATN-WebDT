using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class RAM
    {
        [Key]
        public int IdRAM { get; set; }

        public string DungLuongRAM { get; set; } = string.Empty;
        public string? MoTaRAM { get; set; }
    }
}
