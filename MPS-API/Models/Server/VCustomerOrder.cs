﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPS_API.Models
{
    public partial class VCustomerOrder
    {
        [Required]
        [StringLength(15)]
        public string OrderNo { get; set; }
        [Column(TypeName = "decimal(38, 0)")]
        public decimal? OrderPairs { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Est_ASY_FirstDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Est_CUT_FirstDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Est_STF_FirstDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Est_STI_FirstDate { get; set; }
    }
}