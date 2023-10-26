using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("images_img")]
[Index("IdImg", Name = "id_img")]
public partial class ImagesImg
{
    [Column("id_img")]
    public int IdImg { get; set; }

    [Key]
    [Column("id_ste_img")]
    public int IdSteImg { get; set; }

    [Column("bimage_img")]
    [StringLength(256)]
    [Unicode(false)]
    public string? BimageImg { get; set; }

    [Column("btext_img")]
    [Unicode(false)]
    public string? BtextImg { get; set; }

    [Column("aimage_img")]
    [StringLength(256)]
    [Unicode(false)]
    public string? AimageImg { get; set; }

    [Column("atext_img")]
    [Unicode(false)]
    public string? AtextImg { get; set; }
}
