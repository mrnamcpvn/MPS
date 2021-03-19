﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPS_API.Models
{
    public partial class vPOwithoutMerged
    {
        [Required]
        [StringLength(2)]
        public string manuf { get; set; }
        [Required]
        [StringLength(15)]
        public string manno { get; set; }
        [Required]
        [StringLength(3)]
        public string seq { get; set; }
        [Required]
        [StringLength(3)]
        public string teamno { get; set; }
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
        public DateTime? create_at { get; set; }
        [Column(TypeName = "date")]
        public DateTime? update_at { get; set; }
        [Column(TypeName = "date")]
        public DateTime? sti_bdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? sti_edate { get; set; }
        [StringLength(4)]
        public string stype { get; set; }
        [Column(TypeName = "date")]
        public DateTime? trt_bdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? prepare_at { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? call_at { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dispatch_at { get; set; }
        [Required]
        [StringLength(10)]
        public string trno { get; set; }
        [Required]
        [StringLength(2)]
        public string kind { get; set; }
    }
}