using Entities;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IBoatRepo
    {
        IEnumerable<Boat> GetBoatListByColor(string color);

    }
}
