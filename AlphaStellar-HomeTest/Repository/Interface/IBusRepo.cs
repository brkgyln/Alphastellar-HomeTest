using Entities;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IBusRepo
    {

       IEnumerable<Bus> GetBusListByColor(string color);
        
    }
}
