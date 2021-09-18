using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Vehicle
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(32)]
        public string Color { get; set; }
        public string Brand { get; set; }
    }
}
