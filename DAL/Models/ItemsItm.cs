using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("items_itm")]
public partial class ItemsItm
{
    [Key]
    [Column("id_itm")]
    public int IdItm { get; set; }

    [Column("id_beac_itm")]
    public int? IdBeacItm { get; set; }

    [Column("author_itm")]
    [StringLength(64)]
    [Unicode(false)]
    public string? AuthorItm { get; set; }

    [Column("timestamp_itm")]
    public DateTime TimestampItm { get; set; }

    [Column("comment_itm")]
    [Unicode(false)]
    public string? CommentItm { get; set; }
}
