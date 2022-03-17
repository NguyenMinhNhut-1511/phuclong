namespace QuanLyPhucLong
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXuat")]
    public partial class PhieuXuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuat()
        {
            ChiTietPhieuXuats = new HashSet<CTPhieuXuat>();
        }

        [Key]
        public int maPhieuXuat { get; set; }

        [StringLength(15)]
        public string username { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tienThu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tienTra { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? uuDai { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? thanhToan { get; set; }

        public DateTime? ngayXuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuXuat> ChiTietPhieuXuats { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
