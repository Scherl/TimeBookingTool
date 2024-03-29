﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TimeBooking.Data.Models
{
    [Table("Expenses")]
    public partial class Expense
    {
        [Key]
        public Guid ExpenseId { get; set; }
        public Guid EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Amount { get; set; }
        [Required]
        [StringLength(250)]
        public string OccasionLocation { get; set; }
        [Required]
        [StringLength(250)]
        public string ExpenseType { get; set; }
        public bool CreditCard { get; set; }

        [ForeignKey("EmployeeId")]
        [InverseProperty("Expenses")]
        public virtual Employee Employee { get; set; }
    }
}