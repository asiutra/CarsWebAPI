using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsWebAPI.Models;

namespace CarsWebAPI.Service.Interface
{
    public interface ICarService
    {
        IEnumerable<Car> AddCarAsync(Car addCar);
        Car GetCarAsync(int id);
        IEnumerable<Car> GetAllCarsAsync();
        Car UpdateCarAsync();
        Car DeleteCarAsync();
    }
}
