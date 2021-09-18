using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IRepositoryWrapper
    {
        IBoatService Boat { get; }
        IBusService Bus { get; }
        ICarService Car { get; }

    }
}
