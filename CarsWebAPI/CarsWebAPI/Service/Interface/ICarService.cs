using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsWebAPI.Models;

namespace CarsWebAPI.Service.Interface
{
    public interface ICarService
    {
        Task<ServiceResponse<IEnumerable<Car>>> AddCarAsync(Car addCar);
        Task<ServiceResponse<Car>> GetCarAsync(int id);
        Task<ServiceResponse<IEnumerable<Car>>> GetAllCarsAsync();
        Task<ServiceResponse<Car>> UpdateCarAsync(Car updatedCar);
        Task<ServiceResponse<Car>> DeleteCarAsync(int id);
    }
}
