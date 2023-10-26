using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("amend_amd")]
public partial class AmendAmd
{
    [Key]
    [Column("id_amd")]
    public int IdAmd { get; set; }

    [Column("id_prj_amd")]
    public int? IdPrjAmd { get; set; }

    [Column("year_amd")]
    public int? YearAmd { get; set; }

    [Column("acreage_amd", TypeName = "decimal(38, 0)")]
    public decimal? AcreageAmd { get; set; }

    [Column("nextsample_amd")]
    public int? NextsampleAmd { get; set; }

    [Column("comment_amd")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? CommentAmd { get; set; }
}
