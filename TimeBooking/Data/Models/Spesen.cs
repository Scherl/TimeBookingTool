﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TimeBooking.Data.Models
{
    [Table("Spesen")]
    public partial class Spesen
    {
        [Key]
        public Guid SpesenId { get; set; }
        public Guid MitarbeiterId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Datum { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Betrag { get; set; }
        [Required]
        [StringLength(250)]
        public string AnlassOrt { get; set; }
        [Required]
        [StringLength(250)]
        public string Spesenart { get; set; }
        public bool Kreditkarte { get; set; }

        [ForeignKey("MitarbeiterId")]
        [InverseProperty("Spesens")]
        public virtual Mitarbeiter Mitarbeiter { get; set; }
    }
}