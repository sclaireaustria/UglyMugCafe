using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UglyMugCafe.Models
{
    public class OrderContent
    {
        public string OrderId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string CustomerName { get; set; }
        public int IcedLatte { get; set; }
        public int WMC { get; set; }
        public int DirtyHorchata { get; set; }
        public int TruffleFries { get; set; }
        public int Bagel { get; set; }
        public int Espresso { get; set; }
    }
}
