using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("bmsfilter_bmf")]
public partial class BmsfilterBmf
{
    [Key]
    [Column("id_bmf")]
    public int IdBmf { get; set; }

    [Column("date_bmsfilter_bmf", TypeName = "date")]
    public DateTime DateBmsfilterBmf { get; set; }
}
