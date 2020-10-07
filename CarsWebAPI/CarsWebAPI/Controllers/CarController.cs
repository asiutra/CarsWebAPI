using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsWebAPI.Models;
using CarsWebAPI.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CarsWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllCar()
        {
            var carList = await _carService.GetAllCarsAsync();
            return Ok(carList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpecificCar(int id)
        {
            var specificRecord = await _carService.GetCarAsync(id);
            return Ok(specificRecord);
        }

        [HttpPost]
        public async Task<IActionResult> AddCar(Car newCar)
        {
            var car = await _carService.AddCarAsync(newCar);
            return Ok(car);
        }
    }
}