using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("palmaster_prj")]
[Index("NumberPrj", Name = "UQ__palmaste__A1607450E049FFE9", IsUnique = true)]
[Index("IdCtrPrj", Name = "id_ctr_prj")]
public partial class PalmasterPrj
{
    [Key]
    [Column("id_prj")]
    public int IdPrj { get; set; }

    [Column("id_ctr_prj")]
    public int? IdCtrPrj { get; set; }

    [Column("number_prj")]
    [StringLength(8)]
    [Unicode(false)]
    public string? NumberPrj { get; set; }

    [Column("name_prj")]
    [StringLength(255)]
    [Unicode(false)]
    public string? NamePrj { get; set; }

    [Column("numsites_prj")]
    public int? NumsitesPrj { get; set; }

    [Column("rov_prj")]
    [Unicode(false)]
    public string? RovPrj { get; set; }

    [Column("is_lea_prj")]
    public int? IsLeaPrj { get; set; }

    [Column("location_prj")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LocationPrj { get; set; }

    [Column("manager_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? ManagerPrj { get; set; }

    [Column("leader_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? LeaderPrj { get; set; }

    [Column("section_prj")]
    [StringLength(256)]
    [Unicode(false)]
    public string? SectionPrj { get; set; }

    [Column("township_prj")]
    [StringLength(256)]
    [Unicode(false)]
    public string? TownshipPrj { get; set; }

    [Column("range_prj")]
    [StringLength(256)]
    [Unicode(false)]
    public string? RangePrj { get; set; }

    [Column("county_prj")]
    [StringLength(64)]
    [Unicode(false)]
    public string? CountyPrj { get; set; }

    [Column("occdist_prj")]
    [StringLength(64)]
    [Unicode(false)]
    public string? OccdistPrj { get; set; }

    [Column("occinsp_prj")]
    [StringLength(64)]
    [Unicode(false)]
    public string? OccinspPrj { get; set; }

    [Column("occtel_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? OcctelPrj { get; set; }

    [Column("comments_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CommentsPrj { get; set; }

    [Column("needopagree_prj")]
    [StringLength(8)]
    [Unicode(false)]
    public string? NeedopagreePrj { get; set; }

    [Column("brownfield_prj")]
    [StringLength(4)]
    [Unicode(false)]
    public string? BrownfieldPrj { get; set; }

    [Column("lastknownop_prj")]
    [StringLength(64)]
    [Unicode(false)]
    public string? LastknownopPrj { get; set; }

    [Column("date_prebid_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? DatePrebidPrj { get; set; }

    [Column("date_100_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date100Prj { get; set; }

    [Column("date_110_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date110Prj { get; set; }

    [Column("date_220_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date220Prj { get; set; }

    [Column("date_230_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date230Prj { get; set; }

    [Column("date_240_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date240Prj { get; set; }

    [Column("date_300_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date300Prj { get; set; }

    [Column("date_310_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date310Prj { get; set; }

    [Column("date_320_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date320Prj { get; set; }

    [Column("date_330_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date330Prj { get; set; }

    [Column("date_340_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date340Prj { get; set; }

    [Column("date_350_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date350Prj { get; set; }

    [Column("date_100310_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date100310Prj { get; set; }

    [Column("date_320340_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Date320340Prj { get; set; }

    [Column("addwrkcode_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? AddwrkcodePrj { get; set; }

    [Column("status_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? StatusPrj { get; set; }

    [Column("holddrop_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? HolddropPrj { get; set; }

    [Column("estimate_prj", TypeName = "decimal(38, 0)")]
    public decimal? EstimatePrj { get; set; }

    [Column("bid_prj", TypeName = "decimal(38, 0)")]
    public decimal? BidPrj { get; set; }

    [Column("fiscal_prj")]
    [StringLength(4)]
    [Unicode(false)]
    public string? FiscalPrj { get; set; }

    [Column("winningcontractor_prj")]
    [StringLength(64)]
    [Unicode(false)]
    public string? WinningcontractorPrj { get; set; }

    [Column("po_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? PoPrj { get; set; }

    [Column("daystocomplete_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? DaystocompletePrj { get; set; }

    [Column("distribution_prj")]
    [StringLength(255)]
    [Unicode(false)]
    public string? DistributionPrj { get; set; }

    [Column("neartown_prj")]
    [StringLength(64)]
    [Unicode(false)]
    public string? NeartownPrj { get; set; }

    [Column("includes_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? IncludesPrj { get; set; }

    [Column("objective_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? ObjectivePrj { get; set; }

    [Column("instrumentmodel_prj")]
    [StringLength(512)]
    [Unicode(false)]
    public string? InstrumentmodelPrj { get; set; }

    [Column("devicename_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? DevicenamePrj { get; set; }

    [Column("is_assigned_prj")]
    public int? IsAssignedPrj { get; set; }

    [Column("is_legacy_prj")]
    public int? IsLegacyPrj { get; set; }

    [Column("latitude_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? LatitudePrj { get; set; }

    [Column("longitude_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? LongitudePrj { get; set; }

    [Column("lominerals_prj")]
    [StringLength(8)]
    [Unicode(false)]
    public string? LomineralsPrj { get; set; }

    [Column("amendtype_prj")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AmendtypePrj { get; set; }

    [Column("is_lfcclose_prj")]
    public int? IsLfcclosePrj { get; set; }

    [Column("is_lfcreapply_prj")]
    public int? IsLfcreapplyPrj { get; set; }

    [Column("lfcest_prj", TypeName = "decimal(38, 0)")]
    public decimal? LfcestPrj { get; set; }

    [Column("lfcarea_prj", TypeName = "decimal(38, 0)")]
    public decimal? LfcareaPrj { get; set; }

    [Column("lfcurea_prj", TypeName = "decimal(38, 0)")]
    public decimal? LfcureaPrj { get; set; }

    [Column("laest_prj", TypeName = "decimal(38, 0)")]
    public decimal? LaestPrj { get; set; }

    [Column("laarea_prj", TypeName = "decimal(38, 0)")]
    public decimal? LaareaPrj { get; set; }

    [Column("laurea_prj", TypeName = "decimal(38, 0)")]
    public decimal? LaureaPrj { get; set; }
}
