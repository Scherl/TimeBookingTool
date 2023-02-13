﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TimeBooking.Data.Models
{
    [Table("MitarbeiterSaldo")]
    [Index("MitarbeiterId", "Jahr", "Monat", Name = "UK_MitarbeiterSaldo", IsUnique = true)]
    public partial class MitarbeiterSaldo
    {
        [Key]
        public Guid MitarbeiterSaldoId { get; set; }
        public Guid MitarbeiterId { get; set; }
        public int Jahr { get; set; }
        public int Monat { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal StundenSaldo { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal FerienSaldo { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Soll { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Ist { get; set; }
    }
}