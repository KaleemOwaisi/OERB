using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("waterway_wtr")]
[Index("IdSteWtr", Name = "id_ste_wtr")]
public partial class WaterwayWtr
{
    [Key]
    [Column("id_wtr")]
    public int IdWtr { get; set; }

    [Column("id_ste_wtr")]
    public int IdSteWtr { get; set; }

    [Column("waterwayvol_wtr", TypeName = "decimal(38, 0)")]
    public decimal WaterwayvolWtr { get; set; }

    [Column("is_waterwaysod_wtr")]
    public int IsWaterwaysodWtr { get; set; }

    [Column("is_waterwaysodmulch_wtr")]
    public int IsWaterwaysodmulchWtr { get; set; }

    [Column("sodtype_wtr")]
    [StringLength(16)]
    [Unicode(false)]
    public string SodtypeWtr { get; set; } = null!;

    [Column("sod_wtr", TypeName = "decimal(38, 0)")]
    public decimal? SodWtr { get; set; }

    [Column("is_wireanchor_wtr")]
    public int IsWireanchorWtr { get; set; }

    [Column("source_wtr")]
    [StringLength(32)]
    [Unicode(false)]
    public string SourceWtr { get; set; } = null!;

    [Column("specfig_wtr")]
    public int SpecfigWtr { get; set; }

    [Column("is_riprap_wtr")]
    public int IsRiprapWtr { get; set; }

    [Column("rocktons_wtr")]
    public int RocktonsWtr { get; set; }

    [Column("is_waterwayterrace_wtr")]
    public int IsWaterwayterraceWtr { get; set; }
}
