using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("followup_fol")]
public partial class FollowupFol
{
    [Key]
    [Column("id_fol")]
    public int IdFol { get; set; }

    [Column("id_prj_fol")]
    public int IdPrjFol { get; set; }

    [Column("contact_fol")]
    [StringLength(102)]
    [Unicode(false)]
    public string? ContactFol { get; set; }

    [Column("phone_fol")]
    [Unicode(false)]
    public string? PhoneFol { get; set; }

    [Column("comments_fol")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CommentsFol { get; set; }

    [Column("is_nosite_fol")]
    public int IsNositeFol { get; set; }

    [Column("is_callme_fol")]
    public int IsCallmeFol { get; set; }

    [Column("is_newsite_fol")]
    public int IsNewsiteFol { get; set; }

    [Column("is_referred_fol")]
    public int IsReferredFol { get; set; }

    [Column("refercontact_fol")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? RefercontactFol { get; set; }

    [Column("is_done_fol")]
    public int IsDoneFol { get; set; }
}
