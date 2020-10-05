using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarsWebAPI.Context
{
    public class CarsWebAPIContext : DbContext
    {
        public CarsWebAPIContext(DbContextOptions<CarsWebAPIContext> options) : base(options) {  }

    }
}
