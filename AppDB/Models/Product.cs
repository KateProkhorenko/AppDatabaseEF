using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AppDB.Models
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            Laptops = new HashSet<Laptop>();
            Pcs = new HashSet<Pc>();
            Printers = new HashSet<Printer>();
        }

        [Required]
        [Column("maker")]
        [StringLength(10)]
        public string Maker { get; set; }
        [Key]
        [Column("model")]
        [StringLength(50)]
        public string Model { get; set; }
        [Required]
        [Column("type")]
        [StringLength(50)]
        public string Type { get; set; }

        [InverseProperty(nameof(Laptop.ModelNavigation))]
        public virtual ICollection<Laptop> Laptops { get; set; }
        [InverseProperty(nameof(Pc.ModelNavigation))]
        public virtual ICollection<Pc> Pcs { get; set; }
        [InverseProperty(nameof(Printer.ModelNavigation))]
        public virtual ICollection<Printer> Printers { get; set; }
    }
}
