using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsWebAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
        public int Doors { get; set; } = 5;
        public string Color { get; set; }
    }
}
