using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("contractor_ctr")]
public partial class ContractorCtr
{
    [Key]
    [Column("id_ctr")]
    public int IdCtr { get; set; }

    [Column("date_movedinactive_ctr")]
    [StringLength(16)]
    [Unicode(false)]
    public string? DateMovedinactiveCtr { get; set; }

    [Column("date_removed_ctr")]
    [StringLength(16)]
    [Unicode(false)]
    public string? DateRemovedCtr { get; set; }

    [Column("date_added_ctr")]
    [StringLength(16)]
    [Unicode(false)]
    public string? DateAddedCtr { get; set; }

    [Column("contractorname_ctr")]
    [StringLength(128)]
    [Unicode(false)]
    public string? ContractornameCtr { get; set; }

    [Column("feinssn_ctr")]
    [StringLength(16)]
    [Unicode(false)]
    public string? FeinssnCtr { get; set; }

    [Column("address_ctr")]
    [StringLength(255)]
    [Unicode(false)]
    public string? AddressCtr { get; set; }

    [Column("city_ctr")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CityCtr { get; set; }

    [Column("state_ctr")]
    [StringLength(2)]
    [Unicode(false)]
    public string? StateCtr { get; set; }

    [Column("zip_ctr")]
    [StringLength(12)]
    [Unicode(false)]
    public string? ZipCtr { get; set; }

    [Column("county_ctr")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CountyCtr { get; set; }

    [Column("phone_ctr")]
    [StringLength(16)]
    [Unicode(false)]
    public string? PhoneCtr { get; set; }

    [Column("fax_ctr")]
    [StringLength(16)]
    [Unicode(false)]
    public string? FaxCtr { get; set; }

    [Column("mobile_ctr")]
    [StringLength(16)]
    [Unicode(false)]
    public string? MobileCtr { get; set; }

    [Column("firstname_ctr")]
    [StringLength(32)]
    [Unicode(false)]
    public string? FirstnameCtr { get; set; }

    [Column("lastname_ctr")]
    [StringLength(32)]
    [Unicode(false)]
    public string? LastnameCtr { get; set; }

    [Column("email_ctr")]
    [StringLength(64)]
    [Unicode(false)]
    public string? EmailCtr { get; set; }

    [Column("comments_ctr")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CommentsCtr { get; set; }

    [Column("is_active_ctr")]
    public int? IsActiveCtr { get; set; }

    [Column("is_legacy_ctr")]
    public int? IsLegacyCtr { get; set; }

    [Column("districts_ctr")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? DistrictsCtr { get; set; }

    [Column("registrationlink_ctr")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? RegistrationlinkCtr { get; set; }

    [Column("correspondencelink_ctr")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CorrespondencelinkCtr { get; set; }

    [Column("onlineregistration_ctr")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? OnlineregistrationCtr { get; set; }

    [Column("is_gcnorth_ctr")]
    public int? IsGcnorthCtr { get; set; }

    [Column("is_gcsouth_ctr")]
    public int? IsGcsouthCtr { get; set; }

    [Column("is_jdnorth_ctr")]
    public int? IsJdnorthCtr { get; set; }

    [Column("is_jdnorthwest_ctr")]
    public int? IsJdnorthwestCtr { get; set; }

    [Column("is_jdokc_ctr")]
    public int? IsJdokcCtr { get; set; }

    [Column("is_jdsc_ctr")]
    public int? IsJdscCtr { get; set; }

    [Column("is_rtcentral_ctr")]
    public int? IsRtcentralCtr { get; set; }

    [Column("is_rtsouthwest_ctr")]
    public int? IsRtsouthwestCtr { get; set; }

    [Column("is_soilamendment_ctr")]
    public int? IsSoilamendmentCtr { get; set; }

    [Column("is_sprigging_ctr")]
    public int? IsSpriggingCtr { get; set; }

    [Column("add_date_ctr")]
    public DateTime AddDateCtr { get; set; }
}
