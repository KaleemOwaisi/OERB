using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("beacitems_beac")]
public partial class BeacitemsBeac
{
    [Key]
    [Column("id_beac")]
    public int IdBeac { get; set; }

    [Column("number_prj_beac")]
    [StringLength(20)]
    [Unicode(false)]
    public string? NumberPrjBeac { get; set; }

    [Column("assignedto_beac")]
    [StringLength(48)]
    [Unicode(false)]
    public string? AssignedtoBeac { get; set; }

    [Column("openedby_beac")]
    [StringLength(14)]
    [Unicode(false)]
    public string? OpenedbyBeac { get; set; }

    [Column("openeddate_beac")]
    [StringLength(10)]
    [Unicode(false)]
    public string? OpeneddateBeac { get; set; }

    [Column("status_beac")]
    [StringLength(10)]
    [Unicode(false)]
    public string? StatusBeac { get; set; }

    [Column("category_beac")]
    [StringLength(48)]
    [Unicode(false)]
    public string? CategoryBeac { get; set; }

    [Column("priority_beac")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PriorityBeac { get; set; }

    [Column("description_beac")]
    [StringLength(38)]
    [Unicode(false)]
    public string? DescriptionBeac { get; set; }

    [Column("file_beac")]
    [Unicode(false)]
    public string? FileBeac { get; set; }

    [Column("name_prj_beac")]
    [StringLength(35)]
    [Unicode(false)]
    public string? NamePrjBeac { get; set; }

    [Column("closedate_beac")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ClosedateBeac { get; set; }

    [Column("filename_beac")]
    [StringLength(512)]
    [Unicode(false)]
    public string? FilenameBeac { get; set; }

    [Column("is_resolved_beac")]
    public int? IsResolvedBeac { get; set; }
}
