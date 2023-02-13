﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TimeBooking.Data.Models
{
    [Table("Projekt")]
    public partial class Projekt
    {
        public Projekt()
        {
            Vorgangs = new HashSet<Vorgang>();
        }

        [Key]
        public Guid ProjektId { get; set; }
        public Guid KundeId { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string ProjektNummer { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string ProjektBezeichnung { get; set; }
        [Required]
        public bool? Aktiv { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Gesamtkosten { get; set; }
        public bool Pauschal { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Vertragsdauer { get; set; }
        public bool Mehrwertsteuer { get; set; }

        [ForeignKey("KundeId")]
        [InverseProperty("Projekts")]
        public virtual Kunde Kunde { get; set; }
        [InverseProperty("Projekt")]
        public virtual ICollection<Vorgang> Vorgangs { get; set; }
    }
}