using Microsoft.EntityFrameworkCore;

namespace MPS_API.Models
{
    public partial class HPDataDBContext : DbContext
    {
        public virtual DbSet<HP_Lean_Dept_n15_4> HP_Lean_Dept_n15_4 { get; set; }
        public virtual DbSet<HP_Material_j13> HP_Material_j13 { get; set; }
        public virtual DbSet<HP_Squad_Time_Sequence_ie24> HP_Squad_Time_Sequence_ie24 { get; set; }
        public virtual DbSet<HP_Style_Tool_Setup_j12> HP_Style_Tool_Setup_j12 { get; set; }
        public virtual DbSet<VW_Squad_Time> VW_Squad_Time { get; set; }

        public HPDataDBContext(DbContextOptions<HPDataDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CS_AS");

            modelBuilder.Entity<HP_Lean_Dept_n15_4>(entity =>
            {
                entity.HasKey(e => new { e.Lean, e.Effective_Date, e.Seq, e.Factory_ID })
                    .HasName("PK_HP_Lean_Dept");

                entity.HasComment("小線部門分組檔");

                entity.Property(e => e.Lean)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("線別");

                entity.Property(e => e.Effective_Date).HasComment("生效日");

                entity.Property(e => e.Seq).HasComment("序號");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .HasComment("廠別");

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("部門代號");

                entity.Property(e => e.HP_Date).HasComment("HP異動日");

                entity.Property(e => e.HP_Time).HasComment("HP異動時間");

                entity.Property(e => e.HP_User)
                    .IsUnicode(false)
                    .HasComment("HP異動者");

                entity.Property(e => e.Update_By)
                    .IsUnicode(false)
                    .HasComment("異動者");

                entity.Property(e => e.Update_Time).HasComment("異動時間");
            });

            modelBuilder.Entity<HP_Material_j13>(entity =>
            {
                entity.HasKey(e => e.Material_ID)
                    .HasName("PK_HP_Material");

                entity.HasComment("材料主檔");

                entity.Property(e => e.Material_ID)
                    .IsUnicode(false)
                    .HasComment("材料編號");

                entity.Property(e => e.Auditor)
                    .IsUnicode(false)
                    .HasComment("審核人員");

                entity.Property(e => e.C_Unit).HasComment("中文單位");

                entity.Property(e => e.Check_Date).HasComment("檢核完成日");

                entity.Property(e => e.Check_Material_Level)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("查料等級");

                entity.Property(e => e.Check_Material_YN)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("查料否");

                entity.Property(e => e.Check_YN)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("檢核完成否");

                entity.Property(e => e.Conversion_Rate).HasComment("轉換率");

                entity.Property(e => e.E_Unit)
                    .IsUnicode(false)
                    .HasComment("英文單位");

                entity.Property(e => e.Estimate_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("估量方式");

                entity.Property(e => e.External_Account_Main)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("外帳主科目");

                entity.Property(e => e.External_Account_Sub)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("外帳子科目");

                entity.Property(e => e.Gross_Weight).HasComment("毛重");

                entity.Property(e => e.HP_Date).HasComment("HP異動日");

                entity.Property(e => e.HP_User)
                    .IsUnicode(false)
                    .HasComment("HP異動者");

                entity.Property(e => e.IO_No)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("進銷代號");

                entity.Property(e => e.Internal_Account_Main)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("內帳主科目");

                entity.Property(e => e.Internal_Account_Sub)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("內帳子科目");

                entity.Property(e => e.KG_Conversion_Rate).HasComment("kg轉換率");

                entity.Property(e => e.Last_Scolor)
                    .IsUnicode(false)
                    .HasComment("最後使用顏色");

                entity.Property(e => e.Last_Style)
                    .IsUnicode(false)
                    .HasComment("最後使用鞋型");

                entity.Property(e => e.Material_C_Name).HasComment("材料中文名稱");

                entity.Property(e => e.Material_Customer_No)
                    .IsUnicode(false)
                    .HasComment("材料所屬客戶代號");

                entity.Property(e => e.Material_E_Name).HasComment("材料英文名稱");

                entity.Property(e => e.Material_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("材料區分");

                entity.Property(e => e.Net_Weight).HasComment("淨重");

                entity.Property(e => e.Out_Box_Height).HasComment("內盒外箱高");

                entity.Property(e => e.Out_Box_Length).HasComment("內盒外箱長");

                entity.Property(e => e.Out_Box_Meas).HasComment("內盒外箱材積");

                entity.Property(e => e.Out_Box_Unit)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("內盒外箱單位");

                entity.Property(e => e.Out_Box_Width).HasComment("內盒外箱寬");

                entity.Property(e => e.Out_Box_YN)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("內盒外箱否");

                entity.Property(e => e.Purchase_Dept_ID)
                    .IsUnicode(false)
                    .HasComment("採購單位");

                entity.Property(e => e.Purchase_Factory)
                    .IsUnicode(false)
                    .HasComment("採購廠區");

                entity.Property(e => e.Purchase_Print)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("訂購單列印格式");

                entity.Property(e => e.Purchase_Type)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("採購型態");

                entity.Property(e => e.Service_Parts_Factory)
                    .IsUnicode(false)
                    .HasComment("庶務零件所屬廠別");

                entity.Property(e => e.Size_Print)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("尺寸列印否");

                entity.Property(e => e.Tool_Class)
                    .IsUnicode(false)
                    .HasComment("使用工具類別");

                entity.Property(e => e.Update_By)
                    .IsUnicode(false)
                    .HasComment("異動者");

                entity.Property(e => e.Update_Time).HasComment("異動時間");

                entity.Property(e => e.Yield).HasComment("允收率");
            });

            modelBuilder.Entity<HP_Squad_Time_Sequence_ie24>(entity =>
            {
                entity.HasKey(e => new { e.Squad, e.Seq, e.Factory_ID })
                    .HasName("PK_HP_Squad_Time_Sequence");

                entity.Property(e => e.Squad)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("班別");

                entity.Property(e => e.Seq).HasComment("時間序號");

                entity.Property(e => e.Factory_ID)
                    .IsUnicode(false)
                    .HasComment("廠別");

                entity.Property(e => e.HP_Date).HasComment("HP異動日");

                entity.Property(e => e.HP_User)
                    .IsUnicode(false)
                    .HasComment("HP異動者");

                entity.Property(e => e.Step)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("時間段(每分鐘)");

                entity.Property(e => e.Update_By)
                    .IsUnicode(false)
                    .HasComment("異動者");

                entity.Property(e => e.Update_Time).HasComment("異動時間");
            });

            modelBuilder.Entity<HP_Style_Tool_Setup_j12>(entity =>
            {
                entity.HasKey(e => new { e.Style_No, e.Tool_Class, e.Tool_No, e.Seq });

                entity.HasComment("鞋型工具尺寸對照");

                entity.Property(e => e.Style_No)
                    .IsUnicode(false)
                    .HasComment("鞋型");

                entity.Property(e => e.Tool_Class)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("工具類別");

                entity.Property(e => e.Tool_No)
                    .IsUnicode(false)
                    .HasComment("工具代號");

                entity.Property(e => e.Seq).HasComment("序號(1-30)");

                entity.Property(e => e.HP_Date).HasComment("HP異動日");

                entity.Property(e => e.HP_User)
                    .IsUnicode(false)
                    .HasComment("HP異動者");

                entity.Property(e => e.Style_Size)
                    .IsUnicode(false)
                    .HasComment("鞋型尺寸");

                entity.Property(e => e.Tool_Size)
                    .IsUnicode(false)
                    .HasComment("工具尺寸");

                entity.Property(e => e.Update_By)
                    .IsUnicode(false)
                    .HasComment("異動者");

                entity.Property(e => e.Update_Time).HasComment("異動時間");
            });

            modelBuilder.Entity<VW_Squad_Time>(entity =>
            {
                entity.ToView("VW_Squad_Time");

                entity.Property(e => e.Dept_ID)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.End_Time)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Factory_ID).IsUnicode(false);

                entity.Property(e => e.Squad)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Start_Time)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}