using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAndAngular.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public string Country { get; set; }

        public Model Model { get; set; }
    }
}
