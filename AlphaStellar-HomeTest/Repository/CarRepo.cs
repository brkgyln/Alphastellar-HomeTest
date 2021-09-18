using Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using static Entities.CommonEnum;


namespace Repository
{
    public class CarRepo:ICarRepo
    {
        public List<Car> Cars = new List<Car>()
        {
            new Car { Id = Guid.NewGuid(), Color = Colors.White, Brand = "Mercedes", Headlight = true, WheelsNumber = 4 },
            new Car { Id = Guid.NewGuid(), Color = Colors.Black, Brand = "BMV", Headlight = true, WheelsNumber = 4 },
            new Car { Id = Guid.NewGuid(), Color = Colors.Black, Brand = "Scoda", Headlight = true, WheelsNumber = 4 },
            new Car { Id = Guid.NewGuid(), Color = Colors.White, Brand = "Mercedes", Headlight = true, WheelsNumber = 2 },
            new Car { Id = Guid.NewGuid(), Color = Colors.White, Brand = "Audi", Headlight = true, WheelsNumber = 2 },
            new Car { Id = Guid.NewGuid(), Color = Colors.Black, Brand = "Renault", Headlight = true, WheelsNumber = 3 },
            new Car { Id = Guid.NewGuid(), Color = Colors.Red, Brand = "Toyota", Headlight = true, WheelsNumber = 3 },
            new Car { Id = Guid.NewGuid(), Color = Colors.White, Brand = "Mercedes", Headlight = true, WheelsNumber = 4 },
            new Car { Id = Guid.NewGuid(), Color = Colors.Blue, Brand = "Mercedes", Headlight = true, WheelsNumber = 4 },
            new Car { Id = Guid.NewGuid(), Color = Colors.Red, Brand = "Honda", Headlight = true, WheelsNumber = 4 }


        };

        public IEnumerable<Car> GetCarListByColor(string color)
        {
            var res = Cars.Where(c => c.Color.Equals(color)).ToList();
            return res;
        }

        public bool RemoveCarById(Guid id)
        {
            var car = Cars.Where(s => s.Id.Equals(id)).FirstOrDefault();
            if (car is null)
            {
                return false;
            }

            Cars.Remove(car);
            return true;
        }

        public bool SetChangeHeadlightStatusByCarId(Guid id)
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