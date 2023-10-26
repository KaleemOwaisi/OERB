using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("maprequest_map")]
public partial class MaprequestMap
{
    [Key]
    [Column("id_map")]
    public int IdMap { get; set; }

    [Column("id_prj_map")]
    public int? IdPrjMap { get; set; }

    [Column("type_map")]
    [StringLength(80)]
    [Unicode(false)]
    public string? TypeMap { get; set; }

    [Column("date_needby_map", TypeName = "date")]
    public DateTime? DateNeedbyMap { get; set; }

    [Column("date_created_map")]
    public DateTime DateCreatedMap { get; set; }

    [Column("is_addrequest_map")]
    public int? IsAddrequestMap { get; set; }

    [Column("date_complete_map", TypeName = "date")]
    public DateTime? DateCompleteMap { get; set; }
}
