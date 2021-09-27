using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAndAngular.Models
{
    public class VehicleStatus
    {
        public int Id { get; set; }

        public string SelectedStatus { get; set; }
        public IEnumerable<SelectListItem> Status { get; set; }
    }
}
