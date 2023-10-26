using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("backup_bkp")]
public partial class BackupBkp
{
    [Key]
    [Column("id_bkp")]
    public int IdBkp { get; set; }

    [Column("id_prj_bkp")]
    public int? IdPrjBkp { get; set; }

    [Column("id_assigned_bkp")]
    [StringLength(2)]
    [Unicode(false)]
    public string? IdAssignedBkp { get; set; }

    [Column("backuptime_bkp", TypeName = "datetime")]
    public DateTime? BackuptimeBkp { get; set; }

    [Column("data_bkp")]
    [Unicode(false)]
    public string? DataBkp { get; set; }
}
