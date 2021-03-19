﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPS_API.Models
{
    public partial class VW_Cmpt_Transaction_Detail_POBatchSize
    {
        [Column(TypeName = "date")]
        public DateTime sti_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime stfi_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime as_bdate { get; set; }
        [Required]
        [StringLength(3)]
        public string teamno { get; set; }
        [Required]
        [StringLength(15)]
        public string MO_No { get; set; }
        [Required]
        [StringLength(3)]
        public string MO_Batch { get; set; }
        [Required]
        [StringLength(4)]
        public string MO_Size { get; set; }
        [StringLength(40)]
        public string styna { get; set; }
        [StringLength(15)]
        public string style { get; set; }
        [StringLength(10)]
        public string scolna { get; set; }
        [Required]
        [StringLength(4)]
        public string Internal_Part_No { get; set; }
        [StringLength(60)]
        public string Part_E_Name { get; set; }
        [Column(TypeName = "decimal(7, 1)")]
        public decimal totqty { get; set; }
        [Required]
        [StringLength(5)]
        public string Process_No { get; set; }
        [StringLength(80)]
        public string Process_Na { get; set; }
        [Required]
        [StringLength(2)]
        public string Feedback_Stage { get; set; }
        [Column(TypeName = "date")]
        public DateTime Transaction_Date { get; set; }
        [Required]
        [StringLength(10)]
        public string Transaction_By { get; set; }
        [Required]
        [StringLength(20)]
        public string Transaction_No { get; set; }
        [Column(TypeName = "decimal(38, 1)")]
        public decimal? tot_Transaction_Qty { get; set; }
        [StringLength(10)]
        public string Work_Shift { get; set; }
        public Guid? Work_Station { get; set; }
        [Required]
        [StringLength(4)]
        public string Supplier_No { get; set; }
    }
}