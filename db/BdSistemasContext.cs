using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tela_de_Login.db;

public partial class BdSistemasContext : DbContext
{
    public BdSistemasContext()
    {
    }

    public BdSistemasContext(DbContextOptions<BdSistemasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
       

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.CdUser).HasName("PRIMARY");

            entity.ToTable("tb_user");

            entity.Property(e => e.CdUser).HasColumnName("cd_user");
            entity.Property(e => e.CdSenha)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("cd_senha");
            entity.Property(e => e.NmSetor)
                .HasMaxLength(90)
                .HasColumnName("nm_setor");
            entity.Property(e => e.NmUsario)
                .HasMaxLength(70)
                .HasColumnName("nm_usario");
            entity.Property(e => e.NmUser)
                .HasMaxLength(60)
                .HasColumnName("nm_user");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
