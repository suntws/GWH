using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace InventoryDbAcess.Models;

public partial class TtsdbContext : DbContext
{
    public TtsdbContext()
    {
    }

    public TtsdbContext(DbContextOptions<TtsdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PriceUserMaster> PriceUserMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=ttsdb;User Id=sa;Password=abcd@abcd;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<PriceUserMaster>(entity =>
        {
            entity.HasKey(e => e.PuserId).HasName("PK__PriceUse__2DC286221920BF5C");

            entity.ToTable("PriceUserMaster");

            entity.Property(e => e.PuserId).HasColumnName("PUserID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PemailId)
                .HasMaxLength(100)
                .HasColumnName("PEmailID");
            entity.Property(e => e.Ppassword)
                .HasMaxLength(50)
                .HasColumnName("PPassword");
            entity.Property(e => e.PuserName)
                .HasMaxLength(100)
                .HasColumnName("PUserName");
            entity.Property(e => e.UserChannel).HasMaxLength(10);
            entity.Property(e => e.UserDepartment).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserType).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
