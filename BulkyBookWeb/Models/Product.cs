﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBookWeb.Models
{
    [Index("BookNbr", IsUnique = true)]
    public class Product
    {
        [Key]
        public int Id { get; set; } = 0;

        [MaxLength(10),MinLength(10), Required]
        public string BookNbr { get; set; } = string.Empty;

        [StringLength(100), Required]
        public string Title { get; set; } = string.Empty;

        [StringLength(60), Required]
        public string Author { get; set; } = string.Empty;

        [Column(TypeName = "decimal(9,2)"), Required]
        public decimal Price { get; set; } = decimal.Zero;

        [MaxLength(7), Required]
        public int Unit { get; set; } = 1;

        [StringLength(30)]
        public string? PhotoPath { get; set; } = null;
        public int VendorId { get; set; } = 0;

        public virtual Vendor? Vendor { get; set; } = null;
    }
}
