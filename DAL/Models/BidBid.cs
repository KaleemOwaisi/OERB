using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("bid_bid")]
public partial class BidBid
{
    [Key]
    [Column("id_bid")]
    public int IdBid { get; set; }

    [Column("id_prj_bid")]
    public int? IdPrjBid { get; set; }

    [Column("id_con_bid")]
    public int? IdConBid { get; set; }

    [Column("partA1value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartA1valueBid { get; set; }

    [Column("partA2value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartA2valueBid { get; set; }

    [Column("partA3value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartA3valueBid { get; set; }

    [Column("partB1value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartB1valueBid { get; set; }

    [Column("partB2value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartB2valueBid { get; set; }

    [Column("partC1value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartC1valueBid { get; set; }

    [Column("partC2value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartC2valueBid { get; set; }

    [Column("partD1value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartD1valueBid { get; set; }

    [Column("partD2value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartD2valueBid { get; set; }

    [Column("partE1value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartE1valueBid { get; set; }

    [Column("partE2value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartE2valueBid { get; set; }

    [Column("partF1value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartF1valueBid { get; set; }

    [Column("partF2value_bid", TypeName = "decimal(38, 0)")]
    public decimal? PartF2valueBid { get; set; }

    [Column("totalbase_bid", TypeName = "decimal(38, 0)")]
    public decimal? TotalbaseBid { get; set; }
}
