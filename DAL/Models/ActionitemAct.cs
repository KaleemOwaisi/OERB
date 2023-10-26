using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("actionitem_act")]
public partial class ActionitemAct
{
    [Key]
    [Column("id_act")]
    public int IdAct { get; set; }

    [Column("number_prj_act")]
    [StringLength(60)]
    [Unicode(false)]
    public string? NumberPrjAct { get; set; }

    [Column("assignedto_act")]
    [StringLength(144)]
    [Unicode(false)]
    public string? AssignedtoAct { get; set; }

    [Column("openedby_act")]
    [StringLength(42)]
    [Unicode(false)]
    public string? OpenedbyAct { get; set; }

    [Column("openeddate_act")]
    [StringLength(30)]
    [Unicode(false)]
    public string? OpeneddateAct { get; set; }

    [Column("status_act")]
    [StringLength(30)]
    [Unicode(false)]
    public string? StatusAct { get; set; }

    [Column("category_act")]
    [StringLength(144)]
    [Unicode(false)]
    public string? CategoryAct { get; set; }

    [Column("priority_act")]
    [StringLength(30)]
    [Unicode(false)]
    public string? PriorityAct { get; set; }

    [Column("description_act")]
    [StringLength(114)]
    [Unicode(false)]
    public string? DescriptionAct { get; set; }

    [Column("file_act")]
    [Unicode(false)]
    public string? FileAct { get; set; }

    [Column("name_prj_act")]
    [StringLength(105)]
    [Unicode(false)]
    public string? NamePrjAct { get; set; }

    [Column("closedate_act")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ClosedateAct { get; set; }

    [Column("filename_act")]
    [StringLength(1536)]
    [Unicode(false)]
    public string? FilenameAct { get; set; }

    [Column("is_resolved_act")]
    public int? IsResolvedAct { get; set; }
}
