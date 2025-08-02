using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ChuaDeMau1.Models;

public partial class SachContext : DbContext
{
    public SachContext()
    {
    }

    public SachContext(DbContextOptions<SachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sach> Saches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=np:\\\\.\\pipe\\LOCALDB#FF3190D6\\tsql\\query;Database=Sach;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742D35C207C0");

            entity.ToTable("Sach");

            entity.Property(e => e.MaSach).HasMaxLength(50);
            entity.Property(e => e.DonGia).HasColumnType("money");
            entity.Property(e => e.TenSach).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
