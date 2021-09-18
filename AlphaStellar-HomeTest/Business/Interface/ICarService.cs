using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public interface ICarService
    {
        IEnumerable<Car> GetAllCarList();
        IEnumerable<Car> GetCarListByColor(string color);
        bool SetChangeHeadlightStatusByCarId(int id);
        bool RemoveCarById(int id);
    
    }
}
