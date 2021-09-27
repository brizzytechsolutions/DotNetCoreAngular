using AspNetAndAngular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAndAngular.DataDbContext
{
    public class DealershipDbContext : DbContext
    {
        public DealershipDbContext(DbContextOptions<DealershipDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleStatus> VehicleStatuses { get; set; }
    }
}
