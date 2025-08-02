using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OnTapEFCore.Models;

namespace OnTapEFCore.Data;

public partial class GameNet1021Context : DbContext
{
    public GameNet1021Context()
    {
    }

    public GameNet1021Context(DbContextOptions<GameNet1021Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Game> Games { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=np:\\\\.\\pipe\\LOCALDB#SH39484E\\tsql\\query;Database=GameNET1021");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.GameId).HasName("PK__Games__2AB897DD5B851CA8");

            entity.Property(e => e.GameId).HasColumnName("GameID");
            entity.Property(e => e.Developer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Genre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
