using System;
using System.Collections.Generic;
using ChuaDeMau2.Models;
using Microsoft.EntityFrameworkCore;

namespace ChuaDeMau2.Data;

public partial class Net1021DeMau2Context : DbContext
{
    public Net1021DeMau2Context()
    {
    }

    public Net1021DeMau2Context(DbContextOptions<Net1021DeMau2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=np:\\\\.\\pipe\\LOCALDB#88181BD8\\tsql\\query;Database=NET1021_DeMau2");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__BDDEF20DB5231263");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maNhanVien");
            entity.Property(e => e.ChucVu)
                .HasMaxLength(50)
                .HasColumnName("chucVu");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(50)
                .HasColumnName("gioiTinh");
            entity.Property(e => e.TenNhanVien)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tenNhanVien");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
