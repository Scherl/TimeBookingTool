﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TimeBooking.Data.Models
{
    [Table("WorkingTime")]
    [Index("Year", "Month", Name = "UK_WorkingTime", IsUnique = true)]
    public partial class WorkingTime
    {
        [Key]
        public Guid WorkingTimeId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        [Column("WorkingTime", TypeName = "numeric(18, 2)")]
        public decimal WorkingTime1 { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal DailyWorkingTime { get; set; }
    }
}