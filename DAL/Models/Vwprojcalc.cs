using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("vwprojcalcs")]
public partial class Vwprojcalc
{
    [Column("id_prj")]
    public int? IdPrj { get; set; }

    [Column("sitecount")]
    public int? Sitecount { get; set; }

    [Column("status")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("estimate")]
    public int? Estimate { get; set; }

    [Column("calcbid", TypeName = "decimal(38, 0)")]
    public decimal? Calcbid { get; set; }
}
