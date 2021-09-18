using Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public interface IBusService
    {

       IEnumerable<Bus> GetBusListByColor(string color);
        
    }
}
