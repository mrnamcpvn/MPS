﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPS_API.Models
{
    public partial class TCentralPrepare
    {
        [Key]
        [StringLength(15)]
        public string PO { get; set; }
        [Key]
        [StringLength(4)]
        public string Batch { get; set; }
        [Key]
        [StringLength(20)]
        public string Seq { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Qty { get; set; }
        [StringLength(10)]
        public string PrepareBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PrepareAt { get; set; }
        [Key]
        public int Kind { get; set; }
    }
}