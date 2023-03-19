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
    public partial class InactiveProject
    {
        public Guid ProjectId { get; set; }
        public Guid ClientId { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string ProjectNumber { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string ProjectName { get; set; }
        public bool? IsActive { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal TotalCosts { get; set; }
        public bool isFlatRate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string ContractDuration { get; set; }
    }
}