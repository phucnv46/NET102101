using System;
using System.Collections.Generic;
using KetNoiDatabaseNhieuBang.Models;
using Microsoft.EntityFrameworkCore;

namespace KetNoiDatabaseNhieuBang.Data;

public partial class Net1021012Context : DbContext
{
    public Net1021012Context()
    {
    }

    public Net1021012Context(DbContextOptions<Net1021012Context> options)
        : base(options)
    {
    }

    public virtual DbSet<DocGium> DocGia { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<TacGium> TacGia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=np:\\\\.\\pipe\\LOCALDB#71C67569\\tsql\\query;Database=Net102101_2;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DocGium>(entity =>
        {
            entity.HasKey(e => e.MaDocGia).HasName("PK__DocGia__F165F945A8BFAC16");

            entity.HasIndex(e => e.Email, "UQ__DocGia__A9D10534180C0CF0").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.NgayDangKy).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SoDienThoai).HasMaxLength(20);
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742D1542F904");

            entity.ToTable("Sach");

            entity.HasIndex(e => e.Isbn, "UQ__Sach__447D36EAA801EA8A").IsUnique();

            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .HasColumnName("ISBN");
            entity.Property(e => e.SoLuongTonKho).HasDefaultValue(1);
            entity.Property(e => e.TieuDe).HasMaxLength(255);

            entity.HasOne(d => d.MaTacGiaNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.MaTacGia)
                .HasConstraintName("FK__Sach__MaTacGia__286302EC");
        });

        modelBuilder.Entity<TacGium>(entity =>
        {
            entity.HasKey(e => e.MaTacGia).HasName("PK__TacGia__F24E67562AE9DC79");

            entity.Property(e => e.HoTen).HasMaxLength(500);
            entity.Property(e => e.QuocTich).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
