using System;
using System.Collections.Generic;

namespace InventoryApplication.Models;

public partial class RimProcessIdDetail
{
    public string? Edcno { get; set; }

    public string? RimSize { get; set; }

    public string? RimType { get; set; }

    public string? NoOfPiece { get; set; }

    public string? TyreCategory { get; set; }

    public string? Piloted { get; set; }

    public string? NoOfMh { get; set; }

    public string? Mhpcd { get; set; }

    public string? Mhdia { get; set; }

    public string? Mhtype { get; set; }

    public string? Radius { get; set; }

    public string? Angle { get; set; }

    public string? DiscOffSet { get; set; }

    public string? DiscThickness { get; set; }

    public string? NoOfFh { get; set; }

    public string? Fhpcd { get; set; }

    public string? Fhdia { get; set; }

    public string? Fhtype { get; set; }

    public string? Boredia { get; set; }

    public string? PaintingColor { get; set; }

    public string? WallThickness { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IdStatus { get; set; }

    public decimal? RimWt { get; set; }

    public byte[]? DwgFile { get; set; }

    public string? DwgContentType { get; set; }

    public string? DwgName { get; set; }

    public string? RevisionReason { get; set; }
}
