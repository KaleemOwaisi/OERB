using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("contract_con")]
public partial class ContractCon
{
    [Key]
    [Column("id_con")]
    public int IdCon { get; set; }

    [Column("id_bcon_con")]
    public int? IdBconCon { get; set; }

    [Column("id_ctr_con")]
    public int? IdCtrCon { get; set; }

    [Column("is_declinedpb_con")]
    public int? IsDeclinedpbCon { get; set; }

    [Column("is_attendedpb_con")]
    public int? IsAttendedpbCon { get; set; }

    [Column("is_acknowledgedadd_con")]
    public int? IsAcknowledgedaddCon { get; set; }

    [Column("is_affidavits_con")]
    public int? IsAffidavitsCon { get; set; }

    [Column("security_con")]
    [StringLength(48)]
    [Unicode(false)]
    public string? SecurityCon { get; set; }

    [Column("up1value_con", TypeName = "decimal(38, 0)")]
    public decimal? Up1valueCon { get; set; }

    [Column("up2value_con", TypeName = "decimal(38, 0)")]
    public decimal? Up2valueCon { get; set; }

    [Column("up3value_con", TypeName = "decimal(38, 0)")]
    public decimal? Up3valueCon { get; set; }

    [Column("up4value_con", TypeName = "decimal(38, 0)")]
    public decimal? Up4valueCon { get; set; }

    [Column("up5value_con", TypeName = "decimal(38, 0)")]
    public decimal? Up5valueCon { get; set; }

    [Column("up6value_con", TypeName = "decimal(38, 0)")]
    public decimal? Up6valueCon { get; set; }

    [Column("rank_con")]
    public int? RankCon { get; set; }

    [Column("daystocomplete_con")]
    public int? DaystocompleteCon { get; set; }

    [Column("alt1value_con", TypeName = "decimal(38, 0)")]
    public decimal? Alt1valueCon { get; set; }

    [Column("alt2value_con", TypeName = "decimal(38, 0)")]
    public decimal? Alt2valueCon { get; set; }

    [Column("alt3value_con", TypeName = "decimal(38, 0)")]
    public decimal? Alt3valueCon { get; set; }

    [Column("alt4value_con", TypeName = "decimal(38, 0)")]
    public decimal? Alt4valueCon { get; set; }
}
