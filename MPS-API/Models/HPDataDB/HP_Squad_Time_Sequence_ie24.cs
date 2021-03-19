﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPS_API.Models
{
    public partial class HP_Squad_Time_Sequence_ie24
    {
        /// <summary>
        ///         /// 廠別
        /// </summary>
        [Key]
        [StringLength(10)]
        public string Factory_ID { get; set; }
        /// <summary>
        ///         /// &#29677;&#21029;
        /// </summary>
        [Key]
        [StringLength(1)]
        public string Squad { get; set; }
        /// <summary>
        ///         /// &#26178;&#38291;&#24207;&#34399;
        /// </summary>
        [Key]
        public short Seq { get; set; }
        /// <summary>
        ///         /// &#26178;&#38291;&#27573;(&#27599;&#20998;&#37912;)
        /// </summary>
        [StringLength(4)]
        public string Step { get; set; }
        /// <summary>
        ///         /// HP&#30064;&#21205;&#32773;
        /// </summary>
        [StringLength(6)]
        public string HP_User { get; set; }
        /// <summary>
        ///         /// HP&#30064;&#21205;&#26085;
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? HP_Date { get; set; }
        /// <summary>
        ///         /// &#30064;&#21205;&#32773;
        /// </summary>
        [StringLength(50)]
        public string Update_By { get; set; }
        /// <summary>
        ///         /// &#30064;&#21205;&#26178;&#38291;
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Update_Time { get; set; }
    }
}