using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UglyMugCafe.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }
        [Required]
        public String ProductName { get; set; }
        [Required]
        public String ProductPhoto { get; set; }
        [Required]
        public String Price { get; set; }
        [Required]
        public String Description { get; set; }
    }
}
