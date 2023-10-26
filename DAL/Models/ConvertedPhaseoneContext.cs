using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class ConvertedPhaseoneContext : DbContext
{
    public ConvertedPhaseoneContext()
    {
    }

    public ConvertedPhaseoneContext(DbContextOptions<ConvertedPhaseoneContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActionitemAct> ActionitemActs { get; set; }

    public virtual DbSet<AmendAmd> AmendAmds { get; set; }

    public virtual DbSet<BackupBkp> BackupBkps { get; set; }

    public virtual DbSet<BeacitemsBeac> BeacitemsBeacs { get; set; }

    public virtual DbSet<BidBid> BidBids { get; set; }

    public virtual DbSet<BidcontractBcon> BidcontractBcons { get; set; }

    public virtual DbSet<BmsfilterBmf> BmsfilterBmfs { get; set; }

    public virtual DbSet<ContractCon> ContractCons { get; set; }

    public virtual DbSet<ContractorCtr> ContractorCtrs { get; set; }

    public virtual DbSet<ExpensesExp> ExpensesExps { get; set; }

    public virtual DbSet<FollowupFol> FollowupFols { get; set; }

    public virtual DbSet<ImagesImg> ImagesImgs { get; set; }

    public virtual DbSet<InspectorIn> InspectorIns { get; set; }

    public virtual DbSet<IssuesIss> IssuesIsses { get; set; }

    public virtual DbSet<ItemsItm> ItemsItms { get; set; }

    public virtual DbSet<LandownerLo> LandownerLos { get; set; }

    public virtual DbSet<MaprequestMap> MaprequestMaps { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<OperatorlinkOprlink> OperatorlinkOprlinks { get; set; }

    public virtual DbSet<OperatorsOpr> OperatorsOprs { get; set; }

    public virtual DbSet<PalmasterPrj> PalmasterPrjs { get; set; }

    public virtual DbSet<PondPnd> PondPnds { get; set; }

    public virtual DbSet<PrepsheetPp> PrepsheetPps { get; set; }

    public virtual DbSet<ProjectPrj> ProjectPrjs { get; set; }

    public virtual DbSet<QryMaster1> QryMaster1s { get; set; }

    public virtual DbSet<QryMaster2> QryMaster2s { get; set; }

    public virtual DbSet<RoeitemRoe> RoeitemRoes { get; set; }

    public virtual DbSet<SampleSmp> SampleSmps { get; set; }

    public virtual DbSet<SiteSte> SiteStes { get; set; }

    public virtual DbSet<SoilSl> SoilSls { get; set; }

    public virtual DbSet<TerraceTer> TerraceTers { get; set; }

    public virtual DbSet<VerbalRov> VerbalRovs { get; set; }

    public virtual DbSet<Vwprojcalc> Vwprojcalcs { get; set; }

    public virtual DbSet<WaterwayWtr> WaterwayWtrs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Converted_phaseone;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActionitemAct>(entity =>
        {
            entity.HasKey(e => e.IdAct).HasName("PK__actionit__6BE8F05574566843");

            entity.Property(e => e.IdAct).ValueGeneratedNever();
            entity.Property(e => e.StatusAct).HasDefaultValueSql("('Active')");
        });

        modelBuilder.Entity<AmendAmd>(entity =>
        {
            entity.HasKey(e => e.IdAmd).HasName("PK__amend_am__6BE903AD423F9F42");

            entity.Property(e => e.IdAmd).ValueGeneratedNever();
            entity.Property(e => e.AcreageAmd).HasDefaultValueSql("('null')");
        });

        modelBuilder.Entity<BackupBkp>(entity =>
        {
            entity.HasKey(e => e.IdBkp).HasName("PK__backup_b__D506D968994B5F41");

            entity.Property(e => e.IdBkp).ValueGeneratedNever();
            entity.Property(e => e.BackuptimeBkp).HasDefaultValueSql("('0000-00-00 00:00:00')");
        });

        modelBuilder.Entity<BeacitemsBeac>(entity =>
        {
            entity.HasKey(e => e.IdBeac).HasName("PK__beacitem__C467561C0FBB8378");

            entity.Property(e => e.IdBeac).ValueGeneratedNever();
        });

        modelBuilder.Entity<BidBid>(entity =>
        {
            entity.HasKey(e => e.IdBid).HasName("PK__bid_bid__D50747B9D3BD312B");

            entity.Property(e => e.IdBid).ValueGeneratedNever();
            entity.Property(e => e.PartA1valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartA2valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartA3valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartB1valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartB2valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartC1valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartC2valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartD1valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartD2valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartE1valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartE2valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartF1valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PartF2valueBid).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.TotalbaseBid).HasDefaultValueSql("('NULL')");
        });

        modelBuilder.Entity<BidcontractBcon>(entity =>
        {
            entity.HasKey(e => e.IdBcon).HasName("PK__bidcontr__DBD0B42502712F86");

            entity.Property(e => e.IdBcon).ValueGeneratedNever();
            entity.Property(e => e.FinalpaymentBcon).HasDefaultValueSql("('null')");
            entity.Property(e => e.IsApprovedbidsBcon).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsApprovedcontractBcon).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsAttendanceBcon).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsConsultantBcon).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsContractorBcon).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsMailedaddBcon).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsMindyapprovedBcon).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsOwnerBcon).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsPmapprovedBcon).HasDefaultValueSql("((0))");
            entity.Property(e => e.PartialpaymentBcon).HasDefaultValueSql("('null')");
        });

        modelBuilder.Entity<BmsfilterBmf>(entity =>
        {
            entity.HasKey(e => e.IdBmf).HasName("PK__bmsfilte__D5072930DA6D6737");

            entity.Property(e => e.IdBmf).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractCon>(entity =>
        {
            entity.HasKey(e => e.IdCon).HasName("PK__contract__D6967176220F834B");

            entity.Property(e => e.IdCon).ValueGeneratedNever();
            entity.Property(e => e.Alt1valueCon).HasDefaultValueSql("('null')");
            entity.Property(e => e.Alt2valueCon).HasDefaultValueSql("('null')");
            entity.Property(e => e.Alt3valueCon).HasDefaultValueSql("('null')");
            entity.Property(e => e.Alt4valueCon).HasDefaultValueSql("('null')");
            entity.Property(e => e.Up1valueCon).HasDefaultValueSql("('null')");
            entity.Property(e => e.Up2valueCon).HasDefaultValueSql("('null')");
            entity.Property(e => e.Up3valueCon).HasDefaultValueSql("('null')");
            entity.Property(e => e.Up4valueCon).HasDefaultValueSql("('null')");
            entity.Property(e => e.Up5valueCon).HasDefaultValueSql("('null')");
            entity.Property(e => e.Up6valueCon).HasDefaultValueSql("('null')");
        });

        modelBuilder.Entity<ContractorCtr>(entity =>
        {
            entity.HasKey(e => e.IdCtr).HasName("PK__contract__D696DA0C27044F1B");

            entity.Property(e => e.IdCtr).ValueGeneratedNever();
        });

        modelBuilder.Entity<ExpensesExp>(entity =>
        {
            entity.HasKey(e => e.IdExp).HasName("PK__expenses__D52A8F55B718FF62");

            entity.Property(e => e.IdExp).ValueGeneratedNever();
        });

        modelBuilder.Entity<FollowupFol>(entity =>
        {
            entity.HasKey(e => e.IdFol).HasName("PK__followup__D6567E67A1BEABB1");

            entity.Property(e => e.IdFol).ValueGeneratedNever();
        });

        modelBuilder.Entity<ImagesImg>(entity =>
        {
            entity.HasKey(e => e.IdSteImg).HasName("PK__images_i__092942CCA74D5FF7");

            entity.Property(e => e.IdSteImg).ValueGeneratedNever();
        });

        modelBuilder.Entity<InspectorIn>(entity =>
        {
            entity.HasKey(e => e.IdIns).HasName("PK__inspecto__D62AAFCE4CCAB8FB");

            entity.Property(e => e.IdIns).ValueGeneratedNever();
        });

        modelBuilder.Entity<IssuesIss>(entity =>
        {
            entity.HasKey(e => e.IdIss).HasName("PK__issues_i__D62AD7F069F9FBD3");

            entity.Property(e => e.IdIss).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemsItm>(entity =>
        {
            entity.HasKey(e => e.IdItm).HasName("PK__items_it__D62ADF976F853B22");

            entity.Property(e => e.IdItm).ValueGeneratedNever();
        });

        modelBuilder.Entity<LandownerLo>(entity =>
        {
            entity.HasKey(e => e.IdLo).HasName("PK__landowne__014883C6470AAACF");

            entity.Property(e => e.IdLo).ValueGeneratedNever();
        });

        modelBuilder.Entity<MaprequestMap>(entity =>
        {
            entity.HasKey(e => e.IdMap).HasName("PK__mapreque__6C8AD5BF9B4597AA");

            entity.Property(e => e.IdMap).ValueGeneratedNever();
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__members__7FD7CFF6BBF095F5");

            entity.Property(e => e.MemberId).ValueGeneratedNever();
            entity.Property(e => e.ResetComplete).HasDefaultValueSql("('No')");
        });

        modelBuilder.Entity<OperatorlinkOprlink>(entity =>
        {
            entity.HasKey(e => e.IdOprlink).HasName("PK__operator__491DB4BCDCB569C1");

            entity.Property(e => e.IdOprlink).ValueGeneratedNever();
            entity.Property(e => e.ReceivedOprlink).HasDefaultValueSql("('No')");
        });

        modelBuilder.Entity<OperatorsOpr>(entity =>
        {
            entity.HasKey(e => e.IdOpr).HasName("PK__operator__6E0C4FC68344DB5B");

            entity.Property(e => e.IdOpr).ValueGeneratedNever();
        });

        modelBuilder.Entity<PalmasterPrj>(entity =>
        {
            entity.HasKey(e => e.IdPrj).HasName("PK__palmaste__6FC9A853D4E082DA");

            entity.Property(e => e.IdPrj).ValueGeneratedNever();
            entity.Property(e => e.BidPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.EstimatePrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.IsAssignedPrj).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsLegacyPrj).HasDefaultValueSql("((0))");
            entity.Property(e => e.LaareaPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LaestPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LaureaPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LfcareaPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LfcestPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LfcureaPrj).HasDefaultValueSql("('null')");
        });

        modelBuilder.Entity<PondPnd>(entity =>
        {
            entity.HasKey(e => e.IdPnd).HasName("PK__pond_pnd__6FC80AD65C1F6B0C");

            entity.Property(e => e.IdPnd).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrepsheetPp>(entity =>
        {
            entity.HasKey(e => e.IdPps).HasName("PK__prepshee__6FC859AA5B23F3E3");

            entity.Property(e => e.IdPps).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProjectPrj>(entity =>
        {
            entity.HasKey(e => e.IdPrj).HasName("PK__project___6FC9A8532265A03C");

            entity.Property(e => e.IdPrj).ValueGeneratedNever();
            entity.Property(e => e.BidPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.ChangeorderPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.EstimatePrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.IsAssignedPrj).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsLegacyPrj).HasDefaultValueSql("((0))");
            entity.Property(e => e.LaareaPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LaestPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LatitudePrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LatsecPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LaureaPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LfcareaPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LfcestPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LfcureaPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LongitudePrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.LongsecPrj).HasDefaultValueSql("('null')");
            entity.Property(e => e.ProposedchangeorderPrj).HasDefaultValueSql("('null')");
        });

        modelBuilder.Entity<QryMaster1>(entity =>
        {
            entity.Property(e => e.Examount).HasDefaultValueSql("('null')");
        });

        modelBuilder.Entity<QryMaster2>(entity =>
        {
            entity.Property(e => e.Examount).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.Exdate).HasDefaultValueSql("('0000-00-00 00:00:00')");
            entity.Property(e => e.Oerbdate).HasDefaultValueSql("('0000-00-00 00:00:00')");
        });

        modelBuilder.Entity<RoeitemRoe>(entity =>
        {
            entity.HasKey(e => e.IdAct).HasName("PK__roeitem___6BE8F0551C35599E");

            entity.Property(e => e.IdAct).ValueGeneratedNever();
        });

        modelBuilder.Entity<SampleSmp>(entity =>
        {
            entity.HasKey(e => e.IdSmp).HasName("PK__sample_s__6D6C62282A699E42");

            entity.Property(e => e.IdSmp).ValueGeneratedNever();
        });

        modelBuilder.Entity<SiteSte>(entity =>
        {
            entity.HasKey(e => e.IdSte).HasName("PK__site_ste__6D6CDB34C15B8A57");

            entity.Property(e => e.IdSte).ValueGeneratedNever();
            entity.Property(e => e.CreationdatetimeSte).HasDefaultValueSql("('0000-00-00 00:00:00')");
            entity.Property(e => e.DenudedareaSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.EpochSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.ErosionhaySte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.GabionfabricSte).HasDefaultValueSql("('null')");
            entity.Property(e => e.GradeareaSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.GradehaystrawSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.GypsumtpaSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.HydrovolSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.HydrowhcdepthSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.LaareaSte).HasDefaultValueSql("('null')");
            entity.Property(e => e.LaestSte).HasDefaultValueSql("('null')");
            entity.Property(e => e.LahaySte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.LaureaSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.LfcareaSte).HasDefaultValueSql("('null')");
            entity.Property(e => e.LfcestSte).HasDefaultValueSql("('null')");
            entity.Property(e => e.LfchaySte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.LfcureaSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.NitrogenSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.OrganicSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PhosphorousSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.PotassiumSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.SagypsumtpaSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.SedcontrolestSte).HasDefaultValueSql("('null')");
            entity.Property(e => e.SedcontrollenSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.TanksoilbarrelsSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.TanksswbarrelsSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.TdareaSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.TerracelenSte).HasDefaultValueSql("('NULL')");
            entity.Property(e => e.TerraceslopeSte).HasDefaultValueSql("('NULL')");
        });

        modelBuilder.Entity<SoilSl>(entity =>
        {
            entity.HasKey(e => e.IdSl).HasName("PK__soil_sl__014858E3B074D01A");

            entity.Property(e => e.IdSl).ValueGeneratedNever();
        });

        modelBuilder.Entity<TerraceTer>(entity =>
        {
            entity.HasKey(e => e.IdTer).HasName("PK__terrace___6A29A7794EFC8E75");

            entity.Property(e => e.IdTer).ValueGeneratedNever();
            entity.Property(e => e.LengthTer).HasDefaultValueSql("('null')");
        });

        modelBuilder.Entity<VerbalRov>(entity =>
        {
            entity.HasKey(e => e.IdRov).HasName("PK__verbal_r__6ABCB5F69B679348");

            entity.Property(e => e.IdRov).ValueGeneratedNever();
        });

        modelBuilder.Entity<Vwprojcalc>(entity =>
        {
            entity.Property(e => e.Calcbid).HasDefaultValueSql("('null')");
        });

        modelBuilder.Entity<WaterwayWtr>(entity =>
        {
            entity.HasKey(e => e.IdWtr).HasName("PK__waterway__6C6C2B4F2E78D2B3");

            entity.Property(e => e.IdWtr).ValueGeneratedNever();
            entity.Property(e => e.SodWtr).HasDefaultValueSql("('null')");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
