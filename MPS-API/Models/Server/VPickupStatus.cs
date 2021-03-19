﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPS_API.Models
{
    public partial class VPickupStatus
    {
        [Required]
        [StringLength(15)]
        public string manno { get; set; }
        [Required]
        [StringLength(3)]
        public string seq { get; set; }
        [StringLength(15)]
        public string style { get; set; }
        [StringLength(40)]
        public string styna { get; set; }
        [StringLength(10)]
        public string scolna { get; set; }
        [Required]
        [StringLength(3)]
        public string teamno { get; set; }
        [StringLength(3)]
        public string Line_ID { get; set; }
        [Required]
        [StringLength(10)]
        public string trno { get; set; }
        [Required]
        [StringLength(2)]
        public string kind { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal seqqty { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal batchqty { get; set; }
        [Column(TypeName = "date")]
        public DateTime? as_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? as_edate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? cut_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? cut_edate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? stfi_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? stfi_edate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? sti_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? sti_edate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? whchkstock_at { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? settingmatl_at { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? prepare_at { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dispatch_at { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? call_at { get; set; }
        [StringLength(10)]
        public string Dispatch_To { get; set; }
        [StringLength(37)]
        public string Area_Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PartPrepareDate { get; set; }
        [StringLength(1)]
        public string isHadPrepareBalance { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DispatchDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpireProdReceiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActualProdReceiveDate { get; set; }
        [StringLength(1)]
        public string isHadProdReceiveBalance { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WHNoticeDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProdClosingDate { get; set; }
    }
}