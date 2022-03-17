namespace QuanLyPhucLong
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhieuXuat")]
    public partial class CTPhieuXuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTPhieuXuat()
        {
            ChiTietToppings = new HashSet<ChiTietTopping>();
        }

        public int ID { get; set; }

        public int? maPhieuXuat { get; set; }

        [StringLength(5)]
        public string maSP { get; set; }

        public int? soLuong { get; set; }

        public int? size { get; set; }

        public int? duong { get; set; }

        public int? da { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }

        public virtual SanPham SanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietTopping> ChiTietToppings { get; set; }
    }
}
