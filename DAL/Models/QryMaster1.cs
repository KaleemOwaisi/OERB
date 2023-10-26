using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("qryMaster1")]
public partial class QryMaster1
{
    [Column("EXClass")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Exclass { get; set; }

    [Column("EXDate", TypeName = "date")]
    public DateTime? Exdate { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? ProjNum { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Payee { get; set; }

    [Column("EXMemo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Exmemo { get; set; }

    [Column("EXAmount", TypeName = "decimal(38, 0)")]
    public decimal? Examount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Invoice { get; set; }

    [Column("OERBDate", TypeName = "date")]
    public DateTime? Oerbdate { get; set; }

    [Column("FY")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Fy { get; set; }
}
