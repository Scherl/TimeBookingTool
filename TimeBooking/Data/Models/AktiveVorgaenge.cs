// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TimeBooking.Data.Models
{
    [Keyless]
    public partial class AktiveVorgaenge
    {
        public Guid VorgangId { get; set; }
        public Guid ProjektId { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string VorgangBezeichnung { get; set; }
        public bool Aktiv { get; set; }
        public bool Ferien { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Stundenansatz { get; set; }
    }
}