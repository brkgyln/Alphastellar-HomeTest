using Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public interface IBoatService
    {
        IEnumerable<Boat> GetBoatListByColor(string color);

    }
}
