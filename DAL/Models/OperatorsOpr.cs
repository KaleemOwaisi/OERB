using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("operators_opr")]
public partial class OperatorsOpr
{
    [Key]
    [Column("id_opr")]
    public int IdOpr { get; set; }

    [Column("name_opr")]
    [StringLength(100)]
    [Unicode(false)]
    public string? NameOpr { get; set; }

    [Column("number_opr")]
    public int? NumberOpr { get; set; }
}
