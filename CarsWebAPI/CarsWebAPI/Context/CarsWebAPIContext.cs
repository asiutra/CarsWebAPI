using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsWebAPI.Context
{
    public class CarsWebAPIContext : DbContext
    {
        public CarsWebAPIContext(DbContextOptions<CarsWebAPIContext> options) : base(options) {  }

        public DbSet<Car> Cars { get; set; }
    }
}
