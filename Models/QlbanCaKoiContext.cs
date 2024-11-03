using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KOI_Shop.Models;

public partial class QlbanCaKoiContext : DbContext
{
    public QlbanCaKoiContext()
    {
    }

    public QlbanCaKoiContext(DbContextOptions<QlbanCaKoiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TAnhCaKoi> TAnhCaKois { get; set; }

    public virtual DbSet<TCaKoi> TCaKois { get; set; }

    public virtual DbSet<TChiTietDonHang> TChiTietDonHangs { get; set; }

    public virtual DbSet<TDashboardReport> TDashboardReports { get; set; }

    public virtual DbSet<TDonHang> TDonHangs { get; set; }

    public virtual DbSet<TGiongCaKoi> TGiongCaKois { get; set; }

    public virtual DbSet<TKhachHang> TKhachHangs { get; set; }

    public virtual DbSet<TKiemTraKhangGui> TKiemTraKhangGuis { get; set; }

    public virtual DbSet<TRating> TRatings { get; set; }

    public virtual DbSet<TTrangTrai> TTrangTrais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-E0AIU1E\\SQLEXPRESS;Initial Catalog=[QLBanCaKoi];Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TAnhCaKoi>(entity =>
        {
            entity.HasKey(e => new { e.MaCaKoi, e.TenFileAnh }).HasName("PK__tAnhCaKo__6021915666F89632");

            entity.ToTable("tAnhCaKoi");

            entity.Property(e => e.TenFileAnh).HasMaxLength(255);

            entity.HasOne(d => d.MaCaKoiNavigation).WithMany(p => p.TAnhCaKois)
                .HasForeignKey(d => d.MaCaKoi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tAnhCaKoi__MaCaK__46E78A0C");
        });

        modelBuilder.Entity<TCaKoi>(entity =>
        {
            entity.HasKey(e => e.MaCaKoi).HasName("PK__tCaKoi__68C66234A4C5C2FD");

            entity.ToTable("tCaKoi");

            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.KichThuoc).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.NguonGoc).HasMaxLength(255);
            entity.Property(e => e.TinhCach).HasMaxLength(255);
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.MaGiongCaNavigation).WithMany(p => p.TCaKois)
                .HasForeignKey(d => d.MaGiongCa)
                .HasConstraintName("FK__tCaKoi__MaGiongC__3B75D760");
        });

        modelBuilder.Entity<TChiTietDonHang>(entity =>
        {
            entity.HasKey(e => new { e.MaDonHang, e.MaCaKoi }).HasName("PK__tChiTiet__4419E28EAD149A5C");

            entity.ToTable("tChiTietDonHang");

            entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaCaKoiNavigation).WithMany(p => p.TChiTietDonHangs)
                .HasForeignKey(d => d.MaCaKoi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tChiTietD__MaCaK__440B1D61");

            entity.HasOne(d => d.MaDonHangNavigation).WithMany(p => p.TChiTietDonHangs)
                .HasForeignKey(d => d.MaDonHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tChiTietD__MaDon__4316F928");
        });

        modelBuilder.Entity<TDashboardReport>(entity =>
        {
            entity.HasKey(e => e.MaReport).HasName("PK__tDashboa__D15898622BD9EE88");

            entity.ToTable("tDashboardReport");

            entity.Property(e => e.LoaiReport).HasMaxLength(50);
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
        });

        modelBuilder.Entity<TDonHang>(entity =>
        {
            entity.HasKey(e => e.MaDonHang).HasName("PK__tDonHang__129584AD116C122A");

            entity.ToTable("tDonHang");

            entity.Property(e => e.NgayDatHang).HasColumnType("datetime");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.TDonHangs)
                .HasForeignKey(d => d.MaKhachHang)
                .HasConstraintName("FK__tDonHang__MaKhac__403A8C7D");
        });

        modelBuilder.Entity<TGiongCaKoi>(entity =>
        {
            entity.HasKey(e => e.MaGiongCa).HasName("PK__tGiongCa__B47F3B95DFFE062A");

            entity.ToTable("tGiongCaKoi");

            entity.Property(e => e.TenGiongCa).HasMaxLength(255);
        });

        modelBuilder.Entity<TKhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang).HasName("PK__tKhachHa__88D2F0E53C86CB15");

            entity.ToTable("tKhachHang");

            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HoTen).HasMaxLength(255);
            entity.Property(e => e.LoaiKhachHang).HasMaxLength(50);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
        });

        modelBuilder.Entity<TKiemTraKhangGui>(entity =>
        {
            entity.HasKey(e => e.MaKiemTra).HasName("PK__tKiemTra__5274B03147A8FB4B");

            entity.ToTable("tKiemTraKhangGui");

            entity.Property(e => e.NgayKiemTra).HasColumnType("datetime");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.MaCaKoiNavigation).WithMany(p => p.TKiemTraKhangGuis)
                .HasForeignKey(d => d.MaCaKoi)
                .HasConstraintName("FK__tKiemTraK__MaCaK__4F7CD00D");

            entity.HasOne(d => d.MaKhachHangGuiNavigation).WithMany(p => p.TKiemTraKhangGuiMaKhachHangGuiNavigations)
                .HasForeignKey(d => d.MaKhachHangGui)
                .HasConstraintName("FK__tKiemTraK__MaKha__4D94879B");

            entity.HasOne(d => d.MaKhachHangNhanNavigation).WithMany(p => p.TKiemTraKhangGuiMaKhachHangNhanNavigations)
                .HasForeignKey(d => d.MaKhachHangNhan)
                .HasConstraintName("FK__tKiemTraK__MaKha__4E88ABD4");
        });

        modelBuilder.Entity<TRating>(entity =>
        {
            entity.HasKey(e => new { e.MaKhachHang, e.MaCaKoi }).HasName("PK__tRating__DE5E96C66F7313EF");

            entity.ToTable("tRating");

            entity.HasOne(d => d.MaCaKoiNavigation).WithMany(p => p.TRatings)
                .HasForeignKey(d => d.MaCaKoi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tRating__MaCaKoi__4AB81AF0");

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.TRatings)
                .HasForeignKey(d => d.MaKhachHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tRating__MaKhach__49C3F6B7");
        });

        modelBuilder.Entity<TTrangTrai>(entity =>
        {
            entity.HasKey(e => e.MaTrangTrai).HasName("PK__tTrangTr__5C7F7908D4A6C6D6");

            entity.ToTable("tTrangTrai");

            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenTrangTrai).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
