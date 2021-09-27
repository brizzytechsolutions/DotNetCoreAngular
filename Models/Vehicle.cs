using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAndAngular.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Colour { get; set; }
    }
}
