using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class Pin
    {
        [Key]
        public int IdPin { get; set; }

        public string LoaiPin { get; set; } = string.Empty;
        public string DungLuongPin { get; set; } = string.Empty;
        public string? CongNgheSac { get; set; }
        public string? MoTaPin { get; set; }
    }
}
