using System;
using System.ComponentModel.DataAnnotations;

namespace KuyumcuTakip.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; } // Altın, Gümüş, Takı vb.

        [Required]
        [Range(0.01, 10000)]
        public decimal Weight { get; set; } // Gramaj

        [Required]
        [Range(0.01, 1000000)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 100000)]
        public int Stock { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
} 