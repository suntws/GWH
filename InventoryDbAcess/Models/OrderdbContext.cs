using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace InventoryApplication.Models;

public partial class OrderdbContext : DbContext
{
    public OrderdbContext()
    {
    }

    public OrderdbContext(DbContextOptions<OrderdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<RimProcessIdDetail> RimProcessIdDetails { get; set; }


    //sp
    public async Task<List<RimProcessIdDetail>> GetBarcodeFromStoredProcedureAsync(string barcode)
    {
        var barcodeParm = new SqlParameter("@Barcode", barcode);

        return await RimProcessIdDetails.FromSqlRaw("EXEC SP_CHK_RimBarcode @Barcode", barcodeParm)
            .ToListAsync();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=orderdb;User Id=sa;Password=abcd@abcd;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<RimProcessIdDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Rim_ProcessID_Details");

            entity.Property(e => e.Angle).HasMaxLength(20);
            entity.Property(e => e.Boredia).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DiscOffSet).HasMaxLength(20);
            entity.Property(e => e.DiscThickness).HasMaxLength(20);
            entity.Property(e => e.DwgContentType).HasMaxLength(100);
            entity.Property(e => e.DwgName).HasMaxLength(100);
            entity.Property(e => e.Edcno)
                .HasMaxLength(20)
                .HasColumnName("EDCNO");
            entity.Property(e => e.Fhdia)
                .HasMaxLength(20)
                .HasColumnName("FHdia");
            entity.Property(e => e.Fhpcd)
                .HasMaxLength(20)
                .HasColumnName("FHpcd");
            entity.Property(e => e.Fhtype)
                .HasMaxLength(20)
                .HasColumnName("FHType");
            entity.Property(e => e.Mhdia)
                .HasMaxLength(20)
                .HasColumnName("MHdia");
            entity.Property(e => e.Mhpcd)
                .HasMaxLength(20)
                .HasColumnName("MHpcd");
            entity.Property(e => e.Mhtype)
                .HasMaxLength(30)
                .HasColumnName("MHtype");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NoOfFh)
                .HasMaxLength(20)
                .HasColumnName("NoOfFH");
            entity.Property(e => e.NoOfMh)
                .HasMaxLength(20)
                .HasColumnName("NoOfMH");
            entity.Property(e => e.NoOfPiece).HasMaxLength(20);
            entity.Property(e => e.PaintingColor).HasMaxLength(30);
            entity.Property(e => e.Piloted).HasMaxLength(20);
            entity.Property(e => e.Radius).HasMaxLength(20);
            entity.Property(e => e.RevisionReason)
                .HasMaxLength(100)
                .HasColumnName("revision_reason");
            entity.Property(e => e.RimSize).HasMaxLength(20);
            entity.Property(e => e.RimType).HasMaxLength(20);
            entity.Property(e => e.RimWt).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TyreCategory).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(20);
            entity.Property(e => e.WallThickness).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
