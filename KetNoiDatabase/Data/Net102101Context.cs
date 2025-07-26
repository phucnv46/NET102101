using System;
using System.Collections.Generic;
using KetNoiDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace KetNoiDatabase.Data;

public partial class Net102101Context : DbContext
{
    public Net102101Context()
    {
    }

    public Net102101Context(DbContextOptions<Net102101Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server= np:\\\\.\\pipe\\LOCALDB#71C67569\\tsql\\query;Database=NET102101;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__77B2CA4796C7E8B7");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNhanVien).HasMaxLength(50);
            entity.Property(e => e.ChucVu).HasMaxLength(50);
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Sdt)
                .HasMaxLength(13)
                .HasColumnName("SDT");
            entity.Property(e => e.TenNhanVien).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
