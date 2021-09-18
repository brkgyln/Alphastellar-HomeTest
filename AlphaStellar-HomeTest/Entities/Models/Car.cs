using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class Car:Vehicle
    {
        [Range(1, 32)]
        public int WheelsNumber { get; set; }
        public bool Headlight { get; set; }
    }
}
