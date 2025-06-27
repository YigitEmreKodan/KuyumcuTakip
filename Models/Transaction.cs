using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KuyumcuTakip.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        [Range(1, 10000)]
        public int Quantity { get; set; }

        [Required]
        [StringLength(10)]
        public string TransactionType { get; set; } // "Satış" veya "Alış"

        [Required]
        [Range(0.01, 1000000)]
        public decimal Price { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
} 