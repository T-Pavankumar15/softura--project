using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProductTable.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProdId { get; set; }
        public string ProductName { get; set; }
        public string ProdPrice { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpiryDate { get;set; }
    }
}
