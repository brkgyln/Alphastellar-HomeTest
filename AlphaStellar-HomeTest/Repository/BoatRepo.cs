using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Entities;
using static Entities.CommonEnum;

namespace Repository
{
    public class BoatRepo:IBoatRepo
    {
         public List<Boat> Boats = new List<Boat>(){
         new Boat {Id = Guid.NewGuid(),MotorPower = 9  ,Brand = "Mercedes", Color = Colors.White},
         new Boat {Id = Guid.NewGuid(),MotorPower = 9  , Brand = "BMC", Color = Colors.Black},
         new Boat {Id = Guid.NewGuid(),MotorPower = 29 , Brand = "DAF", Color = Colors.Red},
         new Boat {Id = Guid.NewGuid(),MotorPower = 19 , Brand = "Heuliez", Color = Colors.White},
         new Boat {Id = Guid.NewGuid(),MotorPower = 9  , Brand = "Mercedes", Color = Colors.Blue},
         new Boat {Id = Guid.NewGuid(),MotorPower = 9  , Brand = "Samba", Color = Colors.Black},
         new Boat {Id = Guid.NewGuid(),MotorPower = 19 , Brand = "Temsa", Color = Colors.White},
         new Boat {Id = Guid.NewGuid(),MotorPower = 19 , Brand = "Mercedes", Color = Colors.Blue},
         new Boat {Id = Guid.NewGuid(),MotorPower = 29 , Brand = "Mercedes", Color = Colors.Red},
         new Boat {Id = Guid.NewGuid(),MotorPower = 19 , Brand = "Mercedes", Color = Colors.Red},

     };

        public IEnumerable<Boat> GetBoatListByColor(string color)
        {
            var res = Boats.Where(s => s.Color == color).ToList();
            return res;

        }
    }


}
