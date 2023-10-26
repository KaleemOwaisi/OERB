using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("project_prj")]
[Index("AddwrkcodePrj", "Date350Prj", "Date340Prj", "Date330Prj", "Date320Prj", "Date310Prj", "Date300Prj", "Date240Prj", "Date230Prj", "Date220Prj", "Date110Prj", "Date100Prj", Name = "TempIndex")]
[Index("NumberPrj", Name = "UQ__project___A16074508259598B", IsUnique = true)]
[Index("IdCtrPrj", Name = "id_ctr_prj")]
public partial class ProjectPrj
{
    [Key]
    [Column("id_prj")]
    public int IdPrj { get; set; }

    [Column("id_ctr_prj")]
    public int? IdCtrPrj { get; set; }

    [Column("id_bcon_prj")]
    public int? IdBconPrj { get; set; }

    [Column("bconrank_prj")]
    public int? BconrankPrj { get; set; }

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

    [Column("status_prj")]
    [StringLength(6)]
    [Unicode(false)]
    public string? StatusPrj { get; set; }

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

    [Column("date_100_prj", TypeName = "date")]
    public DateTime? Date100Prj { get; set; }

    [Column("date_110_prj", TypeName = "date")]
    public DateTime? Date110Prj { get; set; }

    [Column("date_220_prj", TypeName = "date")]
    public DateTime? Date220Prj { get; set; }

    [Column("date_230_prj", TypeName = "date")]
    public DateTime? Date230Prj { get; set; }

    [Column("date_240_prj", TypeName = "date")]
    public DateTime? Date240Prj { get; set; }

    [Column("date_300_prj", TypeName = "date")]
    public DateTime? Date300Prj { get; set; }

    [Column("date_310_prj", TypeName = "date")]
    public DateTime? Date310Prj { get; set; }

    [Column("date_320_prj", TypeName = "date")]
    public DateTime? Date320Prj { get; set; }

    [Column("date_330_prj", TypeName = "date")]
    public DateTime? Date330Prj { get; set; }

    [Column("date_340_prj", TypeName = "date")]
    public DateTime? Date340Prj { get; set; }

    [Column("date_350_prj", TypeName = "date")]
    public DateTime? Date350Prj { get; set; }

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

    [Column("holddrop_prj")]
    [StringLength(16)]
    [Unicode(false)]
    public string? HolddropPrj { get; set; }

    [Column("date_hold_prj", TypeName = "date")]
    public DateTime? DateHoldPrj { get; set; }

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

    [Column("latitude_prj", TypeName = "decimal(38, 0)")]
    public decimal? LatitudePrj { get; set; }

    [Column("longitude_prj", TypeName = "decimal(38, 0)")]
    public decimal? LongitudePrj { get; set; }

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

    [Column("changeorder_prj", TypeName = "decimal(38, 0)")]
    public decimal? ChangeorderPrj { get; set; }

    [Column("proposedchangeorder_prj", TypeName = "decimal(38, 0)")]
    public decimal? ProposedchangeorderPrj { get; set; }

    [Column("changedesc_prj")]
    [StringLength(2048)]
    [Unicode(false)]
    public string? ChangedescPrj { get; set; }

    [Column("is_exclude_prj")]
    public int? IsExcludePrj { get; set; }

    [Column("okienum_prj")]
    [StringLength(40)]
    [Unicode(false)]
    public string? OkienumPrj { get; set; }

    [Column("pmcomments_prj")]
    [StringLength(2048)]
    [Unicode(false)]
    public string? PmcommentsPrj { get; set; }

    [Column("latdeg_prj")]
    public int? LatdegPrj { get; set; }

    [Column("latmin_prj")]
    public int? LatminPrj { get; set; }

    [Column("latsec_prj", TypeName = "decimal(38, 0)")]
    public decimal? LatsecPrj { get; set; }

    [Column("longdeg_prj")]
    public int? LongdegPrj { get; set; }

    [Column("longmin_prj")]
    public int? LongminPrj { get; set; }

    [Column("longsec_prj", TypeName = "decimal(38, 0)")]
    public decimal? LongsecPrj { get; set; }

    [Column("toponame_prj")]
    [StringLength(128)]
    [Unicode(false)]
    public string? ToponamePrj { get; set; }

    [Column("pbscomment_prj")]
    [StringLength(1028)]
    [Unicode(false)]
    public string? PbscommentPrj { get; set; }

    [Column("drivingdirections_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? DrivingdirectionsPrj { get; set; }

    [Column("safetydate_prj", TypeName = "date")]
    public DateTime? SafetydatePrj { get; set; }

    [Column("electrical_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? ElectricalPrj { get; set; }

    [Column("chemical_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? ChemicalPrj { get; set; }

    [Column("overhead_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? OverheadPrj { get; set; }

    [Column("buriedlines_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? BuriedlinesPrj { get; set; }

    [Column("vehicletraffic_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? VehicletrafficPrj { get; set; }

    [Column("environment_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? EnvironmentPrj { get; set; }

    [Column("confinedspace_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? ConfinedspacePrj { get; set; }

    [Column("noise_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? NoisePrj { get; set; }

    [Column("surfaces_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? SurfacesPrj { get; set; }

    [Column("safetyequipment_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? SafetyequipmentPrj { get; set; }

    [Column("safetyother_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? SafetyotherPrj { get; set; }

    [Column("firefighting_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? FirefightingPrj { get; set; }

    [Column("accidentprocedures_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? AccidentproceduresPrj { get; set; }

    [Column("ambulancetel_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? AmbulancetelPrj { get; set; }

    [Column("firetel_prj")]
    [StringLength(32)]
    [Unicode(false)]
    public string? FiretelPrj { get; set; }

    [Column("nearesthospital_prj")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? NearesthospitalPrj { get; set; }

    [Column("is_finalreportready_prj")]
    public int? IsFinalreportreadyPrj { get; set; }

    [Column("plmupload_prj")]
    [Unicode(false)]
    public string? PlmuploadPrj { get; set; }

    [Column("pbmupload_prj")]
    [Unicode(false)]
    public string? PbmuploadPrj { get; set; }

    [Column("toc_prj")]
    [StringLength(2054)]
    [Unicode(false)]
    public string? TocPrj { get; set; }

    [Column("is_watersample_prj")]
    public int? IsWatersamplePrj { get; set; }

    [Column("boringdepth_prj")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? BoringdepthPrj { get; set; }

    [Column("watersample_prj")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? WatersamplePrj { get; set; }

    [Column("resolution_prj")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? ResolutionPrj { get; set; }

    [Column("is_addmisc_prj")]
    public int? IsAddmiscPrj { get; set; }

    [Column("locationdescription_prj")]
    [StringLength(1046)]
    [Unicode(false)]
    public string? LocationdescriptionPrj { get; set; }

    [Column("pmsort_prj")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PmsortPrj { get; set; }

    [Column("pondpr_prj")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PondprPrj { get; set; }
}
