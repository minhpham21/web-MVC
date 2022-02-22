using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QLCT.DAL.Models
{
    public partial class QuanLyChiTieuContext : DbContext
    {
        public QuanLyChiTieuContext()
        {
        }

        public QuanLyChiTieuContext(DbContextOptions<QuanLyChiTieuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTieu> ChiTieu { get; set; }
        public virtual DbSet<NoiDung> NoiDung { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<ThongKeChiTieu> ThongKeChiTieu { get; set; }
        public virtual DbSet<ThongKeThuNhap> ThongKeThuNhap { get; set; }
        public virtual DbSet<ThongTinTk> ThongTinTk { get; set; }
        public virtual DbSet<ThuNhap> ThuNhap { get; set; }
        public virtual DbSet<ViewTongChi> ViewTongChi { get; set; }
        public virtual DbSet<ViewTongThu> ViewTongThu { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyChiTieu;Persist Security Info=True;User ID=sa;Password=123;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTieu>(entity =>
            {
                entity.HasKey(e => e.MaChi);

                entity.ToTable("Chi_Tieu");

                entity.Property(e => e.MaChi).ValueGeneratedNever();

                entity.Property(e => e.MaNd).HasColumnName("MaND");

                entity.Property(e => e.NgayChi).HasColumnType("date");

                entity.HasOne(d => d.MaNdNavigation)
                    .WithMany(p => p.ChiTieu)
                    .HasForeignKey(d => d.MaNd)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Chi_Tieu_Noi_Dung");
            });

            modelBuilder.Entity<NoiDung>(entity =>
            {
                entity.HasKey(e => e.MaNd);

                entity.ToTable("Noi_Dung");

                entity.Property(e => e.MaNd)
                    .HasColumnName("MaND")
                    .ValueGeneratedNever();

                entity.Property(e => e.TenNd)
                    .HasColumnName("TenND")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("Tai_Khoan");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MatKhauTk)
                    .IsRequired()
                    .HasColumnName("MatKhauTK")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TenTk)
                    .IsRequired()
                    .HasColumnName("TenTK")
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ThongKeChiTieu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Thong_Ke_Chi_Tieu");

                entity.HasOne(d => d.MaChiNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaChi)
                    .HasConstraintName("FK_Thong_Ke_Chi_Tieu_Chi_Tieu");

                entity.HasOne(d => d.MaTkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaTk)
                    .HasConstraintName("FK_Thong_Ke_Chi_Tieu_Thong_TIn_TK");
            });

            modelBuilder.Entity<ThongKeThuNhap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Thong_Ke_Thu_Nhap");

                entity.Property(e => e.MaTk).HasColumnName("MaTK");

                entity.HasOne(d => d.MaThuNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaThu)
                    .HasConstraintName("FK_Thong_Ke_Thu_Nhap_Thu_Nhap");

                entity.HasOne(d => d.MaTkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaTk)
                    .HasConstraintName("FK_Thong_Ke_Thu_Nhap_Thong_TIn_TK");
            });

            modelBuilder.Entity<ThongTinTk>(entity =>
            {
                entity.HasKey(e => e.MaTk);

                entity.ToTable("Thong_TIn_TK");

                entity.Property(e => e.MaTk)
                    .HasColumnName("MaTK")
                    .ValueGeneratedNever();

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.MaId).HasColumnName("MaID");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.QueQuan).HasMaxLength(50);

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.ThongTinTk)
                    .HasForeignKey(d => d.MaId)
                    .HasConstraintName("FK_Thong_TIn_TK_Tai_Khoan");
            });

            modelBuilder.Entity<ThuNhap>(entity =>
            {
                entity.HasKey(e => e.MaThu);

                entity.ToTable("Thu_Nhap");

                entity.Property(e => e.MaThu).ValueGeneratedNever();

                entity.Property(e => e.MaNd).HasColumnName("MaND");

                entity.Property(e => e.NgayThu).HasColumnType("date");

                entity.HasOne(d => d.MaNdNavigation)
                    .WithMany(p => p.ThuNhap)
                    .HasForeignKey(d => d.MaNd)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Thu_Nhap_Noi_Dung");
            });

            modelBuilder.Entity<ViewTongChi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TongChi");

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.NgayChi).HasColumnType("date");

                entity.Property(e => e.TenNd)
                    .HasColumnName("TenND")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewTongThu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TongThu");

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.NgayThu).HasColumnType("date");

                entity.Property(e => e.TenNd)
                    .HasColumnName("TenND")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
