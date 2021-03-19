using Microsoft.EntityFrameworkCore;
using MPS_API.Models;

namespace MPS_API.Data
{
    public partial class ServerContext : DbContext
    {
        public virtual DbSet<HP_ie27_1> HP_ie27_1 { get; set; }
        public virtual DbSet<HP_ie32t> HP_ie32t { get; set; }
        public virtual DbSet<HP_ie34_log> HP_ie34_log { get; set; }
        public virtual DbSet<HP_j02> HP_j02 { get; set; }
        public virtual DbSet<HP_n47_e> HP_n47_e { get; set; }
        public virtual DbSet<MPS_Basic_Code_List> MPS_Basic_Code_List { get; set; }
        public virtual DbSet<MPS_Basic_LastFormNo_Record> MPS_Basic_LastFormNo_Record { get; set; }
        public virtual DbSet<MPS_Basic_UserAutho> MPS_Basic_UserAutho { get; set; }
        public virtual DbSet<MPS_Cmpt_FBSection_TotQty> MPS_Cmpt_FBSection_TotQty { get; set; }
        public virtual DbSet<MPS_Cmpt_Process_FeedbackStage> MPS_Cmpt_Process_FeedbackStage { get; set; }
        public virtual DbSet<MPS_Cmpt_Process_Workstation> MPS_Cmpt_Process_Workstation { get; set; }
        public virtual DbSet<MPS_Cmpt_Shift_Quantity> MPS_Cmpt_Shift_Quantity { get; set; }
        public virtual DbSet<MPS_Cmpt_T1T3_351Receipt> MPS_Cmpt_T1T3_351Receipt { get; set; }
        public virtual DbSet<MPS_Cmpt_Transaction_Detail> MPS_Cmpt_Transaction_Detail { get; set; }
        public virtual DbSet<MPS_Cmpt_Transaction_FBBy> MPS_Cmpt_Transaction_FBBy { get; set; }
        public virtual DbSet<MPS_Cmpt_Transaction_Summary> MPS_Cmpt_Transaction_Summary { get; set; }
        public virtual DbSet<MPS_Cmpt_Workstation> MPS_Cmpt_Workstation { get; set; }
        public virtual DbSet<MPS_Dispatch_Area> MPS_Dispatch_Area { get; set; }
        public virtual DbSet<MPS_Material_Replenish> MPS_Material_Replenish { get; set; }
        public virtual DbSet<MPS_Material_Replenish_Collect> MPS_Material_Replenish_Collect { get; set; }
        public virtual DbSet<MPS_Replenish_Cancel_Code> MPS_Replenish_Cancel_Code { get; set; }
        public virtual DbSet<MPS_Replenish_Check_Record> MPS_Replenish_Check_Record { get; set; }
        public virtual DbSet<MPS_Replenish_Claim_Detail> MPS_Replenish_Claim_Detail { get; set; }
        public virtual DbSet<MPS_Replenish_Collect> MPS_Replenish_Collect { get; set; }
        public virtual DbSet<MPS_Replenish_PB3A4> MPS_Replenish_PB3A4 { get; set; }
        public virtual DbSet<MPS_Replenish_Status_Detail> MPS_Replenish_Status_Detail { get; set; }
        public virtual DbSet<TAutho> TAutho { get; set; }
        public virtual DbSet<TAuthoList> TAuthoList { get; set; }
        public virtual DbSet<TAuthoPickupForm> TAuthoPickupForm { get; set; }
        public virtual DbSet<TCMS_IEPKList> TCMS_IEPKList { get; set; }
        public virtual DbSet<TCMS_IEPKList_Log> TCMS_IEPKList_Log { get; set; }
        public virtual DbSet<TCentralCall> TCentralCall { get; set; }
        public virtual DbSet<TCentralDispatch> TCentralDispatch { get; set; }
        public virtual DbSet<TCentralKind> TCentralKind { get; set; }
        public virtual DbSet<TCentralPrepare> TCentralPrepare { get; set; }
        public virtual DbSet<TCentralSize> TCentralSize { get; set; }
        public virtual DbSet<TCentralUpload> TCentralUpload { get; set; }
        public virtual DbSet<THPi14a> THPi14a { get; set; }
        public virtual DbSet<THPie83> THPie83 { get; set; }
        public virtual DbSet<THPn15_4> THPn15_4 { get; set; }
        public virtual DbSet<TIE24> TIE24 { get; set; }
        public virtual DbSet<TIE25> TIE25 { get; set; }
        public virtual DbSet<TIPAuthorization> TIPAuthorization { get; set; }
        public virtual DbSet<TMenu> TMenu { get; set; }
        public virtual DbSet<TNotice> TNotice { get; set; }
        public virtual DbSet<TOrg> TOrg { get; set; }
        public virtual DbSet<TPOInfo> TPOInfo { get; set; }
        public virtual DbSet<TPartPrepareDates> TPartPrepareDates { get; set; }
        public virtual DbSet<TPartPrepareQtys> TPartPrepareQtys { get; set; }
        public virtual DbSet<TPickupForm> TPickupForm { get; set; }
        public virtual DbSet<TPickupFormKind> TPickupFormKind { get; set; }
        public virtual DbSet<TPickupFormStatus> TPickupFormStatus { get; set; }
        public virtual DbSet<TSettings> TSettings { get; set; }
        public virtual DbSet<Tie29> Tie29 { get; set; }
        public virtual DbSet<VCentralize> VCentralize { get; set; }
        public virtual DbSet<VCustomerOrder> VCustomerOrder { get; set; }
        public virtual DbSet<VManno> VManno { get; set; }
        public virtual DbSet<VMannoSet> VMannoSet { get; set; }
        public virtual DbSet<VOrderDeptLastProductionDate> VOrderDeptLastProductionDate { get; set; }
        public virtual DbSet<VPartialPreparationDet> VPartialPreparationDet { get; set; }
        public virtual DbSet<VPickupScan> VPickupScan { get; set; }
        public virtual DbSet<VPickupStatus> VPickupStatus { get; set; }
        public virtual DbSet<VTimeSquad> VTimeSquad { get; set; }
        public virtual DbSet<VW_Cmpt_FBSection_TotQty_Detail> VW_Cmpt_FBSection_TotQty_Detail { get; set; }
        public virtual DbSet<VW_Cmpt_Feedback_POList> VW_Cmpt_Feedback_POList { get; set; }
        public virtual DbSet<VW_Cmpt_Feedback_POList_WithSetS3> VW_Cmpt_Feedback_POList_WithSetS3 { get; set; }
        public virtual DbSet<VW_Cmpt_Process_FeedbackStage> VW_Cmpt_Process_FeedbackStage { get; set; }
        public virtual DbSet<VW_Cmpt_Process_PlanTransaction_POBatch> VW_Cmpt_Process_PlanTransaction_POBatch { get; set; }
        public virtual DbSet<VW_Cmpt_Summary_MaxBalance_ByWorkshop> VW_Cmpt_Summary_MaxBalance_ByWorkshop { get; set; }
        public virtual DbSet<VW_Cmpt_Summary_WorkshopSpin> VW_Cmpt_Summary_WorkshopSpin { get; set; }
        public virtual DbSet<VW_Cmpt_TransList_ForWIP> VW_Cmpt_TransList_ForWIP { get; set; }
        public virtual DbSet<VW_Cmpt_TransList_ForWIP_Source> VW_Cmpt_TransList_ForWIP_Source { get; set; }
        public virtual DbSet<VW_Cmpt_Transaction_Detail_POBatch> VW_Cmpt_Transaction_Detail_POBatch { get; set; }
        public virtual DbSet<VW_Cmpt_Transaction_Detail_POBatchSize> VW_Cmpt_Transaction_Detail_POBatchSize { get; set; }
        public virtual DbSet<VW_Cmpt_Transaction_Plus_351> VW_Cmpt_Transaction_Plus_351 { get; set; }
        public virtual DbSet<VW_Cmpt_Transaction_Summary_POBatch> VW_Cmpt_Transaction_Summary_POBatch { get; set; }
        public virtual DbSet<VW_Cmpt_Transaction_Summary_POBatchSize> VW_Cmpt_Transaction_Summary_POBatchSize { get; set; }
        public virtual DbSet<VW_Cmpt_Transaction_Summary_POBatchSize_DetailOrg> VW_Cmpt_Transaction_Summary_POBatchSize_DetailOrg { get; set; }
        public virtual DbSet<VW_Cmpt_Workstation_DailyTransaction> VW_Cmpt_Workstation_DailyTransaction { get; set; }
        public virtual DbSet<VW_Cmpt_ie32t_FeedbackStage> VW_Cmpt_ie32t_FeedbackStage { get; set; }
        public virtual DbSet<VW_EEP_FRIPO_EstExportDate> VW_EEP_FRIPO_EstExportDate { get; set; }
        public virtual DbSet<VW_HP32Vendor> VW_HP32Vendor { get; set; }
        public virtual DbSet<VW_HPBasis_HPCustomerBOM_j102> VW_HPBasis_HPCustomerBOM_j102 { get; set; }
        public virtual DbSet<VW_HPBasis_HPDept_n15> VW_HPBasis_HPDept_n15 { get; set; }
        public virtual DbSet<VW_HPBasis_HPMaterial_j13> VW_HPBasis_HPMaterial_j13 { get; set; }
        public virtual DbSet<VW_HPBasis_HPMonthlyEstimateProduceTarget_i14a> VW_HPBasis_HPMonthlyEstimateProduceTarget_i14a { get; set; }
        public virtual DbSet<VW_HPBasis_HPOutsourceProcess_n71> VW_HPBasis_HPOutsourceProcess_n71 { get; set; }
        public virtual DbSet<VW_HPBasis_HPPart_j06> VW_HPBasis_HPPart_j06 { get; set; }
        public virtual DbSet<VW_HPBasis_HPSquadTimeSequence_ie24> VW_HPBasis_HPSquadTimeSequence_ie24 { get; set; }
        public virtual DbSet<VW_HPBasis_HPUploadTime_ie27_1_log> VW_HPBasis_HPUploadTime_ie27_1_log { get; set; }
        public virtual DbSet<VW_HPBasis_HPVendor_u01> VW_HPBasis_HPVendor_u01 { get; set; }
        public virtual DbSet<VW_MES_CyclePlanQtyDetail> VW_MES_CyclePlanQtyDetail { get; set; }
        public virtual DbSet<VW_MES_MOBasic> VW_MES_MOBasic { get; set; }
        public virtual DbSet<VW_MES_Org_PDC> VW_MES_Org_PDC { get; set; }
        public virtual DbSet<VW_MES_POBatchOutputBalance> VW_MES_POBatchOutputBalance { get; set; }
        public virtual DbSet<VW_MES_POBatchSizePlanQty> VW_MES_POBatchSizePlanQty { get; set; }
        public virtual DbSet<VW_RackNET_Section_Setting> VW_RackNET_Section_Setting { get; set; }
        public virtual DbSet<vMergedPOPlan> vMergedPOPlan { get; set; }
        public virtual DbSet<vPOnMERGErelation> vPOnMERGErelation { get; set; }
        public virtual DbSet<vPOwithoutMerged> vPOwithoutMerged { get; set; }
        public virtual DbSet<vPUFCycleDetail> vPUFCycleDetail { get; set; }
        public virtual DbSet<vPUFDetailStatus> vPUFDetailStatus { get; set; }
        public virtual DbSet<vPUFnMERGErelation> vPUFnMERGErelation { get; set; }
        public virtual DbSet<vReplenishCheckLastDT> vReplenishCheckLastDT { get; set; }
        public virtual DbSet<vReplenishCheckSummary> vReplenishCheckSummary { get; set; }
        public virtual DbSet<vReplenishCheckSummary_2> vReplenishCheckSummary_2 { get; set; }
        public virtual DbSet<vReplenish_Collect_Detail> vReplenish_Collect_Detail { get; set; }
        public virtual DbSet<vReplenish_Each_Date_Detail> vReplenish_Each_Date_Detail { get; set; }
        public virtual DbSet<vReplenish_Each_Date_Detail_2> vReplenish_Each_Date_Detail_2 { get; set; }
        public virtual DbSet<vReplenish_SizePrint> vReplenish_SizePrint { get; set; }
        public virtual DbSet<vReplenish_SizePrint_2> vReplenish_SizePrint_2 { get; set; }

        public ServerContext(DbContextOptions<ServerContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CS_AS");

            modelBuilder.Entity<HP_ie27_1>(entity =>
            {
                entity.HasIndex(e => new { e.manuf, e.as_bdate })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.teamno, e.manno, e.seq })
                    .HasFillFactor((byte)80);

                entity.Property(e => e.manno).IsFixedLength(true);

                entity.Property(e => e.seq).IsFixedLength(true);

                entity.Property(e => e.manuf).IsFixedLength(true);

                entity.Property(e => e.as_btime).IsFixedLength(true);

                entity.Property(e => e.as_etime).IsFixedLength(true);

                entity.Property(e => e.cut_btime).IsFixedLength(true);

                entity.Property(e => e.cut_etime).IsFixedLength(true);

                entity.Property(e => e.kind).IsFixedLength(true);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.stfi_btime).IsFixedLength(true);

                entity.Property(e => e.stfi_etime).IsFixedLength(true);

                entity.Property(e => e.sti_btime).IsFixedLength(true);

                entity.Property(e => e.sti_etime).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);

                entity.Property(e => e.teamno).IsFixedLength(true);

                entity.Property(e => e.upusr).IsFixedLength(true);
            });

            modelBuilder.Entity<HP_ie32t>(entity =>
            {
                entity.HasKey(e => new { e.manuf, e.manno, e.seq, e.part, e.apart, e.code, e.itnbr, e.size });

                entity.Property(e => e.manuf).IsFixedLength(true);

                entity.Property(e => e.manno).IsFixedLength(true);

                entity.Property(e => e.seq).IsFixedLength(true);

                entity.Property(e => e.part).IsFixedLength(true);

                entity.Property(e => e.apart).IsFixedLength(true);

                entity.Property(e => e.code).IsFixedLength(true);

                entity.Property(e => e.itnbr)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.size).IsFixedLength(true);

                entity.Property(e => e.center).IsFixedLength(true);

                entity.Property(e => e.flag).IsFixedLength(true);

                entity.Property(e => e.tr_kind).IsFixedLength(true);

                entity.Property(e => e.trno).IsFixedLength(true);

                entity.Property(e => e.tsize).IsFixedLength(true);

                entity.Property(e => e.upusr).IsFixedLength(true);

                entity.Property(e => e.vendno).IsFixedLength(true);

                entity.Property(e => e.workno).IsFixedLength(true);

                entity.Property(e => e.workshop).IsFixedLength(true);
            });

            modelBuilder.Entity<HP_ie34_log>(entity =>
            {
                entity.HasKey(e => new { e.manuf, e.kind, e.trno });

                entity.Property(e => e.manuf)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.kind)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.trno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.manno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.seq)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.stat)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.upusr)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<HP_j02>(entity =>
            {
                entity.HasKey(e => new { e.codk, e.code });

                entity.Property(e => e.code).IsFixedLength(true);

                entity.Property(e => e.codmk).IsFixedLength(true);

                entity.Property(e => e.codsc).IsFixedLength(true);

                entity.Property(e => e.mark).IsFixedLength(true);

                entity.Property(e => e.upusr).IsFixedLength(true);
            });

            modelBuilder.Entity<HP_n47_e>(entity =>
            {
                entity.HasKey(e => new { e.manuf, e.exec_date, e.manno, e.seq });

                entity.Property(e => e.manuf)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.manno).IsUnicode(false);

                entity.Property(e => e.seq).IsUnicode(false);

                entity.Property(e => e.is_complete)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.stc_is_complete)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.stc_need_replenish)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.stf_is_complete)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.stf_need_replenish)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.teamno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.upusr)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Basic_Code_List>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Code_Kind)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Basic_LastFormNo_Record>(entity =>
            {
                entity.HasKey(e => new { e.Form_Kind, e.Form_No_Factor, e.Form_No_Factor_Value });

                entity.Property(e => e.Form_Kind)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Form_No_Factor).IsUnicode(false);

                entity.Property(e => e.Form_No_Factor_Value).IsUnicode(false);
            });

            modelBuilder.Entity<MPS_Basic_UserAutho>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Account).IsFixedLength(true);

                entity.Property(e => e.Autho_Kind).IsUnicode(false);

                entity.Property(e => e.Autho_Value).IsUnicode(false);
            });

            modelBuilder.Entity<MPS_Cmpt_FBSection_TotQty>(entity =>
            {
                entity.HasKey(e => new { e.MO_No, e.MO_Batch, e.Process_No, e.Internal_Part_No, e.MO_Size, e.Kind });

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Internal_Part_No).IsFixedLength(true);

                entity.Property(e => e.MO_Size)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Section).IsFixedLength(true);

                entity.Property(e => e.Supplier_No).IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Cmpt_Process_FeedbackStage>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Cmpt_Process_Workstation>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Workstation)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Cmpt_Shift_Quantity>(entity =>
            {
                entity.HasKey(e => new { e.Shift_No, e.MO_No, e.MO_Batch, e.Process_No, e.Internal_Part_No, e.MO_Size, e.Kind });

                entity.Property(e => e.Shift_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Size)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.External_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_Material_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Shift_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Tooling_Size)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Cmpt_T1T3_351Receipt>(entity =>
            {
                entity.HasIndex(e => new { e.T1_Receipt_Date, e.T3_Shipment_No, e.T1_Purchase_No, e.MO_No, e.MO_Batch, e.Supplier_No, e.Process_No, e.Internal_Part_No, e.MO_Size, e.Purchase_Kind })
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Size)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_Material_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Purchase_Kind)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("1. 正批 ; 4. 補料");

                entity.Property(e => e.Supplier_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.T1_Purchase_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.T3_Shipment_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Cmpt_Transaction_Detail>(entity =>
            {
                entity.HasIndex(e => e.Transaction_Date)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.MO_No, e.MO_Batch })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Feedback_Stage, e.MO_No, e.MO_Batch, e.Process_No, e.Process_Material_No, e.Internal_Part_No })
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.External_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Sequence)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Size)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_Material_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Tooling_Size)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Work_Shift)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Cmpt_Transaction_FBBy>(entity =>
            {
                entity.HasIndex(e => new { e.MO_No, e.MO_Batch, e.MO_Sequence, e.Process_No, e.Internal_Part_No, e.Process_Material_No, e.Feedback_Stage })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Refer_Transaction_No)
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Feedback_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Sequence)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Size)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_Material_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Refer_Transaction_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Cmpt_Transaction_Summary>(entity =>
            {
                entity.Property(e => e.Transaction_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Processing_Finish_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Processing_Last_Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Cmpt_Workstation>(entity =>
            {
                entity.HasIndex(e => new { e.Factory_Code, e.TreatmentDept_Code, e.Build_Code, e.TreatmentGroup_Code, e.WorkstationType_Code, e.Workstation_Seq })
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Asset_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Build_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Factory_Code).IsUnicode(false);

                entity.Property(e => e.TreatmentDept_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TreatmentGroup_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.WorkstationType_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Workstation_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Workstation_Desc).IsUnicode(false);

                entity.Property(e => e.Workstation_Seq)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Dispatch_Area>(entity =>
            {
                entity.Property(e => e.Area_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Area_Name).IsUnicode(false);

                entity.Property(e => e.isActive)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Material_Replenish>(entity =>
            {
                entity.HasKey(e => new { e.Replenish_No, e.Part, e.Material_ID, e.MO_No, e.Size, e.Cause, e.Replenish_Count });

                entity.HasComment("材料準備系統－補料");

                entity.Property(e => e.Replenish_No)
                    .IsUnicode(false)
                    .HasComment("開補單號");

                entity.Property(e => e.Part)
                    .IsUnicode(false)
                    .HasComment("部位");

                entity.Property(e => e.Material_ID)
                    .IsUnicode(false)
                    .HasComment("材料");

                entity.Property(e => e.MO_No)
                    .IsUnicode(false)
                    .HasComment("企劃單號");

                entity.Property(e => e.Size)
                    .IsUnicode(false)
                    .HasComment("尺寸");

                entity.Property(e => e.Cause)
                    .IsUnicode(false)
                    .HasComment("原因");

                entity.Property(e => e.Replenish_Count).HasComment("補鞋次數");

                entity.Property(e => e.Biz_Tflag)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("biztalk轉入方式");

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .HasComment("部門");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .HasComment("廠別");

                entity.Property(e => e.HP_Date).HasComment("HP異動日");

                entity.Property(e => e.HP_User)
                    .IsUnicode(false)
                    .HasComment("HP異動者");

                entity.Property(e => e.Mark)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("備註");

                entity.Property(e => e.Material_Sheet_No)
                    .IsUnicode(false)
                    .HasComment("發料單號");

                entity.Property(e => e.Material_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("材料區分");

                entity.Property(e => e.Pairs).HasComment("雙數");

                entity.Property(e => e.Qty).HasComment("數量");

                entity.Property(e => e.Replenish_Date).HasComment("開補日期");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')")
                    .IsFixedLength(true)
                    .HasComment("狀態");

                entity.Property(e => e.Unit_Qty).HasComment("單位用量");

                entity.Property(e => e.Update_By)
                    .IsUnicode(false)
                    .HasComment("異動者");

                entity.Property(e => e.Update_Time).HasComment("異動日");

                entity.Property(e => e.Warehouse_ID)
                    .IsUnicode(false)
                    .HasComment("庫別");
            });

            modelBuilder.Entity<MPS_Material_Replenish_Collect>(entity =>
            {
                entity.HasKey(e => new { e.Collect_No, e.Material_Sheet_No });

                entity.HasComment("材料準備系統—補料彙總");

                entity.Property(e => e.Collect_No)
                    .IsUnicode(false)
                    .HasComment("彙總號");

                entity.Property(e => e.Material_Sheet_No)
                    .IsUnicode(false)
                    .HasComment("發料單號");

                entity.Property(e => e.Biz_Tflag)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("biztalk轉入方式");

                entity.Property(e => e.Collect_Date).HasComment("彙總日期");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .HasComment("廠別");

                entity.Property(e => e.HP_Day).HasComment("HP異動日");

                entity.Property(e => e.HP_Time).HasComment("HP異動時間");

                entity.Property(e => e.HP_User)
                    .IsUnicode(false)
                    .HasComment("HP異動者");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true)
                    .HasComment("狀態");

                entity.Property(e => e.Update_By)
                    .IsUnicode(false)
                    .HasComment("異動者");

                entity.Property(e => e.Update_Time).HasComment("異動日");
            });

            modelBuilder.Entity<MPS_Replenish_Cancel_Code>(entity =>
            {
                entity.Property(e => e.Code).IsFixedLength(true);
            });

            modelBuilder.Entity<MPS_Replenish_Check_Record>(entity =>
            {
                entity.HasIndex(e => new { e.manuf, e.exec_date, e.manno, e.seq })
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CheckBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProdProcess)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.manno).IsUnicode(false);

                entity.Property(e => e.manuf)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.seq).IsUnicode(false);
            });

            modelBuilder.Entity<MPS_Replenish_Claim_Detail>(entity =>
            {
                entity.Property(e => e.Material_Sheet_No).IsUnicode(false);

                entity.Property(e => e.CollectBy).IsFixedLength(true);

                entity.Property(e => e.Collect_No).IsUnicode(false);

                entity.Property(e => e.Factory_ID).IsUnicode(false);
            });

            modelBuilder.Entity<MPS_Replenish_Collect>(entity =>
            {
                entity.Property(e => e.Material_Sheet_No).IsUnicode(false);

                entity.Property(e => e.Collect_By).IsFixedLength(true);

                entity.Property(e => e.Collect_No).IsUnicode(false);

                entity.Property(e => e.Factory_ID).IsUnicode(false);
            });

            modelBuilder.Entity<MPS_Replenish_PB3A4>(entity =>
            {
                entity.HasIndex(e => new { e.Material_Sheet_No, e.Replenish_Collect_No, e.MO_No, e.Main_Material_ID })
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Main_Material_ID).IsUnicode(false);

                entity.Property(e => e.Material_Sheet_No).IsUnicode(false);

                entity.Property(e => e.Purch_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Replenish_Collect_No).IsUnicode(false);

                entity.Property(e => e.Replenish_No).IsUnicode(false);

                entity.Property(e => e.Sub_Material_ID).IsUnicode(false);
            });

            modelBuilder.Entity<MPS_Replenish_Status_Detail>(entity =>
            {
                entity.Property(e => e.Material_Sheet_No).IsUnicode(false);

                entity.Property(e => e.Cancel_By).IsFixedLength(true);

                entity.Property(e => e.Cancel_Code).IsFixedLength(true);

                entity.Property(e => e.Dispatch_By).IsFixedLength(true);

                entity.Property(e => e.DownloadCSV_By).IsFixedLength(true);

                entity.Property(e => e.MatlNoHave_By).IsFixedLength(true);

                entity.Property(e => e.Ready_By).IsFixedLength(true);

                entity.Property(e => e.SReady_By).IsFixedLength(true);
            });

            modelBuilder.Entity<TAutho>(entity =>
            {
                entity.Property(e => e.account).IsFixedLength(true);

                entity.Property(e => e.Autho).IsFixedLength(true);

                entity.Property(e => e.Cellno).IsUnicode(false);

                entity.Property(e => e.Default_DispatchArea_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.empno).IsFixedLength(true);
            });

            modelBuilder.Entity<TAuthoList>(entity =>
            {
                entity.HasIndex(e => e.AuthIndex)
                    .IsUnique()
                    .HasFillFactor((byte)80);
            });

            modelBuilder.Entity<TAuthoPickupForm>(entity =>
            {
                entity.HasKey(e => new { e.account, e.Kind });

                entity.HasIndex(e => new { e.account, e.Kind })
                    .HasFillFactor((byte)80);

                entity.Property(e => e.account).IsFixedLength(true);
            });

            modelBuilder.Entity<TCMS_IEPKList>(entity =>
            {
                entity.HasKey(e => new { e.Trno, e.Cycle_No, e.Part, e.Item_NBR, e.Size, e.Kind, e.Factory_ID });

                entity.HasComment("取料單週轉部位材料");

                entity.Property(e => e.Trno)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("取料單號");

                entity.Property(e => e.Cycle_No)
                    .IsUnicode(false)
                    .HasComment("週轉號");

                entity.Property(e => e.Part)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("部位");

                entity.Property(e => e.Item_NBR)
                    .IsUnicode(false)
                    .HasComment("料號");

                entity.Property(e => e.Size)
                    .IsUnicode(false)
                    .HasComment("尺寸");

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("類別");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .HasComment("廠別");

                entity.Property(e => e.MO_No)
                    .IsUnicode(false)
                    .HasComment("企劃單號");

                entity.Property(e => e.MO_Seq)
                    .IsUnicode(false)
                    .HasComment("批次");

                entity.Property(e => e.O_Qty)
                    .HasDefaultValueSql("((0))")
                    .HasComment("指定的取料量");

                entity.Property(e => e.P_Qty)
                    .HasDefaultValueSql("((0))")
                    .HasComment("指定的企劃量");

                entity.Property(e => e.Update_By)
                    .IsUnicode(false)
                    .HasComment("異動者");

                entity.Property(e => e.Update_Time).HasComment("異動時間");

                entity.Property(e => e.Vender_No)
                    .IsUnicode(false)
                    .HasComment("廠商");
            });

            modelBuilder.Entity<TCMS_IEPKList_Log>(entity =>
            {
                entity.HasKey(e => new { e.Trno, e.Cycle_No, e.Part, e.Item_NBR, e.Size, e.Kind, e.Factory_ID });

                entity.Property(e => e.Trno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycle_No).IsUnicode(false);

                entity.Property(e => e.Part)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Item_NBR).IsUnicode(false);

                entity.Property(e => e.Size).IsUnicode(false);

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Seq).IsUnicode(false);

                entity.Property(e => e.Update_By).IsUnicode(false);

                entity.Property(e => e.Vender_No).IsUnicode(false);
            });

            modelBuilder.Entity<TCentralCall>(entity =>
            {
                entity.HasKey(e => new { e.PO, e.Batch, e.Seq, e.Kind })
                    .HasName("PK_dbo.TCentralCall");
            });

            modelBuilder.Entity<TCentralDispatch>(entity =>
            {
                entity.HasKey(e => new { e.PO, e.Batch, e.Seq, e.Kind })
                    .HasName("PK_dbo.TCentralDispatch");
            });

            modelBuilder.Entity<TCentralPrepare>(entity =>
            {
                entity.HasKey(e => new { e.PO, e.Batch, e.Seq, e.Kind })
                    .HasName("PK_dbo.TCentralPrepare");
            });

            modelBuilder.Entity<TCentralSize>(entity =>
            {
                entity.HasKey(e => new { e.PO, e.Batch, e.Seq, e.Size })
                    .HasName("PK_dbo.TCentralSize");
            });

            modelBuilder.Entity<TCentralUpload>(entity =>
            {
                entity.HasKey(e => new { e.PO, e.Batch, e.Seq })
                    .HasName("PK_dbo.TCentralUpload");

                entity.Property(e => e.DateAt).HasDefaultValueSql("('1900-01-01T00:00:00.000')");
            });

            modelBuilder.Entity<THPi14a>(entity =>
            {
                entity.HasKey(e => new { e.manuf, e.dept, e.ymd })
                    .HasName("i14a_k");

                entity.Property(e => e.manuf).IsFixedLength(true);

                entity.Property(e => e.dept).IsFixedLength(true);
            });

            modelBuilder.Entity<THPie83>(entity =>
            {
                entity.HasKey(e => new { e.manno, e.seq, e.manuf });

                entity.HasIndex(e => e.grpno)
                    .HasFillFactor((byte)80);

                entity.Property(e => e.manuf).IsFixedLength(true);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.teamno).IsFixedLength(true);
            });

            modelBuilder.Entity<THPn15_4>(entity =>
            {
                entity.HasKey(e => new { e.manuf, e.lean, e.seq, e.aday })
                    .HasName("THPn15_4_k");

                entity.Property(e => e.manuf).IsFixedLength(true);

                entity.Property(e => e.lean).IsFixedLength(true);

                entity.Property(e => e.dept).IsFixedLength(true);
            });

            modelBuilder.Entity<TIE24>(entity =>
            {
                entity.HasKey(e => new { e.Factory, e.Squad, e.Seq });

                entity.Property(e => e.Squad).IsFixedLength(true);
            });

            modelBuilder.Entity<TIE25>(entity =>
            {
                entity.HasKey(e => new { e.Factory, e.Squad, e.Teamno, e.DateEff });

                entity.Property(e => e.Squad).IsFixedLength(true);
            });

            modelBuilder.Entity<TMenu>(entity =>
            {
                entity.Property(e => e.MenuDisplay).IsUnicode(false);

                entity.Property(e => e.MenuIcon).IsUnicode(false);

                entity.Property(e => e.MenuParent).IsUnicode(false);

                entity.Property(e => e.Path).IsUnicode(false);

                entity.HasOne(d => d.Autho)
                    .WithMany(p => p.TMenu)
                    .HasForeignKey(d => d.AuthoID)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_TMenu_TAuthoList");
            });

            modelBuilder.Entity<TNotice>(entity =>
            {
                entity.HasKey(e => e.NoticeID)
                    .HasName("TNotice_pk");

                entity.Property(e => e.NoticeID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GenerateBy).IsFixedLength(true);
            });

            modelBuilder.Entity<TOrg>(entity =>
            {
                entity.HasKey(e => new { e.Factory_ID, e.PDC_ID, e.Line_ID, e.Dept_ID });

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PDC_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Line_ID).IsUnicode(false);

                entity.Property(e => e.Dept_ID).IsUnicode(false);

                entity.Property(e => e.Block)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Dept_Kind)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Updated_By).IsUnicode(false);
            });

            modelBuilder.Entity<TPOInfo>(entity =>
            {
                entity.HasKey(e => new { e.manno, e.seq, e.manuf });

                entity.HasIndex(e => new { e.as_bdate, e.as_edate })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.teamno)
                    .HasFillFactor((byte)80);
            });

            modelBuilder.Entity<TPartPrepareDates>(entity =>
            {
                entity.HasKey(e => new { e.kind, e.trno })
                    .HasName("TPartPrepareDatesPK");

                entity.Property(e => e.trno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.WHNoticeNo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.isHadPrepareBalance)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.isHadProdReceiveBalance)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TPartPrepareQtys>(entity =>
            {
                entity.HasKey(e => new { e.kind, e.trno, e.itnbr, e.size })
                    .HasName("TPartPrepareQtysPK");

                entity.Property(e => e.trno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.itnbr)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.size)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TPickupForm>(entity =>
            {
                entity.HasKey(e => new { e.trno, e.kind });

                entity.HasIndex(e => e.kind)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.manno, e.seq })
                    .HasFillFactor((byte)80);
            });

            modelBuilder.Entity<TPickupFormStatus>(entity =>
            {
                entity.HasKey(e => new { e.trno, e.kind })
                    .HasName("PK_TScannedPickupForm");

                entity.HasIndex(e => new { e.call_at, e.manno, e.seq })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.kind)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.manno, e.seq })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.prepare_at)
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Dispatch_To)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.call_by).IsFixedLength(true);

                entity.Property(e => e.closing_by).IsFixedLength(true);

                entity.Property(e => e.dispatch_by).IsFixedLength(true);

                entity.Property(e => e.prepare_by).IsFixedLength(true);

                entity.Property(e => e.prodcheck_by).IsFixedLength(true);

                entity.Property(e => e.settingmatl_by).IsFixedLength(true);

                entity.Property(e => e.whchkstock_by).IsFixedLength(true);
            });

            modelBuilder.Entity<TSettings>(entity =>
            {
                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.key).IsFixedLength(true);
            });

            modelBuilder.Entity<Tie29>(entity =>
            {
                entity.HasKey(e => new { e.manuf, e.manno, e.seq, e.cyno });

                entity.HasIndex(e => new { e.as_bdate, e.manno, e.seq })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.cyno, e.manuf })
                    .HasFillFactor((byte)80);

                entity.Property(e => e.manuf).IsFixedLength(true);

                entity.Property(e => e.as_btime).IsFixedLength(true);

                entity.Property(e => e.as_etime).IsFixedLength(true);

                entity.Property(e => e.cut_btime).IsFixedLength(true);

                entity.Property(e => e.cut_etime).IsFixedLength(true);

                entity.Property(e => e.day_sch).IsFixedLength(true);

                entity.Property(e => e.get_no).IsFixedLength(true);

                entity.Property(e => e.stfi_btime).IsFixedLength(true);

                entity.Property(e => e.stfi_etime).IsFixedLength(true);

                entity.Property(e => e.sti_btime).IsFixedLength(true);

                entity.Property(e => e.sti_etime).IsFixedLength(true);
            });

            modelBuilder.Entity<VCentralize>(entity =>
            {
                entity.ToView("VCentralize");
            });

            modelBuilder.Entity<VCustomerOrder>(entity =>
            {
                entity.ToView("VCustomerOrder");
            });

            modelBuilder.Entity<VManno>(entity =>
            {
                entity.ToView("VManno");
            });

            modelBuilder.Entity<VMannoSet>(entity =>
            {
                entity.ToView("VMannoSet");
            });

            modelBuilder.Entity<VOrderDeptLastProductionDate>(entity =>
            {
                entity.ToView("VOrderDeptLastProductionDate");

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.PS_ID)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");
            });

            modelBuilder.Entity<VPartialPreparationDet>(entity =>
            {
                entity.ToView("VPartialPreparationDet");

                entity.Property(e => e.Vender_No).IsUnicode(false);

                entity.Property(e => e.WHNoticeNo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.itnbr)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.size)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.trno)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VPickupScan>(entity =>
            {
                entity.ToView("VPickupScan");
            });

            modelBuilder.Entity<VPickupStatus>(entity =>
            {
                entity.ToView("VPickupStatus");

                entity.Property(e => e.Area_Name).IsUnicode(false);

                entity.Property(e => e.Dispatch_To)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Line_ID).IsUnicode(false);

                entity.Property(e => e.isHadPrepareBalance)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.isHadProdReceiveBalance)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);
            });

            modelBuilder.Entity<VTimeSquad>(entity =>
            {
                entity.ToView("VTimeSquad");

                entity.Property(e => e.Squad).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_FBSection_TotQty_Detail>(entity =>
            {
                entity.ToView("VW_Cmpt_FBSection_TotQty_Detail");

                entity.Property(e => e.Internal_Part_No).IsFixedLength(true);

                entity.Property(e => e.Kind)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Size)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.tsize).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Feedback_POList>(entity =>
            {
                entity.ToView("VW_Cmpt_Feedback_POList");

                entity.Property(e => e.OutputHadBalance).IsUnicode(false);

                entity.Property(e => e.code).IsFixedLength(true);

                entity.Property(e => e.manno).IsFixedLength(true);

                entity.Property(e => e.manuf).IsFixedLength(true);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.seq).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);

                entity.Property(e => e.teamno).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Feedback_POList_WithSetS3>(entity =>
            {
                entity.ToView("VW_Cmpt_Feedback_POList_WithSetS3");

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OutputHadBalance).IsUnicode(false);

                entity.Property(e => e.code).IsFixedLength(true);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Process_FeedbackStage>(entity =>
            {
                entity.ToView("VW_Cmpt_Process_FeedbackStage");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_Name).IsUnicode(false);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Process_PlanTransaction_POBatch>(entity =>
            {
                entity.ToView("VW_Cmpt_Process_PlanTransaction_POBatch");

                entity.Property(e => e.Cell_Name).IsUnicode(false);

                entity.Property(e => e.Feedback_Stage).IsUnicode(false);

                entity.Property(e => e.Part_E_Name).IsUnicode(false);

                entity.Property(e => e.Process_Na).IsUnicode(false);

                entity.Property(e => e.code).IsFixedLength(true);

                entity.Property(e => e.manno).IsFixedLength(true);

                entity.Property(e => e.manuf).IsFixedLength(true);

                entity.Property(e => e.part).IsFixedLength(true);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.seq).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);

                entity.Property(e => e.teamno).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Summary_MaxBalance_ByWorkshop>(entity =>
            {
                entity.ToView("VW_Cmpt_Summary_MaxBalance_ByWorkshop");

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.manno).IsFixedLength(true);

                entity.Property(e => e.seq).IsFixedLength(true);

                entity.Property(e => e.size).IsFixedLength(true);

                entity.Property(e => e.workshop).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Summary_WorkshopSpin>(entity =>
            {
                entity.ToView("VW_Cmpt_Summary_WorkshopSpin");

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.manno).IsFixedLength(true);

                entity.Property(e => e.seq).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_TransList_ForWIP>(entity =>
            {
                entity.ToView("VW_Cmpt_TransList_ForWIP");

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Part_E_Name).IsUnicode(false);

                entity.Property(e => e.Process_Na).IsUnicode(false);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Processing_Finish_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Processing_Last_Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TreatmentGroup_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Work_Shift)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.WorkstationType_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Workstation_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Workstation_Seq)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);

                entity.Property(e => e.teamno).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_TransList_ForWIP_Source>(entity =>
            {
                entity.ToView("VW_Cmpt_TransList_ForWIP_Source");

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Part_E_Name).IsUnicode(false);

                entity.Property(e => e.Process_Na).IsUnicode(false);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Processing_Finish_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Processing_Last_Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TreatmentGroup_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Work_Shift)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.WorkstationType_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Workstation_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Workstation_Seq)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);

                entity.Property(e => e.teamno).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Transaction_Detail_POBatch>(entity =>
            {
                entity.ToView("VW_Cmpt_Transaction_Detail_POBatch");

                entity.Property(e => e.Feedback_Stage).IsUnicode(false);

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Part_E_Name).IsUnicode(false);

                entity.Property(e => e.Process_Na).IsUnicode(false);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_By).IsUnicode(false);

                entity.Property(e => e.Transaction_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Work_Shift).IsUnicode(false);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);

                entity.Property(e => e.teamno).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Transaction_Detail_POBatchSize>(entity =>
            {
                entity.ToView("VW_Cmpt_Transaction_Detail_POBatchSize");

                entity.Property(e => e.Feedback_Stage).IsUnicode(false);

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Size)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Part_E_Name).IsUnicode(false);

                entity.Property(e => e.Process_Na).IsUnicode(false);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Supplier_No).IsUnicode(false);

                entity.Property(e => e.Transaction_By).IsUnicode(false);

                entity.Property(e => e.Transaction_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Work_Shift).IsUnicode(false);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);

                entity.Property(e => e.teamno).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Transaction_Plus_351>(entity =>
            {
                entity.ToView("VW_Cmpt_Transaction_Plus_351");

                entity.Property(e => e.External_Part_No).IsUnicode(false);

                entity.Property(e => e.Feedback_Stage).IsUnicode(false);

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Sequence).IsUnicode(false);

                entity.Property(e => e.MO_Size)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_Material_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Supplier_No).IsUnicode(false);

                entity.Property(e => e.Tooling_Size).IsUnicode(false);

                entity.Property(e => e.Transaction_By).IsUnicode(false);

                entity.Property(e => e.Transaction_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Work_Shift).IsUnicode(false);
            });

            modelBuilder.Entity<VW_Cmpt_Transaction_Summary_POBatch>(entity =>
            {
                entity.ToView("VW_Cmpt_Transaction_Summary_POBatch");

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Processing_Finish_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Processing_Last_Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_By)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Transaction_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TreatmentGroup_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.WorkstationType_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Workstation_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Workstation_Seq)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Transaction_Summary_POBatchSize>(entity =>
            {
                entity.ToView("VW_Cmpt_Transaction_Summary_POBatchSize");

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.code).IsFixedLength(true);

                entity.Property(e => e.manno).IsFixedLength(true);

                entity.Property(e => e.manuf).IsFixedLength(true);

                entity.Property(e => e.part).IsFixedLength(true);

                entity.Property(e => e.seq).IsFixedLength(true);

                entity.Property(e => e.size).IsFixedLength(true);

                entity.Property(e => e.vendno).IsFixedLength(true);

                entity.Property(e => e.workshop).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Transaction_Summary_POBatchSize_DetailOrg>(entity =>
            {
                entity.ToView("VW_Cmpt_Transaction_Summary_POBatchSize_DetailOrg");

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Internal_Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MO_Batch).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Part_E_Name).IsUnicode(false);

                entity.Property(e => e.Process_Na).IsUnicode(false);

                entity.Property(e => e.Process_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);

                entity.Property(e => e.teamno).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_Workstation_DailyTransaction>(entity =>
            {
                entity.ToView("VW_Cmpt_Workstation_DailyTransaction");

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Workstation_Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VW_Cmpt_ie32t_FeedbackStage>(entity =>
            {
                entity.ToView("VW_Cmpt_ie32t_FeedbackStage");

                entity.Property(e => e.Feedback_Stage)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.apart).IsFixedLength(true);

                entity.Property(e => e.code).IsFixedLength(true);

                entity.Property(e => e.itnbr)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.manno).IsFixedLength(true);

                entity.Property(e => e.manuf).IsFixedLength(true);

                entity.Property(e => e.part).IsFixedLength(true);

                entity.Property(e => e.seq).IsFixedLength(true);

                entity.Property(e => e.size).IsFixedLength(true);

                entity.Property(e => e.tsize).IsFixedLength(true);

                entity.Property(e => e.upusr).IsFixedLength(true);

                entity.Property(e => e.vendno).IsFixedLength(true);

                entity.Property(e => e.workshop).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_EEP_FRIPO_EstExportDate>(entity =>
            {
                entity.ToView("VW_EEP_FRIPO_EstExportDate");

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.PO).IsUnicode(false);
            });

            modelBuilder.Entity<VW_HP32Vendor>(entity =>
            {
                entity.ToView("VW_HP32Vendor");

                entity.Property(e => e.code).IsFixedLength(true);

                entity.Property(e => e.manno).IsFixedLength(true);

                entity.Property(e => e.part).IsFixedLength(true);

                entity.Property(e => e.seq).IsFixedLength(true);

                entity.Property(e => e.size).IsFixedLength(true);

                entity.Property(e => e.vendno).IsFixedLength(true);
            });

            modelBuilder.Entity<VW_HPBasis_HPCustomerBOM_j102>(entity =>
            {
                entity.ToView("VW_HPBasis_HPCustomerBOM_j102");

                entity.Property(e => e.Article).IsUnicode(false);

                entity.Property(e => e.Customer_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.Part_Name).IsUnicode(false);

                entity.Property(e => e.Part_No).IsUnicode(false);

                entity.Property(e => e.Style).IsUnicode(false);
            });

            modelBuilder.Entity<VW_HPBasis_HPDept_n15>(entity =>
            {
                entity.ToView("VW_HPBasis_HPDept_n15");

                entity.Property(e => e.Dept_E_Name).IsUnicode(false);

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Use_YN)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VW_HPBasis_HPMaterial_j13>(entity =>
            {
                entity.ToView("VW_HPBasis_HPMaterial_j13");

                entity.Property(e => e.E_Unit).IsUnicode(false);

                entity.Property(e => e.Estimate_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HP_User).IsUnicode(false);

                entity.Property(e => e.Material_ID).IsUnicode(false);

                entity.Property(e => e.Material_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Purchase_Factory).IsUnicode(false);

                entity.Property(e => e.Purchase_Print)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Purchase_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Size_Print)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VW_HPBasis_HPMonthlyEstimateProduceTarget_i14a>(entity =>
            {
                entity.ToView("VW_HPBasis_HPMonthlyEstimateProduceTarget_i14a");

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Factory_ID).IsUnicode(false);
            });

            modelBuilder.Entity<VW_HPBasis_HPOutsourceProcess_n71>(entity =>
            {
                entity.ToView("VW_HPBasis_HPOutsourceProcess_n71");

                entity.Property(e => e.Company_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Division_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.HP_User).IsUnicode(false);

                entity.Property(e => e.Is_Valid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Process_No).IsUnicode(false);

                entity.Property(e => e.Update_By).IsUnicode(false);
            });

            modelBuilder.Entity<VW_HPBasis_HPPart_j06>(entity =>
            {
                entity.ToView("VW_HPBasis_HPPart_j06");

                entity.Property(e => e.HP_User).IsUnicode(false);

                entity.Property(e => e.HP_V_User).IsUnicode(false);

                entity.Property(e => e.Outsource_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Part_E_Name).IsUnicode(false);

                entity.Property(e => e.Part_No)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Update_By).IsUnicode(false);
            });

            modelBuilder.Entity<VW_HPBasis_HPSquadTimeSequence_ie24>(entity =>
            {
                entity.ToView("VW_HPBasis_HPSquadTimeSequence_ie24");

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.HP_User).IsUnicode(false);

                entity.Property(e => e.Squad)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Step)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Update_By).IsUnicode(false);
            });

            modelBuilder.Entity<VW_HPBasis_HPUploadTime_ie27_1_log>(entity =>
            {
                entity.ToView("VW_HPBasis_HPUploadTime_ie27_1_log");

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.HP_User).IsUnicode(false);

                entity.Property(e => e.Update_By).IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VW_HPBasis_HPVendor_u01>(entity =>
            {
                entity.ToView("VW_HPBasis_HPVendor_u01");

                entity.Property(e => e.Address_No).IsUnicode(false);

                entity.Property(e => e.Amt_Code).IsUnicode(false);

                entity.Property(e => e.Contract_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Country_ID).IsUnicode(false);

                entity.Property(e => e.Envelope_Print)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Fax_No).IsUnicode(false);

                entity.Property(e => e.Forecast)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HP_User).IsUnicode(false);

                entity.Property(e => e.Mail).IsUnicode(false);

                entity.Property(e => e.Pay_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status_YN)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Tel).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.Uniform_ID).IsUnicode(false);

                entity.Property(e => e.Update_By).IsUnicode(false);

                entity.Property(e => e.Vendor_No).IsUnicode(false);

                entity.Property(e => e.Within)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VW_MES_CyclePlanQtyDetail>(entity =>
            {
                entity.ToView("VW_MES_CyclePlanQtyDetail");

                entity.Property(e => e.Cycle_No).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Seq).IsUnicode(false);

                entity.Property(e => e.Size_Code).IsUnicode(false);
            });

            modelBuilder.Entity<VW_MES_MOBasic>(entity =>
            {
                entity.ToView("VW_MES_MOBasic");

                entity.Property(e => e.Color_No)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Dept_ID_STC)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Dept_ID_STF)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Destination).UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Line_ID)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Line_ID_ASY)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Line_ID_STF)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Seq).IsUnicode(false);

                entity.Property(e => e.Order_Status)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Prod_Season)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Product_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Style_Name)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Style_No)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Top_Model)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Updated_By)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");
            });

            modelBuilder.Entity<VW_MES_Org_PDC>(entity =>
            {
                entity.ToView("VW_MES_Org_PDC");

                entity.Property(e => e.Block)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Building).UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.HP_Dept_ID)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Line_ID)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.Line_ID_2)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.PDC_Desc)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.PDC_DescVN)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.PDC_DescZW)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.PDC_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");

                entity.Property(e => e.PDC_Sname)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CI_AS");
            });

            modelBuilder.Entity<VW_MES_POBatchOutputBalance>(entity =>
            {
                entity.ToView("VW_MES_POBatchOutputBalance");

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Seq).IsUnicode(false);

                entity.Property(e => e.hadBalance).IsUnicode(false);
            });

            modelBuilder.Entity<VW_MES_POBatchSizePlanQty>(entity =>
            {
                entity.ToView("VW_MES_POBatchSizePlanQty");

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.MO_Seq).IsUnicode(false);

                entity.Property(e => e.Size_Code).IsUnicode(false);
            });

            modelBuilder.Entity<VW_RackNET_Section_Setting>(entity =>
            {
                entity.ToView("VW_RackNET_Section_Setting");

                entity.Property(e => e.Article).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.Section).IsUnicode(false);
            });

            modelBuilder.Entity<vMergedPOPlan>(entity =>
            {
                entity.ToView("vMergedPOPlan");

                entity.Property(e => e.MergedTeamno).IsFixedLength(true);

                entity.Property(e => e.manuf).IsFixedLength(true);
            });

            modelBuilder.Entity<vPOnMERGErelation>(entity =>
            {
                entity.ToView("vPOnMERGErelation");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.scolna).IsFixedLength(true);

                entity.Property(e => e.style).IsFixedLength(true);

                entity.Property(e => e.styna).IsFixedLength(true);
            });

            modelBuilder.Entity<vPOwithoutMerged>(entity =>
            {
                entity.ToView("vPOwithoutMerged");
            });

            modelBuilder.Entity<vPUFCycleDetail>(entity =>
            {
                entity.ToView("vPUFCycleDetail");
            });

            modelBuilder.Entity<vPUFDetailStatus>(entity =>
            {
                entity.ToView("vPUFDetailStatus");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.WHNoticeNo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.isHadPrepareBalance)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.isHadProdReceiveBalance)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<vPUFnMERGErelation>(entity =>
            {
                entity.ToView("vPUFnMERGErelation");

                entity.Property(e => e.Category).IsUnicode(false);
            });

            modelBuilder.Entity<vReplenishCheckLastDT>(entity =>
            {
                entity.ToView("vReplenishCheckLastDT");

                entity.Property(e => e.ProdProcess)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.manno).IsUnicode(false);

                entity.Property(e => e.manuf)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.seq).IsUnicode(false);
            });

            modelBuilder.Entity<vReplenishCheckSummary>(entity =>
            {
                entity.ToView("vReplenishCheckSummary");

                entity.Property(e => e.manno).IsUnicode(false);

                entity.Property(e => e.manuf)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<vReplenishCheckSummary_2>(entity =>
            {
                entity.ToView("vReplenishCheckSummary_2");

                entity.Property(e => e.ASL_Is_Complete)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CTL_Need_Replenish)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.STC_Need_Replenish)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.STF_Need_Replenish)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.manno).IsUnicode(false);

                entity.Property(e => e.manuf)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.seq).IsUnicode(false);
            });

            modelBuilder.Entity<vReplenish_Collect_Detail>(entity =>
            {
                entity.ToView("vReplenish_Collect_Detail");

                entity.Property(e => e.Cause).IsUnicode(false);

                entity.Property(e => e.Collect_No).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Material_ID).IsUnicode(false);

                entity.Property(e => e.Material_Sheet_No).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Replenish_No).IsUnicode(false);

                entity.Property(e => e.Size).IsUnicode(false);
            });

            modelBuilder.Entity<vReplenish_Each_Date_Detail>(entity =>
            {
                entity.ToView("vReplenish_Each_Date_Detail");

                entity.Property(e => e.Cancel_Code).IsFixedLength(true);

                entity.Property(e => e.Cause).IsUnicode(false);

                entity.Property(e => e.Collect_No).IsUnicode(false);

                entity.Property(e => e.Dispatch_By).IsFixedLength(true);

                entity.Property(e => e.DownloadCSV_By).IsFixedLength(true);

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.HP_User).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Material_ID).IsUnicode(false);

                entity.Property(e => e.Material_Sheet_No).IsUnicode(false);

                entity.Property(e => e.Material_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MatlNoHave_By).IsFixedLength(true);

                entity.Property(e => e.RDept_ID).IsUnicode(false);

                entity.Property(e => e.Ready_By).IsFixedLength(true);

                entity.Property(e => e.Replenish_No).IsUnicode(false);

                entity.Property(e => e.SDept_ID).IsFixedLength(true);

                entity.Property(e => e.SReady_By).IsFixedLength(true);

                entity.Property(e => e.Size).IsUnicode(false);

                entity.Property(e => e.Size_Print)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<vReplenish_Each_Date_Detail_2>(entity =>
            {
                entity.ToView("vReplenish_Each_Date_Detail_2");

                entity.Property(e => e.Cancel_Code).IsFixedLength(true);

                entity.Property(e => e.Cause).IsUnicode(false);

                entity.Property(e => e.Collect_No).IsUnicode(false);

                entity.Property(e => e.Dispatch_By).IsFixedLength(true);

                entity.Property(e => e.DownloadCSV_By).IsFixedLength(true);

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.HP_User).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Material_ID).IsUnicode(false);

                entity.Property(e => e.Material_Sheet_No).IsUnicode(false);

                entity.Property(e => e.Material_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MatlNoHave_By).IsFixedLength(true);

                entity.Property(e => e.RDept_ID).IsUnicode(false);

                entity.Property(e => e.Ready_By).IsFixedLength(true);

                entity.Property(e => e.Replenish_No).IsUnicode(false);

                entity.Property(e => e.SReady_By).IsFixedLength(true);

                entity.Property(e => e.Size).IsUnicode(false);

                entity.Property(e => e.Size_Print)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<vReplenish_SizePrint>(entity =>
            {
                entity.ToView("vReplenish_SizePrint");

                entity.Property(e => e.Cancel_Code).IsFixedLength(true);

                entity.Property(e => e.Cause).IsUnicode(false);

                entity.Property(e => e.Collect_No).IsUnicode(false);

                entity.Property(e => e.Dispatch_By).IsFixedLength(true);

                entity.Property(e => e.DownloadCSV_By).IsFixedLength(true);

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.HP_User).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Material_ID).IsUnicode(false);

                entity.Property(e => e.Material_Sheet_No).IsUnicode(false);

                entity.Property(e => e.Material_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MatlNoHave_By).IsFixedLength(true);

                entity.Property(e => e.RDept_ID).IsUnicode(false);

                entity.Property(e => e.Ready_By).IsFixedLength(true);

                entity.Property(e => e.Replenish_No).IsUnicode(false);

                entity.Property(e => e.SReady_By).IsFixedLength(true);

                entity.Property(e => e.Size).IsUnicode(false);

                entity.Property(e => e.Size_Print)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<vReplenish_SizePrint_2>(entity =>
            {
                entity.ToView("vReplenish_SizePrint_2");

                entity.Property(e => e.Cancel_Code).IsFixedLength(true);

                entity.Property(e => e.Cause).IsUnicode(false);

                entity.Property(e => e.Collect_No).IsUnicode(false);

                entity.Property(e => e.Dispatch_By).IsFixedLength(true);

                entity.Property(e => e.DownloadCSV_By).IsFixedLength(true);

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.HP_User).IsUnicode(false);

                entity.Property(e => e.MO_No).IsUnicode(false);

                entity.Property(e => e.Material_ID).IsUnicode(false);

                entity.Property(e => e.Material_Sheet_No).IsUnicode(false);

                entity.Property(e => e.Material_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MatlNoHave_By).IsFixedLength(true);

                entity.Property(e => e.RDept_ID).IsUnicode(false);

                entity.Property(e => e.Ready_By).IsFixedLength(true);

                entity.Property(e => e.Replenish_No).IsUnicode(false);

                entity.Property(e => e.SDept_ID).IsFixedLength(true);

                entity.Property(e => e.SReady_By).IsFixedLength(true);

                entity.Property(e => e.Size).IsUnicode(false);

                entity.Property(e => e.Size_Print)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}