using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("bidcontract_bcon")]
public partial class BidcontractBcon
{
    [Key]
    [Column("id_bcon")]
    public int IdBcon { get; set; }

    [Column("id_pbs_bcon")]
    public int? IdPbsBcon { get; set; }

    [Column("rank_bcon")]
    public int RankBcon { get; set; }

    [Column("partA1label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartA1labelBcon { get; set; }

    [Column("partA2label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartA2labelBcon { get; set; }

    [Column("partA3label_bcon")]
    [StringLength(253)]
    [Unicode(false)]
    public string? PartA3labelBcon { get; set; }

    [Column("partB1label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartB1labelBcon { get; set; }

    [Column("partB2label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartB2labelBcon { get; set; }

    [Column("partC1label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartC1labelBcon { get; set; }

    [Column("partC2label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartC2labelBcon { get; set; }

    [Column("partD1label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartD1labelBcon { get; set; }

    [Column("partD2label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartD2labelBcon { get; set; }

    [Column("partE1label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartE1labelBcon { get; set; }

    [Column("partE2label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartE2labelBcon { get; set; }

    [Column("partF1label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartF1labelBcon { get; set; }

    [Column("partF2label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? PartF2labelBcon { get; set; }

    [Column("up1label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Up1labelBcon { get; set; }

    [Column("up2label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Up2labelBcon { get; set; }

    [Column("up3label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Up3labelBcon { get; set; }

    [Column("up4label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Up4labelBcon { get; set; }

    [Column("up5label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Up5labelBcon { get; set; }

    [Column("up6label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Up6labelBcon { get; set; }

    [Column("up7label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Up7labelBcon { get; set; }

    [Column("partAproject_bcon")]
    [StringLength(11)]
    [Unicode(false)]
    public string? PartAprojectBcon { get; set; }

    [Column("partBproject_bcon")]
    [StringLength(11)]
    [Unicode(false)]
    public string? PartBprojectBcon { get; set; }

    [Column("partCproject_bcon")]
    [StringLength(11)]
    [Unicode(false)]
    public string? PartCprojectBcon { get; set; }

    [Column("partDproject_bcon")]
    [StringLength(11)]
    [Unicode(false)]
    public string? PartDprojectBcon { get; set; }

    [Column("partEproject_bcon")]
    [StringLength(11)]
    [Unicode(false)]
    public string? PartEprojectBcon { get; set; }

    [Column("partFproject_bcon")]
    [StringLength(11)]
    [Unicode(false)]
    public string? PartFprojectBcon { get; set; }

    [Column("alt1label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Alt1labelBcon { get; set; }

    [Column("alt2label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Alt2labelBcon { get; set; }

    [Column("alt3label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Alt3labelBcon { get; set; }

    [Column("alt4label_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Alt4labelBcon { get; set; }

    [Column("is_mailedadd_bcon")]
    public int? IsMailedaddBcon { get; set; }

    [Column("date_310_bcon")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date310Bcon { get; set; }

    [Column("agencyreq_bcon")]
    [StringLength(16)]
    [Unicode(false)]
    public string? AgencyreqBcon { get; set; }

    [Column("po_bcon")]
    [StringLength(16)]
    [Unicode(false)]
    public string? PoBcon { get; set; }

    [Column("account_bcon")]
    [StringLength(16)]
    [Unicode(false)]
    public string? AccountBcon { get; set; }

    [Column("subactivity_bcon")]
    [StringLength(16)]
    [Unicode(false)]
    public string? SubactivityBcon { get; set; }

    [Column("is_approvedwo_bcon")]
    public int IsApprovedwoBcon { get; set; }

    [Column("is_approvedbids_bcon")]
    public int? IsApprovedbidsBcon { get; set; }

    [Column("is_pmapproved_bcon")]
    public int? IsPmapprovedBcon { get; set; }

    [Column("is_mindyapproved_bcon")]
    public int? IsMindyapprovedBcon { get; set; }

    [Column("is_attendance_bcon")]
    public int? IsAttendanceBcon { get; set; }

    [Column("is_approvedcontract_bcon")]
    public int? IsApprovedcontractBcon { get; set; }

    [Column("description_bcon")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? DescriptionBcon { get; set; }

    [Column("date_bidapproved_bcon", TypeName = "date")]
    public DateTime? DateBidapprovedBcon { get; set; }

    [Column("file_bcon")]
    public byte[]? FileBcon { get; set; }

    [Column("filename_bcon")]
    [StringLength(256)]
    [Unicode(false)]
    public string? FilenameBcon { get; set; }

    [Column("numberofchangeorders_bcon")]
    public int? NumberofchangeordersBcon { get; set; }

    [Column("changedesc_bcon")]
    [Unicode(false)]
    public string? ChangedescBcon { get; set; }

    [Column("partialpayment_bcon", TypeName = "decimal(38, 0)")]
    public decimal? PartialpaymentBcon { get; set; }

    [Column("pwvldesc_bcon")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? PwvldescBcon { get; set; }

    [Column("finalpayment_bcon", TypeName = "decimal(38, 0)")]
    public decimal? FinalpaymentBcon { get; set; }

    [Column("is_consultant_bcon")]
    public int? IsConsultantBcon { get; set; }

    [Column("is_owner_bcon")]
    public int? IsOwnerBcon { get; set; }

    [Column("is_contractor_bcon")]
    public int? IsContractorBcon { get; set; }
}
