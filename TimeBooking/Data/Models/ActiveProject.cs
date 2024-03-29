﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TimeBooking.Data.Models
{
    [Keyless]
    public partial class ActiveProject
    {
        public Guid? ProjectId { get; set; }
        public Guid? ClientId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string ClientNummer { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string ProjectName { get; set; }
        public bool? IsActiv { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? TotalCosts { get; set; }
        public bool? IsFlatRate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string ContractDuration { get; set; }
    }
}