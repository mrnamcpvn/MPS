﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPS_API.Models
{
    public partial class VW_Cmpt_Process_PlanTransaction_POBatch
    {
        [Required]
        [StringLength(1)]
        public string manuf { get; set; }
        [Required]
        [StringLength(15)]
        public string manno { get; set; }
        [Required]
        [StringLength(3)]
        public string seq { get; set; }
        [StringLength(40)]
        public string styna { get; set; }
        [StringLength(15)]
        public string style { get; set; }
        [StringLength(10)]
        public string scolna { get; set; }
        [Column(TypeName = "decimal(7, 1)")]
        public decimal totqty { get; set; }
        [Required]
        [StringLength(3)]
        public string teamno { get; set; }
        [Required]
        [StringLength(12)]
        public string Cell_Name { get; set; }
        [Required]
        [StringLength(5)]
        public string code { get; set; }
        [StringLength(80)]
        public string Process_Na { get; set; }
        [Required]
        [StringLength(4)]
        public string part { get; set; }
        [StringLength(60)]
        public string Part_E_Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime as_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime as_edate { get; set; }
        [Column(TypeName = "date")]
        public DateTime cut_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime cut_edate { get; set; }
        [Column(TypeName = "date")]
        public DateTime stfi_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime stfi_edate { get; set; }
        [Column(TypeName = "date")]
        public DateTime sti_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime sti_edate { get; set; }
        [Required]
        [StringLength(10)]
        public string Feedback_Stage { get; set; }
        [Column(TypeName = "decimal(38, 1)")]
        public decimal? Transaction_Qty { get; set; }
    }
}