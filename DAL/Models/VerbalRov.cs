using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("verbal_rov")]
public partial class VerbalRov
{
    [Key]
    [Column("id_rov")]
    public int IdRov { get; set; }

    [Column("id_prj_rov")]
    public int IdPrjRov { get; set; }

    [Column("user_rov")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserRov { get; set; } = null!;

    [Column("comment_rov")]
    [Unicode(false)]
    public string CommentRov { get; set; } = null!;

    [Column("createtime_rov")]
    public DateTime CreatetimeRov { get; set; }

    [Column("contacttime_rov")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ContacttimeRov { get; set; }

    [Column("contactdate_rov", TypeName = "date")]
    public DateTime ContactdateRov { get; set; }

    [Column("activity_rov")]
    [StringLength(75)]
    [Unicode(false)]
    public string? ActivityRov { get; set; }

    [Column("okienum")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Okienum { get; set; }
}
