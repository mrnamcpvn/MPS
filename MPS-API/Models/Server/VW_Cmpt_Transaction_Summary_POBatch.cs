﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPS_API.Models
{
    public partial class VW_Cmpt_Transaction_Summary_POBatch
    {
        [Required]
        [StringLength(15)]
        public string MO_No { get; set; }
        [Required]
        [StringLength(3)]
        public string MO_Batch { get; set; }
        [Required]
        [StringLength(5)]
        public string Process_No { get; set; }
        [Required]
        [StringLength(4)]
        public string Internal_Part_No { get; set; }
        [Required]
        [StringLength(2)]
        public string Feedback_Stage { get; set; }
        [Column(TypeName = "decimal(38, 1)")]
        public decimal? tot_Transaction_Qty { get; set; }
        [StringLength(20)]
        public string Transaction_No { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Transaction_Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Transaction_At { get; set; }
        [StringLength(10)]
        public string Transaction_By { get; set; }
        [StringLength(1)]
        public string Processing_Last_Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Processing_Finish_Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Processing_Finish_At { get; set; }
        [StringLength(10)]
        public string Processing_Finish_By { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InsertAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(15)]
        public string Workstation_Code { get; set; }
        [StringLength(10)]
        public string TreatmentGroup_Code { get; set; }
        [StringLength(10)]
        public string WorkstationType_Code { get; set; }
        [StringLength(5)]
        public string Workstation_Seq { get; set; }
    }
}