using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("soil_sl")]
[Index("IdSmpSl", Name = "sampkey_idx")]
public partial class SoilSl
{
    [Key]
    [Column("id_sl")]
    public int IdSl { get; set; }

    [Column("boringid_sl")]
    [StringLength(8)]
    [Unicode(false)]
    public string? BoringidSl { get; set; }

    [Column("id_smp_sl")]
    public int IdSmpSl { get; set; }

    [Column("date_sl")]
    [StringLength(16)]
    [Unicode(false)]
    public string? DateSl { get; set; }

    [Column("time_sl")]
    [StringLength(16)]
    [Unicode(false)]
    public string? TimeSl { get; set; }

    [Column("location_sl")]
    [StringLength(32)]
    [Unicode(false)]
    public string? LocationSl { get; set; }

    [Column("surface_sl")]
    [StringLength(32)]
    [Unicode(false)]
    public string? SurfaceSl { get; set; }

    [Column("boringdepth_sl")]
    [StringLength(12)]
    [Unicode(false)]
    public string? BoringdepthSl { get; set; }

    [Column("log_sl")]
    [Unicode(false)]
    public string LogSl { get; set; } = null!;
}
