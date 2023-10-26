using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("site_ste")]
[Index("IdPrjSte", Name = "projectexists_idx")]
public partial class SiteSte
{
    [Key]
    [Column("id_ste")]
    public int IdSte { get; set; }

    [Column("location_ste")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LocationSte { get; set; }

    [Column("id_prj_ste")]
    public int? IdPrjSte { get; set; }

    [Column("number_ste")]
    public int? NumberSte { get; set; }

    [Column("section_ste")]
    [StringLength(255)]
    [Unicode(false)]
    public string? SectionSte { get; set; }

    [Column("township_ste")]
    [StringLength(255)]
    [Unicode(false)]
    public string? TownshipSte { get; set; }

    [Column("range_ste")]
    [StringLength(255)]
    [Unicode(false)]
    public string? RangeSte { get; set; }

    [Column("longitude_ste")]
    [StringLength(32)]
    [Unicode(false)]
    public string? LongitudeSte { get; set; }

    [Column("latitude_ste")]
    [StringLength(32)]
    [Unicode(false)]
    public string? LatitudeSte { get; set; }

    [Column("latdeg_ste")]
    [StringLength(4)]
    [Unicode(false)]
    public string? LatdegSte { get; set; }

    [Column("latmin_ste")]
    [StringLength(4)]
    [Unicode(false)]
    public string? LatminSte { get; set; }

    [Column("latsec_ste")]
    [StringLength(8)]
    [Unicode(false)]
    public string? LatsecSte { get; set; }

    [Column("longdeg_ste")]
    [StringLength(4)]
    [Unicode(false)]
    public string? LongdegSte { get; set; }

    [Column("longmin_ste")]
    [StringLength(4)]
    [Unicode(false)]
    public string? LongminSte { get; set; }

    [Column("longsec_ste")]
    [StringLength(8)]
    [Unicode(false)]
    public string? LongsecSte { get; set; }

    [Column("accuracy_ste")]
    [StringLength(32)]
    [Unicode(false)]
    public string? AccuracySte { get; set; }

    [Column("altitude_ste")]
    [StringLength(32)]
    [Unicode(false)]
    public string? AltitudeSte { get; set; }

    [Column("altitudeaccuracy_ste")]
    [StringLength(32)]
    [Unicode(false)]
    public string? AltitudeaccuracySte { get; set; }

    [Column("heading_ste")]
    [StringLength(32)]
    [Unicode(false)]
    public string? HeadingSte { get; set; }

    [Column("rating_ste")]
    public int? RatingSte { get; set; }

    [Column("is_drystruct")]
    public int? IsDrystruct { get; set; }

    [Column("is_sampreq_ste")]
    public int? IsSampreqSte { get; set; }

    [Column("is_fencerepl_ste")]
    public int? IsFencereplSte { get; set; }

    [Column("is_sedcontrolbar_ste")]
    public int? IsSedcontrolbarSte { get; set; }

    [Column("sedcontrollen_ste")]
    public double? SedcontrollenSte { get; set; }

    [Column("denudedarea_ste")]
    public double? DenudedareaSte { get; set; }

    [Column("denudedest_ste")]
    public int? DenudedestSte { get; set; }

    [Column("is_denudedpond_ste")]
    public int? IsDenudedpondSte { get; set; }

    [Column("is_denudedtreat_ste")]
    public int? IsDenudedtreatSte { get; set; }

    [Column("hydrovol_ste")]
    public double? HydrovolSte { get; set; }

    [Column("hydroest_ste")]
    public int? HydroestSte { get; set; }

    [Column("is_hydrowhc_ste")]
    public int? IsHydrowhcSte { get; set; }

    [Column("is_hydrolfc_ste")]
    public int? IsHydrolfcSte { get; set; }

    [Column("is_hydrola_ste")]
    public int? IsHydrolaSte { get; set; }

    [Column("hydrowhcdepth_ste")]
    public double? HydrowhcdepthSte { get; set; }

    [Column("hydrowhccounty_ste")]
    [StringLength(64)]
    [Unicode(false)]
    public string? HydrowhccountySte { get; set; }

    [Column("is_hydroosd_ste")]
    public int? IsHydroosdSte { get; set; }

    [Column("hydroosdcounty_ste")]
    [StringLength(64)]
    [Unicode(false)]
    public string? HydroosdcountySte { get; set; }

    [Column("hydroosdcontact_ste")]
    [StringLength(64)]
    [Unicode(false)]
    public string? HydroosdcontactSte { get; set; }

    [Column("is_lfcfence_ste")]
    public int? IsLfcfenceSte { get; set; }

    [Column("lfchay_ste")]
    public double? LfchaySte { get; set; }

    [Column("lfcurea_ste")]
    public double? LfcureaSte { get; set; }

    [Column("lfclocation_ste")]
    [StringLength(64)]
    [Unicode(false)]
    public string? LfclocationSte { get; set; }

    [Column("is_lafence_ste")]
    public int? IsLafenceSte { get; set; }

    [Column("lahay_ste")]
    public double? LahaySte { get; set; }

    [Column("laurea_ste")]
    public double? LaureaSte { get; set; }

    [Column("tdest_ste")]
    public int? TdestSte { get; set; }

    [Column("tdarea_ste")]
    public double? TdareaSte { get; set; }

    [Column("is_tdanchors_ste")]
    public int? IsTdanchorsSte { get; set; }

    [Column("is_tdnorm_ste")]
    public int? IsTdnormSte { get; set; }

    [Column("is_tdflowlines_ste")]
    public int? IsTdflowlinesSte { get; set; }

    [Column("is_tdflowlinelo_ste")]
    public int? IsTdflowlineloSte { get; set; }

    [Column("is_tdmisc_ste")]
    public int? IsTdmiscSte { get; set; }

    [Column("is_tdmetal_ste")]
    public int? IsTdmetalSte { get; set; }

    [Column("is_tdtimber_ste")]
    public int? IsTdtimberSte { get; set; }

    [Column("tanksnum_ste")]
    public int? TanksnumSte { get; set; }

    [Column("tanksest_ste")]
    public int? TanksestSte { get; set; }

    [Column("is_tankssolid_ste")]
    public int? IsTankssolidSte { get; set; }

    [Column("is_tanksnorm_ste")]
    public int? IsTanksnormSte { get; set; }

    [Column("is_tanksempty_ste")]
    public int? IsTanksemptySte { get; set; }

    [Column("is_tanksbs_ste")]
    public int? IsTanksbsSte { get; set; }

    [Column("is_tanksoil_ste")]
    public int? IsTanksoilSte { get; set; }

    [Column("is_tankssw_ste")]
    public int? IsTanksswSte { get; set; }

    [Column("tanksoilbarrels_ste")]
    public double? TanksoilbarrelsSte { get; set; }

    [Column("tanksswbarrels_ste")]
    public double? TanksswbarrelsSte { get; set; }

    [Column("pitsnum_ste")]
    [StringLength(16)]
    [Unicode(false)]
    public string? PitsnumSte { get; set; }

    [Column("pitsest_ste")]
    public int? PitsestSte { get; set; }

    [Column("is_pitsdirt_ste")]
    public int? IsPitsdirtSte { get; set; }

    [Column("is_pitsfluid_ste")]
    public int? IsPitsfluidSte { get; set; }

    [Column("is_pitsdm_ste")]
    public int? IsPitsdmSte { get; set; }

    [Column("is_pitshc_ste")]
    public int? IsPitshcSte { get; set; }

    [Column("tdikesnum_ste")]
    public int? TdikesnumSte { get; set; }

    [Column("tdikesest_ste")]
    public int? TdikesestSte { get; set; }

    [Column("gradearea_ste")]
    public double? GradeareaSte { get; set; }

    [Column("gradeest_ste")]
    public int? GradeestSte { get; set; }

    [Column("gradehaystraw_ste")]
    public double? GradehaystrawSte { get; set; }

    [Column("is_gradeerosion_ste")]
    public int? IsGradeerosionSte { get; set; }

    [Column("is_gradesoilmound_ste")]
    public int? IsGradesoilmoundSte { get; set; }

    [Column("is_gradedepress_ste")]
    public int? IsGradedepressSte { get; set; }

    [Column("is_gradeberms_ste")]
    public int? IsGradebermsSte { get; set; }

    [Column("is_graderaised_ste")]
    public int? IsGraderaisedSte { get; set; }

    [Column("is_gradesinkhole_ste")]
    public int? IsGradesinkholeSte { get; set; }

    [Column("is_gradewtrway_ste")]
    public int? IsGradewtrwaySte { get; set; }

    [Column("is_gradegabion_ste")]
    public int? IsGradegabionSte { get; set; }

    [Column("is_gabionsodmulch_ste")]
    public int? IsGabionsodmulchSte { get; set; }

    [Column("is_gabionsod_ste")]
    public int? IsGabionsodSte { get; set; }

    [Column("is_gabionterrace_ste")]
    public int? IsGabionterraceSte { get; set; }

    [Column("gabionspecfigure_ste")]
    public int? GabionspecfigureSte { get; set; }

    [Column("gabionrocktons_ste")]
    public int? GabionrocktonsSte { get; set; }

    [Column("gabionbaskets_ste")]
    public int? GabionbasketsSte { get; set; }

    [Column("gabionfabric_ste", TypeName = "decimal(38, 0)")]
    public decimal? GabionfabricSte { get; set; }

    [Column("numgradeterraces_ste")]
    public int? NumgradeterracesSte { get; set; }

    [Column("gradeterracevol_ste")]
    public int? GradeterracevolSte { get; set; }

    [Column("gradeterracelen_ste")]
    public int? GradeterracelenSte { get; set; }

    [Column("is_gradeonly_ste")]
    public int? IsGradeonlySte { get; set; }

    [Column("is_gradeerodeloc_ste")]
    public int? IsGradeerodelocSte { get; set; }

    [Column("normbg_ste")]
    [StringLength(16)]
    [Unicode(false)]
    public string? NormbgSte { get; set; }

    [Column("normhigh_ste")]
    [StringLength(16)]
    [Unicode(false)]
    public string? NormhighSte { get; set; }

    [Column("ccgravest_ste")]
    public int? CcgravestSte { get; set; }

    [Column("is_cc_ste")]
    public int? IsCcSte { get; set; }

    [Column("is_grav_ste")]
    public int? IsGravSte { get; set; }

    [Column("cchandle_ste")]
    [StringLength(16)]
    [Unicode(false)]
    public string? CchandleSte { get; set; }

    [Column("ccgravhandle_ste")]
    [StringLength(16)]
    [Unicode(false)]
    public string? CcgravhandleSte { get; set; }

    [Column("tbpadest_ste")]
    public int? TbpadestSte { get; set; }

    [Column("is_tbhc_ste")]
    public int? IsTbhcSte { get; set; }

    [Column("lpadest_ste")]
    public int? LpadestSte { get; set; }

    [Column("lpaddisp_ste")]
    [StringLength(16)]
    [Unicode(false)]
    public string? LpaddispSte { get; set; }

    [Column("is_lpaddirt_ste")]
    public int? IsLpaddirtSte { get; set; }

    [Column("is_lpadgrav_ste")]
    public int? IsLpadgravSte { get; set; }

    [Column("lpgravhandle_ste")]
    [StringLength(16)]
    [Unicode(false)]
    public string? LpgravhandleSte { get; set; }

    [Column("lroadest_ste")]
    public int? LroadestSte { get; set; }

    [Column("is_lroadgrav_ste")]
    public int? IsLroadgravSte { get; set; }

    [Column("lroadgravhandle_ste")]
    [StringLength(15)]
    [Unicode(false)]
    public string? LroadgravhandleSte { get; set; }

    [Column("is_lroaddirt_ste")]
    public int? IsLroaddirtSte { get; set; }

    [Column("otherest_ste")]
    public int? OtherestSte { get; set; }

    [Column("otherdesc_ste")]
    [StringLength(255)]
    [Unicode(false)]
    public string? OtherdescSte { get; set; }

    [Column("terraceest_ste")]
    public int? TerraceestSte { get; set; }

    [Column("terracelen_ste")]
    public double? TerracelenSte { get; set; }

    [Column("terraceslope_ste")]
    public double? TerraceslopeSte { get; set; }

    [Column("sedcontrolest_ste", TypeName = "decimal(38, 0)")]
    public decimal? SedcontrolestSte { get; set; }

    [Column("is_plantregular_ste")]
    public int? IsPlantregularSte { get; set; }

    [Column("is_plantnative_ste")]
    public int? IsPlantnativeSte { get; set; }

    [Column("is_fertilizeonly_ste")]
    public int? IsFertilizeonlySte { get; set; }

    [Column("is_sodonly_ste")]
    public int? IsSodonlySte { get; set; }

    [Column("is_tbdirt_ste")]
    public int? IsTbdirtSte { get; set; }

    [Column("is_tbgrav_ste")]
    public int? IsTbgravSte { get; set; }

    [Column("tbgravhandle_ste")]
    [StringLength(15)]
    [Unicode(false)]
    public string? TbgravhandleSte { get; set; }

    [Column("is_gradepond_ste")]
    public int? IsGradepondSte { get; set; }

    [Column("is_gradeterrace_ste")]
    public int? IsGradeterraceSte { get; set; }

    [Column("organic_ste")]
    public double? OrganicSte { get; set; }

    [Column("nitrogen_ste")]
    public double? NitrogenSte { get; set; }

    [Column("phosphorous_ste")]
    public double? PhosphorousSte { get; set; }

    [Column("potassium_ste")]
    public double? PotassiumSte { get; set; }

    [Column("gypsumtpa_ste")]
    public double? GypsumtpaSte { get; set; }

    [Column("sagypsumtpa_ste")]
    public double? SagypsumtpaSte { get; set; }

    [Column("is_submitted_ste")]
    public int? IsSubmittedSte { get; set; }

    [Column("number_prj_ste")]
    [StringLength(8)]
    [Unicode(false)]
    public string? NumberPrjSte { get; set; }

    [Column("epoch_ste")]
    public double? EpochSte { get; set; }

    [Column("is_exclude_ste")]
    public int? IsExcludeSte { get; set; }

    [Column("is_disabled_ste")]
    public int? IsDisabledSte { get; set; }

    [Column("is_lfcclose_ste")]
    public int? IsLfccloseSte { get; set; }

    [Column("is_lfcreapply_ste")]
    public int? IsLfcreapplySte { get; set; }

    [Column("lfcest_ste", TypeName = "decimal(38, 0)")]
    public decimal? LfcestSte { get; set; }

    [Column("lfcarea_ste", TypeName = "decimal(38, 0)")]
    public decimal? LfcareaSte { get; set; }

    [Column("laest_ste", TypeName = "decimal(38, 0)")]
    public decimal? LaestSte { get; set; }

    [Column("laarea_ste", TypeName = "decimal(38, 0)")]
    public decimal? LaareaSte { get; set; }

    [Column("erosionhay_ste")]
    public double? ErosionhaySte { get; set; }

    [Column("creationdatetime_ste", TypeName = "datetime")]
    public DateTime? CreationdatetimeSte { get; set; }
}
