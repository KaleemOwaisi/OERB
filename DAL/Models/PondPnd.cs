using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("pond_pnd")]
[Index("IdStePnd", Name = "id_ste_pnd")]
public partial class PondPnd
{
    [Key]
    [Column("id_pnd")]
    public int IdPnd { get; set; }

    [Column("id_ste_pnd")]
    public int? IdStePnd { get; set; }

    [Column("type_pnd")]
    [StringLength(32)]
    [Unicode(false)]
    public string? TypePnd { get; set; }

    [Column("is_dam_pnd")]
    public int? IsDamPnd { get; set; }

    [Column("dammaterialvol_pnd")]
    public int? DammaterialvolPnd { get; set; }

    [Column("is_drawdownpipe_pnd")]
    public int? IsDrawdownpipePnd { get; set; }

    [Column("inlet_pnd")]
    [StringLength(255)]
    [Unicode(false)]
    public string? InletPnd { get; set; }

    [Column("collars_pnd")]
    public int? CollarsPnd { get; set; }

    [Column("is_divterrace_pnd")]
    public int? IsDivterracePnd { get; set; }

    [Column("numterrace_pnd")]
    public int? NumterracePnd { get; set; }

    [Column("terracevol_pnd")]
    public int? TerracevolPnd { get; set; }

    [Column("is_spillway_pnd")]
    public int? IsSpillwayPnd { get; set; }

    [Column("is_spillway2_pnd")]
    public int? IsSpillway2Pnd { get; set; }

    [Column("numspillway_pnd")]
    public int? NumspillwayPnd { get; set; }

    [Column("spillwaywidth_pnd")]
    public int? SpillwaywidthPnd { get; set; }

    [Column("spillwayelevation_pnd")]
    public int? SpillwayelevationPnd { get; set; }

    [Column("spillwayspecfig_pnd")]
    public int? SpillwayspecfigPnd { get; set; }

    [Column("spillwaywidth2_pnd")]
    public int? Spillwaywidth2Pnd { get; set; }

    [Column("spillwayelevation2_pnd")]
    public int? Spillwayelevation2Pnd { get; set; }

    [Column("is_sodmulchspill_pnd")]
    public int? IsSodmulchspillPnd { get; set; }

    [Column("is_sodspill_pnd")]
    public int? IsSodspillPnd { get; set; }

    [Column("is_coretrench_pnd")]
    public int? IsCoretrenchPnd { get; set; }

    [Column("is_solidsod_pnd")]
    public int? IsSolidsodPnd { get; set; }

    [Column("is_sodmulch_pnd")]
    public int? IsSodmulchPnd { get; set; }

    [Column("is_sodspill2_pnd")]
    public int? IsSodspill2Pnd { get; set; }

    [Column("is_sodmulchspill2_pnd")]
    public int? IsSodmulchspill2Pnd { get; set; }
}
