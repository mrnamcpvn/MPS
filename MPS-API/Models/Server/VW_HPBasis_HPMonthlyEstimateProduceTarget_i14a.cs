﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPS_API.Models
{
    public partial class VW_HPBasis_HPMonthlyEstimateProduceTarget_i14a
    {
        [Required]
        [StringLength(10)]
        public string Factory_ID { get; set; }
        [Column(TypeName = "date")]
        public DateTime Produce_Date { get; set; }
        [Required]
        [StringLength(3)]
        public string Dept_ID { get; set; }
        [Column(TypeName = "decimal(9, 1)")]
        public decimal? Target_Yield { get; set; }
        [Column(TypeName = "decimal(9, 1)")]
        public decimal? Target_WorkHours { get; set; }
    }
}