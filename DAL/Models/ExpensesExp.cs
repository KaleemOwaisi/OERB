using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("expenses_exp")]
public partial class ExpensesExp
{
    [Key]
    [Column("id_exp")]
    public int IdExp { get; set; }

    [Column("EXClass")]
    [StringLength(6)]
    [Unicode(false)]
    public string? Exclass { get; set; }

    [Column("EXDate")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Exdate { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Proj { get; set; }

    [StringLength(78)]
    [Unicode(false)]
    public string? Payee { get; set; }

    [Column("EXMemo")]
    [StringLength(84)]
    [Unicode(false)]
    public string? Exmemo { get; set; }

    [Column("EXAmount")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Examount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Invoice { get; set; }

    [Column("OERBDate")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Oerbdate { get; set; }

    [Column("FY")]
    public int? Fy { get; set; }
}
