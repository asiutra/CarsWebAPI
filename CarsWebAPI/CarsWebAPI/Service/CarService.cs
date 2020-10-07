using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsWebAPI.Context;
using CarsWebAPI.Models;
using CarsWebAPI.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace CarsWebAPI.Service
{
    public class CarService : ICarService
    {
        private readonly CarsWebAPIContext _context;

        public CarService(CarsWebAPIContext context)
        {
            _context = context;
        }


        //mock data
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

        


        public async Task<ServiceResponse<IEnumerable<Car>>> AddCarAsync(Car addCar)
        {
            ServiceResponse<IEnumerable<Car>> serviceResponse = new ServiceResponse<IEnumerable<Car>>();

            _context.Cars.Add(addCar);
            await _context.SaveChangesAsync();
            serviceResponse.Data = _context.Cars.ToList();

            return serviceResponse;
        }


        public async Task<ServiceResponse<Car>> GetCarAsync(int id)
        {
            ServiceResponse<Car> serviceResponse = new ServiceResponse<Car>();

            serviceResponse.Data = await _context.Cars.SingleOrDefaultAsync(c => c.Id == id);
            return serviceResponse;
        }


        public async Task<ServiceResponse<IEnumerable<Car>>> GetAllCarsAsync()
        {
            ServiceResponse<IEnumerable<Car>> serviceResponse = new ServiceResponse<IEnumerable<Car>>();

            serviceResponse.Data = await _context.Cars.ToListAsync();
            return serviceResponse;
        }


        public async Task<ServiceResponse<Car>> UpdateCarAsync(Car updatedCar)
        {
            ServiceResponse<Car> serviceResponse= new ServiceResponse<Car>();

            _context.Cars.Update(updatedCar);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.Cars.SingleOrDefaultAsync(c => c.Id == updatedCar.Id);
            return serviceResponse;
        }


        public async Task<ServiceResponse<Car>> DeleteCarAsync(int id)
        {
            ServiceResponse<Car> serviceResponse = new ServiceResponse<Car>();

            var toRemove = await _context.Cars.SingleOrDefaultAsync(c => c.Id == id);
            _context.Cars.Remove(toRemove);
            await _context.SaveChangesAsync();

            return serviceResponse;
        }
    }
}
