using System.ComponentModel.DataAnnotations;

namespace DATN_WebDT.Models
{
    public class TonKho
    {
        [Key]
        public int? IdTonKho { get; set; }

        public int? IdKho { get; set; }
        public virtual Kho? Kho { get; set; }

        public int? IdNguyenLieu { get; set; }
        public virtual NguyenLieu? NguyenLieu { get; set; }

        public int? SoLuong { get; set; }
    }
}
