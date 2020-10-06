using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsWebAPI.Models;
using CarsWebAPI.Service.Interface;

namespace CarsWebAPI.Service
{
    public class CarService : ICarService
    {
        private static List<Car> CarsList = new List<Car>
        {
            new Car
            {
                Id = 1,
                Brand = "Audi",
                Model = "Q8",
                Color = "Orange",
                HorsePower = "450"
            }
            
        };


        public IEnumerable<Car> AddCarAsync(Car addCar)
        {
            CarsList.Add(addCar);
            return CarsList.ToList();
        }

        public Car GetCarAsync(int id)
        {
            return CarsList.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Car> GetAllCarsAsync()
        {
            return CarsList.ToList();
        }

        public Car UpdateCarAsync()
        {
            throw new NotImplementedException();
        }

        public Car DeleteCarAsync()
        {
            throw new NotImplementedException();
        }
    }
}
