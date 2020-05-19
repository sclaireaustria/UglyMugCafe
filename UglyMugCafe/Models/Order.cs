using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UglyMugCafe.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public int IcedLatte { get; set; }
        [Required]
        public int WMC { get; set; }
        [Required]
        public int DirtyHorchata { get; set; }
        [Required]
        public int TruffleFries { get; set; }
        [Required]
        public int Bagel { get; set; }
        [Required]
        public int Espresso { get; set; }
        [Required]
        public int StatusId { get; set; }
    }
}
