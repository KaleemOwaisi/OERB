using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("members")]
public partial class Member
{
    [Key]
    [Column("memberID")]
    public int MemberId { get; set; }

    [Column("username")]
    [StringLength(255)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("password")]
    [StringLength(255)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("email")]
    [StringLength(255)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("active")]
    [StringLength(255)]
    [Unicode(false)]
    public string Active { get; set; } = null!;

    [Column("resetToken")]
    [StringLength(255)]
    [Unicode(false)]
    public string? ResetToken { get; set; }

    [Column("resetComplete")]
    [StringLength(3)]
    [Unicode(false)]
    public string? ResetComplete { get; set; }

    [Column("secrets_enabled")]
    [StringLength(64)]
    [Unicode(false)]
    public string? SecretsEnabled { get; set; }
}
