using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("terrace_ter")]
[Index("IdSteTer", Name = "id_ste_ter")]
public partial class TerraceTer
{
    [Key]
    [Column("id_ter")]
    public int IdTer { get; set; }

    [Column("id_ste_ter")]
    public int? IdSteTer { get; set; }

    [Column("estimate_ter")]
    public int? EstimateTer { get; set; }

    [Column("structure_ter")]
    public int? StructureTer { get; set; }

    [Column("type_ter")]
    [StringLength(32)]
    [Unicode(false)]
    public string? TypeTer { get; set; }

    [Column("specfig_ter")]
    public int? SpecfigTer { get; set; }

    [Column("length_ter", TypeName = "decimal(38, 0)")]
    public decimal? LengthTer { get; set; }

    [Column("is_sodmulch_ter")]
    public int? IsSodmulchTer { get; set; }

    [Column("is_sod_ter")]
    public int? IsSodTer { get; set; }
}
