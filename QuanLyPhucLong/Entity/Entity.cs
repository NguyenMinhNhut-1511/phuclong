namespace QuanLyPhucLong
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }

        public virtual DbSet<CTPhieuXuat> CTPhieuXuats { get; set; }
        public virtual DbSet<ChiTietTopping> ChiTietToppings { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTPhieuXuat>()
                .Property(e => e.maSP)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietTopping>()
                .Property(e => e.maSP)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.matKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.chucvu)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.tienThu)
                .HasPrecision(10, 0);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.tienTra)
                .HasPrecision(10, 0);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.uuDai)
                .HasPrecision(3, 0);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.thanhToan)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.maSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.Gia)
                .HasPrecision(10, 0);
        }
    }
}
