// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TimeBooking.Data.Models
{
    [Table("Buchung")]
    public partial class Buchung
    {
        [Key]
        public Guid BuchungId { get; set; }
        public Guid VorgangId { get; set; }
        public Guid MitarbeiterId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime BuchungDatum { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime BuchungZeitVon { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime BuchungZeitBis { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string BuchungText { get; set; }
        public bool Stunden { get; set; }

        [ForeignKey("MitarbeiterId")]
        [InverseProperty("Buchungs")]
        public virtual Mitarbeiter Mitarbeiter { get; set; }
        [ForeignKey("VorgangId")]
        [InverseProperty("Buchungs")]
        public virtual Vorgang Vorgang { get; set; }
    }
}