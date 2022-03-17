namespace QuanLyPhucLong
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietPhieuXuats = new HashSet<CTPhieuXuat>();
            ChiTietToppings = new HashSet<ChiTietTopping>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(5)]
        public string maSP { get; set; }

        [StringLength(30)]
        public string tenSP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Gia { get; set; }

        [Column(TypeName = "image")]
        public byte[] photo { get; set; }

        public int loai { get; set; }

        public int trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuXuat> ChiTietPhieuXuats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietTopping> ChiTietToppings { get; set; }
    }
}
