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
        public IActionResult GetAllCar()
        {
            var carList = _carService.GetAllCarsAsync();
            return Ok(carList);
        }

        [HttpGet("{id}")]
        public IActionResult GetSpecificCar(int id)
        {
            var specificRecord = _carService.GetCarAsync(id);
            return Ok(specificRecord);
        }

        [HttpPost]
        public IActionResult AddCar(Car newCar)
        {
            var car = _carService.AddCarAsync(newCar);
            return Ok(car);
        }
    }
}