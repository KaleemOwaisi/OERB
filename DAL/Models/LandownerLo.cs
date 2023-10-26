using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("landowner_lo")]
[Index("LastnameLo", Name = "firstname_lo")]
public partial class LandownerLo
{
    [Key]
    [Column("id_lo")]
    public int IdLo { get; set; }

    [Column("id_prj_lo")]
    public int IdPrjLo { get; set; }

    [Column("number_prj_lo")]
    [StringLength(16)]
    [Unicode(false)]
    public string NumberPrjLo { get; set; } = null!;

    [Column("type_lo")]
    [StringLength(16)]
    [Unicode(false)]
    public string? TypeLo { get; set; }

    [Column("company_lo")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CompanyLo { get; set; }

    [Column("title_lo")]
    [StringLength(255)]
    [Unicode(false)]
    public string? TitleLo { get; set; }

    [Column("firstname_lo")]
    [StringLength(32)]
    [Unicode(false)]
    public string? FirstnameLo { get; set; }

    [Column("lastname_lo")]
    [StringLength(32)]
    [Unicode(false)]
    public string? LastnameLo { get; set; }

    [Column("address_lo")]
    [StringLength(255)]
    [Unicode(false)]
    public string? AddressLo { get; set; }

    [Column("city_lo")]
    [StringLength(64)]
    [Unicode(false)]
    public string? CityLo { get; set; }

    [Column("state_lo")]
    [StringLength(2)]
    [Unicode(false)]
    public string? StateLo { get; set; }

    [Column("zip_lo")]
    [StringLength(16)]
    [Unicode(false)]
    public string? ZipLo { get; set; }

    [Column("homephone_lo")]
    [StringLength(16)]
    [Unicode(false)]
    public string? HomephoneLo { get; set; }

    [Column("cellphone_lo")]
    [StringLength(16)]
    [Unicode(false)]
    public string? CellphoneLo { get; set; }

    [Column("altphone_lo")]
    [StringLength(16)]
    [Unicode(false)]
    public string? AltphoneLo { get; set; }

    [Column("notes_lo")]
    [StringLength(255)]
    [Unicode(false)]
    public string? NotesLo { get; set; }

    [Column("is_legacy_lo")]
    public int IsLegacyLo { get; set; }
}
