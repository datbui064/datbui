using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CEM.Data;

public partial class QlbContext : DbContext
{
    public QlbContext()
    {
    }

    public QlbContext(DbContextOptions<QlbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BaiGiang> BaiGiangs { get; set; }

    public virtual DbSet<BaoCaoNgoaiKhoa> BaoCaoNgoaiKhoas { get; set; }

    public virtual DbSet<ChuongTrinhDaoTao> ChuongTrinhDaoTaos { get; set; }

    public virtual DbSet<DangNhap> DangNhaps { get; set; }

    public virtual DbSet<DeCuong> DeCuongs { get; set; }

    public virtual DbSet<GiaoBai> GiaoBais { get; set; }

    public virtual DbSet<GiaoTrinh> GiaoTrinhs { get; set; }

    public virtual DbSet<HeThongCauhoivaBt> HeThongCauhoivaBts { get; set; }

    public virtual DbSet<HeThongGiaoAn> HeThongGiaoAns { get; set; }

    public virtual DbSet<KeHoachThucHienBiaGiang> KeHoachThucHienBiaGiangs { get; set; }

    public virtual DbSet<NganHangCauHoi> NganHangCauHois { get; set; }

    public virtual DbSet<Qd> Qds { get; set; }

    public virtual DbSet<TaiLieuCtngoaiKhoa> TaiLieuCtngoaiKhoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Kiểm tra xem options đã được cấu hình chưa
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=QLB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=QLB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaiGiang>(entity =>
        {
            entity.ToTable("BaiGiang");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TenBaiGiang).HasMaxLength(500);

            entity.HasOne(d => d.SoQuyetDinhNavigation).WithMany(p => p.BaiGiangs)
                .HasForeignKey(d => d.SoQuyetDinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BaiGiang_QD");
        });

        modelBuilder.Entity<BaoCaoNgoaiKhoa>(entity =>
        {
            entity.ToTable("BaoCaoNgoaiKhoa");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LoaiBaoCao).HasMaxLength(100);
            entity.Property(e => e.MoTaBaoCao).HasMaxLength(100);
            entity.Property(e => e.Ten).HasMaxLength(100);

            entity.HasOne(d => d.TenNavigation).WithMany(p => p.BaoCaoNgoaiKhoas)
                .HasForeignKey(d => d.Ten)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BaoCaoNgoaiKhoa_ChuongTrinhDaoTao");
        });

        modelBuilder.Entity<ChuongTrinhDaoTao>(entity =>
        {
            entity.HasKey(e => e.Ten);

            entity.ToTable("ChuongTrinhDaoTao");

            entity.Property(e => e.Ten).HasMaxLength(100);
            entity.Property(e => e.MaNganhDaoTao).HasMaxLength(500);
            entity.Property(e => e.YeuCauDauRa).HasMaxLength(50);
        });

        modelBuilder.Entity<DangNhap>(entity =>
        {
            entity.ToTable("DangNhap");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Mk)
                .HasMaxLength(500)
                .HasColumnName("MK");
            entity.Property(e => e.TenDn)
                .HasMaxLength(500)
                .HasColumnName("TenDN");
        });

        modelBuilder.Entity<DeCuong>(entity =>
        {
            entity.ToTable("DeCuong");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NoiDungDaoTao).HasMaxLength(500);
            entity.Property(e => e.Ten).HasMaxLength(100);

            entity.HasOne(d => d.TenNavigation).WithMany(p => p.DeCuongs)
                .HasForeignKey(d => d.Ten)
                .HasConstraintName("FK_DeCuong_ChuongTrinhDaoTao");
        });

        modelBuilder.Entity<GiaoBai>(entity =>
        {
            entity.ToTable("GiaoBai");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.SoQuyetDinhNavigation).WithMany(p => p.GiaoBais)
                .HasForeignKey(d => d.SoQuyetDinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GiaoBai_QD");
        });

        modelBuilder.Entity<GiaoTrinh>(entity =>
        {
            entity.ToTable("GiaoTrinh");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NamXbgt).HasColumnName("NamXBGT");
            entity.Property(e => e.TacGiaGiaoTrinh).HasMaxLength(100);
            entity.Property(e => e.Ten).HasMaxLength(100);
            entity.Property(e => e.TenGiaoTrinh).HasMaxLength(100);

            entity.HasOne(d => d.TenNavigation).WithMany(p => p.GiaoTrinhs)
                .HasForeignKey(d => d.Ten)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GiaoTrinh_ChuongTrinhDaoTao");
        });

        modelBuilder.Entity<HeThongCauhoivaBt>(entity =>
        {
            entity.ToTable("HeThongCauhoivaBT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DapAn).HasMaxLength(100);
            entity.Property(e => e.LoaiCauHoi).HasMaxLength(100);
            entity.Property(e => e.NdCauHoi).HasMaxLength(100);
            entity.Property(e => e.Ten).HasMaxLength(100);

            entity.HasOne(d => d.TenNavigation).WithMany(p => p.HeThongCauhoivaBts)
                .HasForeignKey(d => d.Ten)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HeThongCauhoivaBT_ChuongTrinhDaoTao");
        });

        modelBuilder.Entity<HeThongGiaoAn>(entity =>
        {
            entity.ToTable("HeThongGiaoAn");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LoaiGiaoAn).HasMaxLength(100);
            entity.Property(e => e.NdGiaoAn).HasMaxLength(100);
            entity.Property(e => e.Ten).HasMaxLength(100);

            entity.HasOne(d => d.TenNavigation).WithMany(p => p.HeThongGiaoAns)
                .HasForeignKey(d => d.Ten)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HeThongGiaoAn_ChuongTrinhDaoTao");
        });

        modelBuilder.Entity<KeHoachThucHienBiaGiang>(entity =>
        {
            entity.ToTable("KeHoachThucHienBiaGiang");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LoaiKeHoach).HasMaxLength(100);
            entity.Property(e => e.NdkeHoach)
                .HasMaxLength(100)
                .HasColumnName("NDKeHoach");
            entity.Property(e => e.Ten).HasMaxLength(100);

            entity.HasOne(d => d.TenNavigation).WithMany(p => p.KeHoachThucHienBiaGiangs)
                .HasForeignKey(d => d.Ten)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KeHoachThucHienBiaGiang_ChuongTrinhDaoTao");
        });

        modelBuilder.Entity<NganHangCauHoi>(entity =>
        {
            entity.ToTable("NganHangCauHoi");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DapAn).HasMaxLength(100);
            entity.Property(e => e.NdCauHoi).HasMaxLength(100);
            entity.Property(e => e.Ten).HasMaxLength(100);

            entity.HasOne(d => d.TenNavigation).WithMany(p => p.NganHangCauHois)
                .HasForeignKey(d => d.Ten)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NganHangCauHoi_ChuongTrinhDaoTao");
        });

        modelBuilder.Entity<Qd>(entity =>
        {
            entity.ToTable("QD");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AiKy).HasMaxLength(50);
            entity.Property(e => e.File).HasColumnName("file");
        });

        modelBuilder.Entity<TaiLieuCtngoaiKhoa>(entity =>
        {
            entity.ToTable("TaiLieuCTNGoaiKhoa");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TacGia).HasMaxLength(100);
            entity.Property(e => e.Ten).HasMaxLength(100);
            entity.Property(e => e.TenTaiLieu).HasMaxLength(100);

            entity.HasOne(d => d.TenNavigation).WithMany(p => p.TaiLieuCtngoaiKhoas)
                .HasForeignKey(d => d.Ten)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaiLieuCTNGoaiKhoa_ChuongTrinhDaoTao");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
