using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AppDB.Models
{
    [Table("PC")]
    public class Pc
    {
        [Key]
        [Column("code")]
        public int Code { get; set; }
        [Required]
        [Column("model")]
        [StringLength(50)]
        public string Model { get; set; }
        [Column("speed")]
        public short Speed { get; set; }
        [Column("ram")]
        public short Ram { get; set; }
        [Column("hd")]
        public float Hd { get; set; }
        [Required]
        [Column("cd")]
        [StringLength(10)]
        public string Cd { get; set; }
        [Column("price", TypeName = "money")]
        public decimal? Price { get; set; }

        [ForeignKey(nameof(Model))]
        [InverseProperty(nameof(Product.Pcs))]
        public virtual Product ModelNavigation { get; set; }
    }
}
