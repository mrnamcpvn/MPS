using Microsoft.EntityFrameworkCore;
using MPS_API.Models;

namespace MPS_API.Data
{
    public partial class MESContext : DbContext
    {
        public virtual DbSet<MES_Dept> MES_Dept { get; set; }
        public virtual DbSet<MES_Dept_Plan> MES_Dept_Plan { get; set; }
        public virtual DbSet<MES_Holiday> MES_Holiday { get; set; }
        public virtual DbSet<MES_Line> MES_Line { get; set; }
        public virtual DbSet<MES_MO> MES_MO { get; set; }
        public virtual DbSet<MES_MO_Log> MES_MO_Log { get; set; }
        public virtual DbSet<MES_Org> MES_Org { get; set; }
        public virtual DbSet<VW_Dept_PS_ID> VW_Dept_PS_ID { get; set; }

        public MESContext(DbContextOptions<MESContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<MES_Dept>(entity =>
            {
                entity.HasKey(e => new { e.Dept_ID, e.Factory_ID });

                entity.HasComment("生產部門代碼檔");

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .HasComment("生產部門別");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')")
                    .IsFixedLength(true)
                    .HasComment("廠別");

                entity.Property(e => e.Dept_Desc)
                    .IsUnicode(false)
                    .HasComment("部門說明英文");

                entity.Property(e => e.Dept_DescVN).HasComment("部門說明越文");

                entity.Property(e => e.Dept_DescZW).HasComment("部門說明中文");

                entity.Property(e => e.Dept_Sname)
                    .IsUnicode(false)
                    .HasComment("部門簡稱英文");

                entity.Property(e => e.Dept_Type)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('P')")
                    .IsFixedLength(true)
                    .HasComment("部門類別");

                entity.Property(e => e.Lunch_Order)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')")
                    .IsFixedLength(true)
                    .HasComment("午休時間");

                entity.Property(e => e.Need_Andon)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true)
                    .HasComment("是否檢視安東");

                entity.Property(e => e.Need_Bulletin)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true)
                    .HasComment("是否顯示在KB");

                entity.Property(e => e.Need_Camera)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true)
                    .HasComment("是否拍照");

                entity.Property(e => e.PS_ID)
                    .IsUnicode(false)
                    .HasComment("所屬工序");

                entity.Property(e => e.Update_Time)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("異動時間");

                entity.Property(e => e.Updated_By)
                    .IsUnicode(false)
                    .HasComment("異動者");

                entity.Property(e => e.Work_Center)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('5')")
                    .IsFixedLength(true)
                    .HasComment("工段類別");
            });

            modelBuilder.Entity<MES_Dept_Plan>(entity =>
            {
                entity.HasKey(e => new { e.Dept_ID, e.Plan_Date, e.Factory_ID });

                entity.HasComment("生產部門目標主檔");

                entity.HasIndex(e => e.Plan_Date)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Plan_Date)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Dept_ID, e.Plan_Date })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Line_ID, e.Dept_ID })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Plan_Date, e.Working_Hour })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Plan_Date)
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .HasComment("部門編號 (ERP是填寫成型線部門)");

                entity.Property(e => e.Plan_Date).HasComment("今天生產日 time部分00:00:00");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')")
                    .IsFixedLength(true)
                    .HasComment("廠別");

                entity.Property(e => e.Biz_Key)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(([Factory_ID]+[Dept_ID])+CONVERT([varchar](10),[Plan_Date],(120)))", false)
                    .HasComment("Biz_Key");

                entity.Property(e => e.Def_Rate_UL)
                    .HasDefaultValueSql("((0.0))")
                    .HasComment("部門不良率警戒線");

                entity.Property(e => e.Last_Head_Cnt)
                    .HasDefaultValueSql("((0))")
                    .HasComment("前一日出勤人數");

                entity.Property(e => e.Last_Qty)
                    .HasDefaultValueSql("((0))")
                    .HasComment("當天最後線上WIP數");

                entity.Property(e => e.Line_ID)
                    .IsUnicode(false)
                    .HasComment("LEAN線");

                entity.Property(e => e.OT_End_Time).HasComment("本日結束加班時間");

                entity.Property(e => e.OT_Head_Cnt)
                    .HasDefaultValueSql("((0))")
                    .HasComment("本日加班人數");

                entity.Property(e => e.Plan_Day_Target)
                    .HasDefaultValueSql("((0))")
                    .HasComment("日生產目標");

                entity.Property(e => e.Plan_Qty)
                    .HasDefaultValueSql("((0))")
                    .HasComment("本日每小時目標產量");

                entity.Property(e => e.Plan_Qty_Cum)
                    .HasDefaultValueSql("((0))")
                    .HasComment("累積本日產量");

                entity.Property(e => e.Qty1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Real_Hour)
                    .HasDefaultValueSql("((0))")
                    .HasComment("MES212輸入的實際工時");

                entity.Property(e => e.Send_Cars)
                    .HasDefaultValueSql("((0))")
                    .HasComment("呼叫AGV");

                entity.Property(e => e.Total_Head_Cnt)
                    .HasDefaultValueSql("((0))")
                    .HasComment("總工作人數");

                entity.Property(e => e.UTN_Def_Qty)
                    .HasDefaultValueSql("((0))")
                    .HasComment("今日UTN部門累計不良件數");

                entity.Property(e => e.UTN_MLT).HasComment("部門UTN 製造提前時間(Manfacturing Lead Time)");

                entity.Property(e => e.UTN_PPH).HasComment("部門每人工小時產量");

                entity.Property(e => e.UTN_RFT)
                    .HasDefaultValueSql("((0))")
                    .HasComment("部門UTN品質良率(Right first time)");

                entity.Property(e => e.UTN_Total_ManHr)
                    .HasDefaultValueSql("((0.0))")
                    .HasComment("今日UTN投入工時");

                entity.Property(e => e.UTN_WIP).HasComment("部門UTN在製品(Work In Process) WIP數量");

                entity.Property(e => e.UTN_Yield_Qty)
                    .HasDefaultValueSql("((0))")
                    .HasComment("今日UTN部門累計產量");

                entity.Property(e => e.UTN_Yield_Rate)
                    .HasDefaultValueSql("((0))")
                    .HasComment("部門UTN達成率");

                entity.Property(e => e.Update_Time)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("異動時間");

                entity.Property(e => e.Updated_By)
                    .IsUnicode(false)
                    .HasComment("異動者");

                entity.Property(e => e.WT_Head_Cnt)
                    .HasDefaultValueSql("((0))")
                    .HasComment("本日出勤人數");

                entity.Property(e => e.Working_Hour)
                    .HasDefaultValueSql("((8.0))")
                    .HasComment("工作時數");
            });

            modelBuilder.Entity<MES_Holiday>(entity =>
            {
                entity.HasKey(e => new { e.Holiday, e.Factory_ID });

                entity.HasComment("假日設定檔");

                entity.Property(e => e.Holiday).HasComment("假日");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("廠別");

                entity.Property(e => e.Update_Time).HasComment("異動時間");

                entity.Property(e => e.Updated_By)
                    .IsUnicode(false)
                    .HasComment("異動者");
            });

            modelBuilder.Entity<MES_Line>(entity =>
            {
                entity.HasKey(e => new { e.Line_ID, e.Factory_ID });

                entity.HasComment("生產線代碼檔");

                entity.Property(e => e.Line_ID)
                    .IsUnicode(false)
                    .HasComment("生產線別");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')")
                    .IsFixedLength(true)
                    .HasComment("廠別");

                entity.Property(e => e.Line_AB)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')")
                    .IsFixedLength(true);

                entity.Property(e => e.Line_Desc)
                    .IsUnicode(false)
                    .HasComment("線別名稱英文");

                entity.Property(e => e.Line_DescVN).HasComment("線別名稱越文");

                entity.Property(e => e.Line_DescZW).HasComment("線別名稱中文");

                entity.Property(e => e.Line_Model)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Line_Sname)
                    .IsUnicode(false)
                    .HasComment("線別簡稱英文");

                entity.Property(e => e.Update_Time)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("異動時間");

                entity.Property(e => e.Updated_By)
                    .IsUnicode(false)
                    .HasComment("異動者");
            });

            modelBuilder.Entity<MES_MO>(entity =>
            {
                entity.HasKey(e => new { e.Cycle_No, e.Factory_ID });

                entity.HasComment("日生產計畫檔(HP轉入)");

                entity.HasIndex(e => new { e.Line_ID_STF, e.Plan_Start_ASY })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Act_Start_STF)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Color_No, e.MO_No })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Dept_ID, e.Factory_ID })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Dept_ID_STC)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Factory_ID)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Line_ID)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Line_ID, e.Plan_Start_CUT, e.Plan_End_CUT, e.Style_No })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Line_ID_ASY)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Line_ID_STF, e.Plan_Start_ASY })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.MO_No, e.MO_Seq, e.Factory_ID })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Plan_Start_ASY)
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Cycle_No)
                    .IsUnicode(false)
                    .HasComment("迴轉號")
                    .UseCollation("Chinese_Taiwan_Stroke_CS_AS");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')")
                    .IsFixedLength(true)
                    .HasComment("廠別")
                    .UseCollation("Chinese_Taiwan_Stroke_CS_AS");

                entity.Property(e => e.Act_End_ASY).HasComment("成型實際結束日");

                entity.Property(e => e.Act_End_CUT).HasComment("裁斷實際結束日");

                entity.Property(e => e.Act_End_STC).HasComment("針車實際結束日");

                entity.Property(e => e.Act_End_STF).HasComment("組底實際結束日");

                entity.Property(e => e.Act_Start_ASY).HasComment("成型實際開始日");

                entity.Property(e => e.Act_Start_CUT).HasComment("裁斷實際開始日");

                entity.Property(e => e.Act_Start_STC).HasComment("針車實際開始日");

                entity.Property(e => e.Act_Start_STF).HasComment("組底實際開始日");

                entity.Property(e => e.CRD).HasComment("預計出貨日,final裝船日");

                entity.Property(e => e.Color_No)
                    .IsUnicode(false)
                    .HasComment("色號");

                entity.Property(e => e.Comfirm_Date).HasComment("最後裝箱日");

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .HasComment("成型部門");

                entity.Property(e => e.Dept_ID_STC)
                    .IsUnicode(false)
                    .HasComment("針車部門");

                entity.Property(e => e.Dept_ID_STF)
                    .IsUnicode(false)
                    .HasComment("組底部門");

                entity.Property(e => e.Destination).HasComment("目的地");

                entity.Property(e => e.Line_ID)
                    .IsUnicode(false)
                    .HasComment("線別");

                entity.Property(e => e.Line_ID_ASY)
                    .IsUnicode(false)
                    .HasComment("成型線別");

                entity.Property(e => e.Line_ID_STF)
                    .IsUnicode(false)
                    .HasComment("組底線別");

                entity.Property(e => e.MO_No)
                    .IsUnicode(false)
                    .HasComment("企劃單號")
                    .UseCollation("Chinese_Taiwan_Stroke_CS_AS");

                entity.Property(e => e.MO_Seq)
                    .IsUnicode(false)
                    .HasComment("企劃單批次")
                    .UseCollation("Chinese_Taiwan_Stroke_CS_AS");

                entity.Property(e => e.Plan_End_ASY).HasComment("成型應結束日");

                entity.Property(e => e.Plan_End_CUT).HasComment("裁斷應結束日");

                entity.Property(e => e.Plan_End_STC).HasComment("針車應結束日");

                entity.Property(e => e.Plan_End_STF).HasComment("組底應結束日");

                entity.Property(e => e.Plan_Qty).HasComment("企劃單目標數");

                entity.Property(e => e.Plan_Start_ASY).HasComment("成型應開始日");

                entity.Property(e => e.Plan_Start_CUT).HasComment("裁斷應開始日");

                entity.Property(e => e.Plan_Start_STC).HasComment("針車應開始日");

                entity.Property(e => e.Plan_Start_STF).HasComment("組底應開始日");

                entity.Property(e => e.Prod_Season)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("生產季節");

                entity.Property(e => e.Received_Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Waiting')");

                entity.Property(e => e.Style_Name)
                    .IsUnicode(false)
                    .HasComment("型體名稱");

                entity.Property(e => e.Style_No)
                    .IsUnicode(false)
                    .HasComment("型體編號");

                entity.Property(e => e.Top_Model)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("重點型體");

                entity.Property(e => e.UTN_Forward_Qty_STC)
                    .HasDefaultValueSql("((0))")
                    .HasComment("針車轉出數量");

                entity.Property(e => e.UTN_Forward_Qty_STF)
                    .HasDefaultValueSql("((0))")
                    .HasComment("組底轉出數量");

                entity.Property(e => e.UTN_Yield_Qty)
                    .HasDefaultValueSql("((0))")
                    .HasComment("實際產量");

                entity.Property(e => e.UTN_Yield_Qty_STC)
                    .HasDefaultValueSql("((0))")
                    .HasComment("針車產量");

                entity.Property(e => e.UTN_Yield_Qty_STC_In)
                    .HasDefaultValueSql("((0))")
                    .HasComment("針車入庫數量");

                entity.Property(e => e.UTN_Yield_Qty_STF)
                    .HasDefaultValueSql("((0))")
                    .HasComment("組底產量");

                entity.Property(e => e.Update_Time)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新日期");

                entity.Property(e => e.Updated_By)
                    .IsUnicode(false)
                    .HasComment("更新人員");
            });

            modelBuilder.Entity<MES_MO_Log>(entity =>
            {
                entity.HasKey(e => new { e.Cycle_No, e.Factory_ID });

                entity.HasIndex(e => new { e.MO_No, e.MO_Seq })
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Log_Time)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Log_Time)
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Cycle_No)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CS_AS");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("Chinese_Taiwan_Stroke_CS_AS");

                entity.Property(e => e.Color_No).IsUnicode(false);

                entity.Property(e => e.Dept_ID).IsUnicode(false);

                entity.Property(e => e.Dept_ID_STC).IsUnicode(false);

                entity.Property(e => e.Dept_ID_STF)
                    .IsUnicode(false)
                    .HasComment("組底部門");

                entity.Property(e => e.Line_ID).IsUnicode(false);

                entity.Property(e => e.Line_ID_ASY).IsUnicode(false);

                entity.Property(e => e.Line_ID_STF)
                    .IsUnicode(false)
                    .HasComment("組底線別");

                entity.Property(e => e.MO_No)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CS_AS");

                entity.Property(e => e.MO_Seq)
                    .IsUnicode(false)
                    .UseCollation("Chinese_Taiwan_Stroke_CS_AS");

                entity.Property(e => e.Prod_Season)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Style_Name).IsUnicode(false);

                entity.Property(e => e.Style_No).IsUnicode(false);

                entity.Property(e => e.Top_Model)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UTN_Yield_Qty_STF).HasComment("組底產量");

                entity.Property(e => e.Updated_By).IsUnicode(false);
            });

            modelBuilder.Entity<MES_Org>(entity =>
            {
                entity.HasKey(e => new { e.PDC_ID, e.Line_ID, e.Dept_ID, e.Factory_ID });

                entity.HasComment("廠、生產線、生產部門結構關係檔");

                entity.HasIndex(e => e.Dept_ID)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.Line_ID)
                    .HasFillFactor((byte)80);

                entity.Property(e => e.PDC_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("生產部");

                entity.Property(e => e.Line_ID)
                    .IsUnicode(false)
                    .HasComment("生產線別");

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .HasComment("生產部門");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')")
                    .IsFixedLength(true)
                    .HasComment("廠別");

                entity.Property(e => e.Block)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);

                entity.Property(e => e.Building).HasComment("棟別(屬性)");

                entity.Property(e => e.HP_Dept_ID)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([Dept_ID])", false);

                entity.Property(e => e.IsAGV).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsT1T3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Line_ID_2)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when len([Line_ID])=(3) AND TRY_CAST(substring([Line_ID],(2),(1)) AS [int]) IS NULL then [Line_ID] else case when len([Line_ID])=(3) AND TRY_CAST(substring([Line_ID],(3),(1)) AS [int]) IS NULL then (substring([Line_ID],(1),(1))+'0')+substring([Line_ID],(2),(1)) else [Line_ID] end end)", false);

                entity.Property(e => e.Line_Seq).HasDefaultValueSql("((20))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Update_Time)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("異動時間");

                entity.Property(e => e.Updated_By)
                    .IsUnicode(false)
                    .HasComment("異動者");
            });

            modelBuilder.Entity<VW_Dept_PS_ID>(entity =>
            {
                entity.ToView("VW_Dept_PS_ID");

                entity.Property(e => e.ASY).IsUnicode(false);

                entity.Property(e => e.Line_ID).IsUnicode(false);

                entity.Property(e => e.Line_Model)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PRE).IsUnicode(false);

                entity.Property(e => e.STF).IsUnicode(false);

                entity.Property(e => e.STI).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}