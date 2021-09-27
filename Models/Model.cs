using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAndAngular.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string ModelName { get; set; }
        public DateTime FirstProducationDate { get; set; } = DateTime.Now;

        public Vehicle Vehicle { get; set; }
    }
}
