using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OnTap3.Models;

namespace OnTap3.Data;

public partial class OnTap3Net1021Context : DbContext
{
    public OnTap3Net1021Context()
    {
    }

    public OnTap3Net1021Context(DbContextOptions<OnTap3Net1021Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhongBan> PhongBans { get; set; }

    public virtual DbSet<VaiTro> VaiTros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=np:\\\\.\\pipe\\LOCALDB#E5E7E6E0\\tsql\\query;Database=OnTap3_NET1021");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__77B2CA47E4BFBFCD");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNhanVien).ValueGeneratedNever();
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.SoCmndCccd)
                .HasMaxLength(20)
                .HasColumnName("SoCMND_CCCD");

            entity.HasOne(d => d.MaPhongBanNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaPhongBan)
                .HasConstraintName("FK__NhanVien__MaPhon__2B3F6F97");

            entity.HasOne(d => d.MaVaiTroNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaVaiTro)
                .HasConstraintName("FK__NhanVien__MaVaiT__2A4B4B5E");
        });

        modelBuilder.Entity<PhongBan>(entity =>
        {
            entity.HasKey(e => e.MaPhongBan).HasName("PK__PhongBan__D0910CC8E8811A33");

            entity.ToTable("PhongBan");

            entity.Property(e => e.MaPhongBan).ValueGeneratedNever();
            entity.Property(e => e.TenPhongBan).HasMaxLength(100);
            entity.Property(e => e.TruongPhong).HasMaxLength(100);
        });

        modelBuilder.Entity<VaiTro>(entity =>
        {
            entity.HasKey(e => e.MaVaiTro).HasName("PK__VaiTro__C24C41CF1B618D1B");

            entity.ToTable("VaiTro");

            entity.Property(e => e.MaVaiTro).ValueGeneratedNever();
            entity.Property(e => e.TenVaiTro).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
