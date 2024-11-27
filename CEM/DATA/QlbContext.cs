using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CEM.DATA;

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

    public virtual DbSet<BaoCao> BaoCaos { get; set; }

    public virtual DbSet<CauHoi> CauHois { get; set; }

    public virtual DbSet<DeCuong> DeCuongs { get; set; }

    public virtual DbSet<KeHoachGiangDay> KeHoachGiangDays { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<PhuongTienCongCu> PhuongTienCongCus { get; set; }

    public virtual DbSet<QuyetDinh> QuyetDinhs { get; set; }

    public virtual DbSet<TaiLieuHocTap> TaiLieuHocTaps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DATBUI\\SQLEXPRESS;Initial Catalog=QLB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaiGiang>(entity =>
        {
            entity.HasKey(e => e.MaBaiGiang).HasName("PK__BaiGiang__0773C41E5D794A06");

            entity.ToTable("BaiGiang");

            entity.Property(e => e.DuongDanTep).HasMaxLength(255);
            entity.Property(e => e.TieuDe).HasMaxLength(255);

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.BaiGiangs)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__BaiGiang__MaNguo__00200768");
        });

        modelBuilder.Entity<BaoCao>(entity =>
        {
            entity.HasKey(e => e.MaBaoCao).HasName("PK__BaoCao__25A9188C4C41FD44");

            entity.ToTable("BaoCao");

            entity.Property(e => e.DuongDanTep).HasMaxLength(255);
            entity.Property(e => e.TieuDe).HasMaxLength(255);

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.BaoCaos)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__BaoCao__MaNguoiD__01142BA1");
        });

        modelBuilder.Entity<CauHoi>(entity =>
        {
            entity.HasKey(e => e.MaCauHoi).HasName("PK__CauHoi__1937D77B8C0F1781");

            entity.ToTable("CauHoi");

            entity.HasOne(d => d.MaBaiGiangNavigation).WithMany(p => p.CauHois)
                .HasForeignKey(d => d.MaBaiGiang)
                .HasConstraintName("FK__CauHoi__MaBaiGia__02084FDA");

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.CauHois)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__CauHoi__MaNguoiD__02FC7413");
        });

        modelBuilder.Entity<DeCuong>(entity =>
        {
            entity.HasKey(e => e.MaDeCuong).HasName("PK__DeCuong__A38A0F32F869B38D");

            entity.ToTable("DeCuong");

            entity.Property(e => e.DuongDanTep).HasMaxLength(255);
            entity.Property(e => e.TieuDe).HasMaxLength(255);

            entity.HasOne(d => d.MaBaiGiangNavigation).WithMany(p => p.DeCuongs)
                .HasForeignKey(d => d.MaBaiGiang)
                .HasConstraintName("FK__DeCuong__MaBaiGi__03F0984C");

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.DeCuongs)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__DeCuong__MaNguoi__04E4BC85");
        });

        modelBuilder.Entity<KeHoachGiangDay>(entity =>
        {
            entity.HasKey(e => e.MaKeHoach).HasName("PK__KeHoachG__88C5741F5232710C");

            entity.ToTable("KeHoachGiangDay");

            entity.Property(e => e.LoaiKếHoach).HasMaxLength(50);
            entity.Property(e => e.TieuDe).HasMaxLength(255);

            entity.HasOne(d => d.MaBaiGiangNavigation).WithMany(p => p.KeHoachGiangDays)
                .HasForeignKey(d => d.MaBaiGiang)
                .HasConstraintName("FK__KeHoachGi__MaBai__05D8E0BE");

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.KeHoachGiangDays)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__KeHoachGi__MaNgu__06CD04F7");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.MaNguoiDung).HasName("PK__NguoiDun__C539D762FA79E5BD");

            entity.ToTable("NguoiDung");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.HoTen).HasMaxLength(255);
            entity.Property(e => e.MatKhau).HasMaxLength(255);
            entity.Property(e => e.SoDienThoai).HasMaxLength(20);
            entity.Property(e => e.TenDangNhap).HasMaxLength(100);
            entity.Property(e => e.VaiTro).HasMaxLength(50);
        });

        modelBuilder.Entity<PhuongTienCongCu>(entity =>
        {
            entity.HasKey(e => e.MaCongCu).HasName("PK__PhuongTi__E45C205A0783D51D");

            entity.ToTable("PhuongTienCongCu");

            entity.Property(e => e.DuongDanTep).HasMaxLength(255);
            entity.Property(e => e.TenCongCu).HasMaxLength(255);

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.PhuongTienCongCus)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__PhuongTie__MaNgu__07C12930");
        });

        modelBuilder.Entity<QuyetDinh>(entity =>
        {
            entity.HasKey(e => e.MaQuyetDinh).HasName("PK__QuyetDin__3F6D3FCB919F6CA8");

            entity.ToTable("QuyetDinh");

            entity.Property(e => e.NgayBanHanh).HasColumnType("datetime");
            entity.Property(e => e.TieuDe).HasMaxLength(255);

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.QuyetDinhs)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK__QuyetDinh__MaNgu__08B54D69");
        });

        modelBuilder.Entity<TaiLieuHocTap>(entity =>
        {
            entity.HasKey(e => e.MaTaiLieu).HasName("PK__TaiLieuH__FD18A6573B4E3A40");

            entity.ToTable("TaiLieuHocTap");

            entity.Property(e => e.DuongDan).HasMaxLength(255);
            entity.Property(e => e.LoaiTaiLieu).HasMaxLength(100);
            entity.Property(e => e.NhaXuatBan).HasMaxLength(255);
            entity.Property(e => e.TacGia).HasMaxLength(255);
            entity.Property(e => e.TenTaiLieu).HasMaxLength(255);

            entity.HasOne(d => d.MaBaiGiangNavigation).WithMany(p => p.TaiLieuHocTaps)
                .HasForeignKey(d => d.MaBaiGiang)
                .HasConstraintName("FK__TaiLieuHo__MaBai__09A971A2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
