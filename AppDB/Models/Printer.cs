using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AppDB.Models
{
    [Table("Printer")]
    public class Printer
    {
        [Key]
        [Column("code")]
        public int Code { get; set; }
        [Required]
        [Column("model")]
        [StringLength(50)]
        public string Model { get; set; }
        [Required]
        [Column("color")]
        [StringLength(1)]
        public string Color { get; set; }
        [Required]
        [Column("type")]
        [StringLength(10)]
        public string Type { get; set; }
        [Column("price", TypeName = "money")]
        public decimal? Price { get; set; }

        [ForeignKey(nameof(Model))]
        [InverseProperty(nameof(Product.Printers))]
        public virtual Product ModelNavigation { get; set; }
    }
}
