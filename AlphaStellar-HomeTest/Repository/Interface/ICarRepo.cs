using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public interface ICarRepo
    {
        IEnumerable<Car> GetCarListByColor(string color);
        bool SetChangeHeadlightStatusByCarId(Guid id);
        bool RemoveCarById(Guid id);
    
    }
}
