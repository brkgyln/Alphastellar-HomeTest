﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class Bus : Vehicle
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Capacity { get; set; }
    }
}
