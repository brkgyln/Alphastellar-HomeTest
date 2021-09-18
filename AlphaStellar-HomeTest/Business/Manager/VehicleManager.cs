using Business.Interface;
using Entities;
using Repository;
using System;
using System.Collections.Generic;

namespace Business
{
    public class VehicleManager : IBusService, ICarService, IBoatService
    {
        IBoatRepo _boatRepo;
        IBusRepo _busRepo;
        ICarRepo _carRepo;

        public VehicleManager(IBoatRepo boatRepo, IBusRepo busRepo, ICarRepo carRepo)
        {
            _boatRepo = boatRepo;
            _busRepo = busRepo;
            _carRepo = carRepo;

        }
        public IEnumerable<Boat> GetBoatListByColor(string color)

        {
            var res = _boatRepo.GetBoatListByColor(color);
            return res;

        }

        public IEnumerable<Bus> GetBusListByColor(string color)
        {
            var res = _busRepo.GetBusListByColor(color);
            return res;

        }

        public IEnumerable<Car> GetCarListByColor(string color)
        {
           var res= _carRepo.GetCarListByColor(color);
           return res;
        }

        public bool RemoveCarById(Guid id)
        {
            var res = _carRepo.RemoveCarById(id);
            return res;
        }

        public bool SetChangeHeadlightStatusByCarId(Guid id)
        {
            var res = _carRepo.SetChangeHeadlightStatusByCarId(id);
            return res;
        }
    }
}
