using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Entities;
using static Entities.CommonEnum;

namespace Repository
{
    public class BusRepo: IBusRepo
    {
        public List<Bus> Buses = new List<Bus>(){
            new Bus {Id = Guid.NewGuid(),Capacity = 10 , Brand = "Mercedes", Color = Colors.White},
            new Bus {Id = Guid.NewGuid(),Capacity = 20 , Brand = "BMC", Color = Colors.Black},
            new Bus {Id = Guid.NewGuid(),Capacity = 30 , Brand = "DAF", Color = Colors.Red},
            new Bus {Id = Guid.NewGuid(),Capacity = 40 , Brand = "Heuliez", Color = Colors.White},
            new Bus {Id = Guid.NewGuid(),Capacity = 50 , Brand = "Mercedes", Color = Colors.Blue},
            new Bus {Id = Guid.NewGuid(),Capacity = 10 , Brand = "Opel", Color = Colors.Black},
            new Bus {Id = Guid.NewGuid(),Capacity = 20 , Brand = "Temsa", Color = Colors.White},
            new Bus {Id = Guid.NewGuid(),Capacity = 30 , Brand = "Mercedes", Color = Colors.Blue},
            new Bus {Id = Guid.NewGuid(),Capacity = 40 , Brand = "Mercedes", Color = Colors.Red},
            new Bus {Id = Guid.NewGuid(),Capacity = 50 , Brand = "Mercedes", Color = Colors.Red},

        };

        public IEnumerable<Bus> GetBusListByColor(string color)
        {
            var res = Buses.Where(b => b.Color.Equals(color)).ToList();
            return res;
        }
    }
}
