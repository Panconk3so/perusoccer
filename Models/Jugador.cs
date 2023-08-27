using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace perusoccer.Models
{
   public class Jugador
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? Club { get; set; }
        public List<string> Categories { get; set; } = new List<string>();
        public int Seasons { get; set; }
        public bool HasFaltas { get; set; }
        public decimal TotalAmount { get; set; }
    }
}