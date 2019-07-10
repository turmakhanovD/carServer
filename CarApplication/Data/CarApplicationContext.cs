using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarApplication.Models
{
    public class CarApplicationContext : DbContext
    {
        public CarApplicationContext (DbContextOptions<CarApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<CarApplication.Models.Car> Car { get; set; }
    }
}
