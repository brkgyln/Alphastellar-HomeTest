using Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using static Entities.CommonEnum;


namespace Repository
{
    public  class CarRepo:ICarRepo
    {
        public static List<Car> Cars = new List<Car>()
        {
            new Car { Id= 1, Color = Colors.White, Brand = "Mercedes", Headlight = true, WheelsNumber = 4 },
            new Car { Id =2, Color = Colors.Black, Brand = "BMV", Headlight = true, WheelsNumber = 4 },
            new Car { Id =3, Color = Colors.Black, Brand = "Scoda", Headlight = true, WheelsNumber = 4 },
            new Car { Id =4, Color = Colors.White, Brand = "Mercedes", Headlight = true, WheelsNumber = 2 },
            new Car { Id =5, Color = Colors.White, Brand = "Audi", Headlight = true, WheelsNumber = 2 },
            new Car { Id =6, Color = Colors.Black, Brand = "Renault", Headlight = false, WheelsNumber = 3 },
            new Car { Id =7, Color = Colors.Red, Brand = "Toyota", Headlight = false, WheelsNumber = 3 },
            new Car { Id =8, Color = Colors.White, Brand = "Mercedes", Headlight = true, WheelsNumber = 4 },
            new Car { Id =9, Color = Colors.Blue, Brand = "Mercedes", Headlight = false, WheelsNumber = 4 },
            new Car { Id =10, Color = Colors.Red, Brand = "Honda", Headlight = false, WheelsNumber = 4 }


        };

        public IEnumerable<Car> GetAllCarList()
        {
            var res = Cars;
            return res;

        }
        public IEnumerable<Car> GetCarListByColor(string color)
        {
            var res = Cars.Where(c => c.Color.Equals(color)).ToList();
            return res;
        }

        public bool RemoveCarById(int id)
        {
            var car = Cars.Where(s => s.Id.Equals(id)).FirstOrDefault();
            if (car is null)
            {
                return false;
            }

            Cars.Remove(car);
            return true;
        }

        public bool SetChangeHeadlightStatusByCarId(int id)
        {
            var car = Cars.Where(s => s.Id.Equals(id)).FirstOrDefault();
            if (car == null)
            {
                return false;
            }
            // flag
            car.Headlight = !car.Headlight;
            return true;
        }
    }
}