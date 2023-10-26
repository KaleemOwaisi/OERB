using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("operatorlink_oprlink")]
public partial class OperatorlinkOprlink
{
    [Key]
    [Column("id_oprlink")]
    public int IdOprlink { get; set; }

    [Column("id_prj_oprlink")]
    public int? IdPrjOprlink { get; set; }

    [Column("id_opr_oprlink")]
    public int? IdOprOprlink { get; set; }

    [Column("contact_oprlink")]
    [StringLength(40)]
    [Unicode(false)]
    public string? ContactOprlink { get; set; }

    [Column("phone_oprlink")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneOprlink { get; set; }

    [Column("received_oprlink")]
    [StringLength(4)]
    [Unicode(false)]
    public string ReceivedOprlink { get; set; } = null!;

    [Column("comment_oprlink")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CommentOprlink { get; set; }
}
