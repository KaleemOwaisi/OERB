using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("prepsheet_pps")]
public partial class PrepsheetPp
{
    [Key]
    [Column("id_pps")]
    public int IdPps { get; set; }

    [Column("id_prj_pps")]
    public int IdPrjPps { get; set; }

    [Column("pl1_pps")]
    public int Pl1Pps { get; set; }

    [Column("pm1_pps")]
    public int Pm1Pps { get; set; }

    [Column("pl2_pps")]
    public int Pl2Pps { get; set; }

    [Column("pm2_pps")]
    public int Pm2Pps { get; set; }

    [Column("pl3_pps")]
    public int Pl3Pps { get; set; }

    [Column("pm3_pps")]
    public int Pm3Pps { get; set; }

    [Column("pl4_pps")]
    public int Pl4Pps { get; set; }

    [Column("pm4_pps")]
    public int Pm4Pps { get; set; }

    [Column("pl5_pps")]
    public int Pl5Pps { get; set; }

    [Column("pm5_pps")]
    public int Pm5Pps { get; set; }

    [Column("pl6_pps")]
    public int Pl6Pps { get; set; }

    [Column("pm6_pps")]
    public int Pm6Pps { get; set; }

    [Column("pl7_pps")]
    public int Pl7Pps { get; set; }

    [Column("pm7_pps")]
    public int Pm7Pps { get; set; }

    [Column("pl8_pps")]
    public int Pl8Pps { get; set; }

    [Column("pm8_pps")]
    public int Pm8Pps { get; set; }

    [Column("pl9_pps")]
    public int Pl9Pps { get; set; }

    [Column("pm9_pps")]
    public int Pm9Pps { get; set; }

    [Column("pl10_pps")]
    public int Pl10Pps { get; set; }

    [Column("pm10_pps")]
    public int Pm10Pps { get; set; }

    [Column("pl11_pps")]
    public int Pl11Pps { get; set; }

    [Column("pm11_pps")]
    public int Pm11Pps { get; set; }

    [Column("pl12_pps")]
    public int Pl12Pps { get; set; }

    [Column("pm12_pps")]
    public int Pm12Pps { get; set; }

    [Column("pl13_pps")]
    public int Pl13Pps { get; set; }

    [Column("pm13_pps")]
    public int Pm13Pps { get; set; }

    [Column("pl14_pps")]
    public int Pl14Pps { get; set; }

    [Column("pm14_pps")]
    public int Pm14Pps { get; set; }

    [Column("pl15_pps")]
    public int Pl15Pps { get; set; }

    [Column("pm15_pps")]
    public int Pm15Pps { get; set; }

    [Column("pl16_pps")]
    public int Pl16Pps { get; set; }

    [Column("pm16_pps")]
    public int Pm16Pps { get; set; }

    [Column("com1_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com1Pps { get; set; } = null!;

    [Column("com2_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com2Pps { get; set; } = null!;

    [Column("com3_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com3Pps { get; set; } = null!;

    [Column("com4_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com4Pps { get; set; } = null!;

    [Column("com5_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com5Pps { get; set; } = null!;

    [Column("com6_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com6Pps { get; set; } = null!;

    [Column("com7_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com7Pps { get; set; } = null!;

    [Column("com8_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com8Pps { get; set; } = null!;

    [Column("com9_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com9Pps { get; set; } = null!;

    [Column("com10_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com10Pps { get; set; } = null!;

    [Column("com11_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com11Pps { get; set; } = null!;

    [Column("com12_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com12Pps { get; set; } = null!;

    [Column("com13_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com13Pps { get; set; } = null!;

    [Column("com14_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com14Pps { get; set; } = null!;

    [Column("com15_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com15Pps { get; set; } = null!;

    [Column("com16_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string Com16Pps { get; set; } = null!;

    [Column("is_flowlineremoval_pps")]
    public int IsFlowlineremovalPps { get; set; }

    [Column("is_gravremoval_pps")]
    public int IsGravremovalPps { get; set; }

    [Column("is_ccremoval_pps")]
    public int IsCcremovalPps { get; set; }

    [Column("is_anchorremoval_pps")]
    public int IsAnchorremovalPps { get; set; }

    [Column("is_debrisremoval_pps")]
    public int IsDebrisremovalPps { get; set; }

    [Column("is_tdclosure_pps")]
    public int IsTdclosurePps { get; set; }

    [Column("is_pitclosure_pps")]
    public int IsPitclosurePps { get; set; }

    [Column("is_lroadremoval_pps")]
    public int IsLroadremovalPps { get; set; }

    [Column("is_locationremoval_pps")]
    public int IsLocationremovalPps { get; set; }

    [Column("is_tankremoval_pps")]
    public int IsTankremovalPps { get; set; }

    [Column("is_sa_pps")]
    public int IsSaPps { get; set; }

    [Column("is_hydro_pps")]
    public int IsHydroPps { get; set; }

    [Column("is_whcla_pps")]
    public int IsWhclaPps { get; set; }

    [Column("is_hydrolfc_pps")]
    public int IsHydrolfcPps { get; set; }

    [Column("is_hydroremoval_pps")]
    public int IsHydroremovalPps { get; set; }

    [Column("is_pond_pps")]
    public int IsPondPps { get; set; }

    [Column("is_drystructure_pps")]
    public int IsDrystructurePps { get; set; }

    [Column("is_terrace_pps")]
    public int IsTerracePps { get; set; }

    [Column("is_grading_pps")]
    public int IsGradingPps { get; set; }

    [Column("is_scb_pps")]
    public int IsScbPps { get; set; }

    [Column("is_fenceremoval_pps")]
    public int IsFenceremovalPps { get; set; }

    [Column("is_planting_pps")]
    public int IsPlantingPps { get; set; }

    [Column("is_attachments_pps")]
    public int IsAttachmentsPps { get; set; }

    [Column("is_pitclosurewater_pps")]
    public int IsPitclosurewaterPps { get; set; }

    [Column("is_tankbatterypadremoval_pps")]
    public int IsTankbatterypadremovalPps { get; set; }

    [Column("indsitenotes_pps")]
    [StringLength(2048)]
    [Unicode(false)]
    public string? IndsitenotesPps { get; set; }

    [Column("hydrocounty_pps")]
    [StringLength(20)]
    [Unicode(false)]
    public string? HydrocountyPps { get; set; }

    [Column("pl17_pps")]
    public int Pl17Pps { get; set; }

    [Column("pm17_pps")]
    public int Pm17Pps { get; set; }

    [Column("com17_pps")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Com17Pps { get; set; }

    [Column("pl18_pps")]
    public int Pl18Pps { get; set; }

    [Column("pm18_pps")]
    public int Pm18Pps { get; set; }

    [Column("is_waterway_pps")]
    public int IsWaterwayPps { get; set; }
}
