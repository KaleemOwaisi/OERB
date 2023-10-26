using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("inspector_ins")]
public partial class InspectorIn
{
    [Key]
    [Column("id_ins")]
    public int IdIns { get; set; }

    [Column("lastname_ins")]
    [StringLength(32)]
    [Unicode(false)]
    public string? LastnameIns { get; set; }

    [Column("firstname_ins")]
    [StringLength(32)]
    [Unicode(false)]
    public string? FirstnameIns { get; set; }

    [Column("telephone_ins")]
    [StringLength(24)]
    [Unicode(false)]
    public string? TelephoneIns { get; set; }

    [Column("district_ins")]
    [StringLength(3)]
    [Unicode(false)]
    public string? DistrictIns { get; set; }

    [Column("is_disabled_ins")]
    public int IsDisabledIns { get; set; }
}
