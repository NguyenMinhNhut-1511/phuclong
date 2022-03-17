namespace QuanLyPhucLong
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietTopping")]
    public partial class ChiTietTopping
    {
        [Key]
        public int STT { get; set; }

        public int? ID { get; set; }

        [StringLength(5)]
        public string maSP { get; set; }

        public int? SL { get; set; }

        public virtual CTPhieuXuat ChiTietPhieuXuat { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
