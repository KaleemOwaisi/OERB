using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("qryMaster2")]
public partial class QryMaster2
{
    [Column("EXClass")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Exclass { get; set; }

    [Column("EXDate", TypeName = "datetime")]
    public DateTime? Exdate { get; set; }

    [Column("Proj#")]
    [StringLength(6)]
    [Unicode(false)]
    public string? Proj { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Payee { get; set; }

    [Column("EXMemo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Exmemo { get; set; }

    [Column("EXAmount")]
    public double? Examount { get; set; }

    [Column("Invoice#")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Invoice { get; set; }

    [Column("OERBDate", TypeName = "datetime")]
    public DateTime? Oerbdate { get; set; }

    [Column("FY")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Fy { get; set; }
}
