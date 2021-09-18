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
         new Boat {Id = 1,MotorPower = 9  ,Brand = "Mercedes", Color = Colors.White},
         new Boat {Id = 2,MotorPower = 9  , Brand = "BMC", Color = Colors.Black},
         new Boat {Id = 3,MotorPower = 29 , Brand = "DAF", Color = Colors.Red},
         new Boat {Id = 4,MotorPower = 19 , Brand = "Heuliez", Color = Colors.White},
         new Boat {Id = 5,MotorPower = 9  , Brand = "Mercedes", Color = Colors.Blue},
         new Boat {Id = 6,MotorPower = 9  , Brand = "Samba", Color = Colors.Black},
         new Boat {Id = 7,MotorPower = 19 , Brand = "Temsa", Color = Colors.White},
         new Boat {Id = 8,MotorPower = 19 , Brand = "Mercedes", Color = Colors.Blue},
         new Boat {Id = 9,MotorPower = 29 , Brand = "Mercedes", Color = Colors.Red},
         new Boat {Id = 10,MotorPower = 19 , Brand = "Mercedes", Color = Colors.Red},

     };

        public IEnumerable<Boat> GetBoatListByColor(string color)
        {
            var res = Boats.Where(s => s.Color == color).ToList();
            return res;

        }
    }


}
