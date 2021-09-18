using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public interface ICarService
    {
        IEnumerable<Car> GetCarListByColor(string color);
        bool SetChangeHeadlightStatusByCarId(Guid id);
        bool RemoveCarById(Guid id);
    
    }
}
