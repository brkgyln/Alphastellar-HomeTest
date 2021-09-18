using Business.Interface;
using Entities;
using Repository;
using System;
using System.Collections.Generic;

namespace Business
{
    public class VehicleManager:IBaseService 
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

        #region Car
        public IEnumerable<Car> GetAllCarList()
        {
            var res = _carRepo.GetAllCarList();
            return res;
        }
        public bool SetChangeHeadlightStatusByCarId(int id)
        {
            var res = _carRepo.SetChangeHeadlightStatusByCarId(id);
            return res;
        }
        public IEnumerable<Car> GetCarListByColor(string color)
        {
            var res = _carRepo.GetCarListByColor(color);
            return res;
        }

        public bool RemoveCarById(int id)
        {
            var res = _carRepo.RemoveCarById(id);
            return res;
        }
        #endregion

        #region Boat
        public IEnumerable<Boat> GetBoatListByColor(string color)

        {
            var res = _boatRepo.GetBoatListByColor(color);
            return res;

        }
        #endregion

        #region Bus
        public IEnumerable<Bus> GetBusListByColor(string color)
        {
            var res = _busRepo.GetBusListByColor(color);
            return res;

        }
        #endregion

    }
}
