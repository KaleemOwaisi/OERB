using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("sample_smp")]
[Index("IdSteSmp", Name = "sampsite_idx")]
public partial class SampleSmp
{
    [Key]
    [Column("id_smp")]
    public int IdSmp { get; set; }

    [Column("sampling_smp")]
    [StringLength(40)]
    [Unicode(false)]
    public string? SamplingSmp { get; set; }

    [Column("id_ste_smp")]
    public int IdSteSmp { get; set; }

    [Column("id_prj_smp")]
    public int? IdPrjSmp { get; set; }

    [Column("type_smp")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TypeSmp { get; set; }

    [Column("container_smp")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ContainerSmp { get; set; }

    [Column("nocontainers_smp")]
    public int? NocontainersSmp { get; set; }

    [Column("preservatives_smp")]
    [StringLength(64)]
    [Unicode(false)]
    public string? PreservativesSmp { get; set; }

    [Column("driller_smp")]
    [StringLength(5)]
    [Unicode(false)]
    public string? DrillerSmp { get; set; }

    [Column("drillerasst_smp")]
    [StringLength(5)]
    [Unicode(false)]
    public string? DrillerasstSmp { get; set; }

    [Column("boringdepth_smp")]
    public int? BoringdepthSmp { get; set; }
}
