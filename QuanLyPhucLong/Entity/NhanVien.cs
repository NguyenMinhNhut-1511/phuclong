namespace QuanLyPhucLong
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            PhieuXuats = new HashSet<PhieuXuat>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(15)]
        public string username { get; set; }

        [StringLength(32)]
        public string matKhau { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string hoTen { get; set; }

        [StringLength(5)]
        public string gioiTinh { get; set; }

        public DateTime? namSinh { get; set; }

        [StringLength(15)]
        public string sdt { get; set; }

        [StringLength(60)]
        public string diaChi { get; set; }

        [StringLength(10)]
        public string chucvu { get; set; }

        public int trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuat> PhieuXuats { get; set; }
    }
}
