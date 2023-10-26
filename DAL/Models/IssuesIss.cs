using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("issues_iss")]
public partial class IssuesIss
{
    [Key]
    [Column("id_iss")]
    public int IdIss { get; set; }

    [Column("id_act_iss")]
    public int? IdActIss { get; set; }

    [Column("author_iss")]
    [StringLength(64)]
    [Unicode(false)]
    public string? AuthorIss { get; set; }

    [Column("timestamp_iss")]
    public DateTime TimestampIss { get; set; }

    [Column("comment_iss")]
    [Unicode(false)]
    public string? CommentIss { get; set; }
}
