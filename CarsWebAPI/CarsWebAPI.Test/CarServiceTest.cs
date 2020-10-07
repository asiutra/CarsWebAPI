using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarsWebAPI.Models;
using CarsWebAPI.Service;
using Xunit;

namespace CarsWebAPI.Test
{
    public class CarServiceTest
    {
        [Fact]
        public void GetCarAsyncTest()
        {
            int Id = 1;
            string Brand = "Audi";
            string Model = "Q8";
            string Color = "Orange";
            string HorsePower = "450";
            int Doors = 5;

            CarService cs = new CarService();
            Assert.Equal(Id, cs.GetCarAsync(1).Id);
            Assert.Equal(Brand, cs.GetCarAsync(1).Brand);
            Assert.Equal(Model, cs.GetCarAsync(1).Model);
            Assert.Equal(Color, cs.GetCarAsync(1).Color);
            Assert.Equal(HorsePower, cs.GetCarAsync(1).HorsePower);
            Assert.Equal(Doors, cs.GetCarAsync(1).Doors);
        }

        [Fact]
        public void GetAllCarsAsyncTest()
        {
            int Id = 1;
            string Brand = "Audi";
            string Model = "Q8";
            string Color = "Orange";
            string HorsePower = "450";
            int Doors = 5;

            CarService cs = new CarService();
            Assert.Equal(Id, cs.GetAllCarsAsync().ElementAt(0).Id);
            Assert.Equal(Brand, cs.GetAllCarsAsync().ElementAt(0).Brand);
            Assert.Equal(Model, cs.GetAllCarsAsync().ElementAt(0).Model);
            Assert.Equal(Color, cs.GetAllCarsAsync().ElementAt(0).Color);
            Assert.Equal(HorsePower, cs.GetAllCarsAsync().ElementAt(0).HorsePower);
            Assert.Equal(Doors, cs.GetAllCarsAsync().ElementAt(0).Doors);
        }

        [Fact]
        public void AddCarAsyncTest()
        {
            CarService cs = new CarService();
            cs.AddCarAsync(new Car()
            {
                Id = 2,
                Brand = "Volvo",
                Model = "XC90",
                Color = "White",
                HorsePower = "320"
            });

            int Id = 2;
            string Brand = "Volvo";
            string Model = "XC90";
            string Color = "White";
            string HorsePower = "320";
            int Doors = 5;

            Assert.Equal(Id, cs.GetCarAsync(2).Id);
            Assert.Equal(Brand, cs.GetCarAsync(2).Brand);
            Assert.Equal(Model, cs.GetCarAsync(2).Model);
            Assert.Equal(Color, cs.GetCarAsync(2).Color);
            Assert.Equal(HorsePower, cs.GetCarAsync(2).HorsePower);
            Assert.Equal(Doors, cs.GetCarAsync(2).Doors);
        }
    }
}
