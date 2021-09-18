using Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellar_HomeTest.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VehicleController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly IBoatService _boatService;
        private readonly IBusService _busService;


        public VehicleController(ICarService carService, IBoatService boatService, IBusService busService)
        {
            _carService = carService;
            _boatService = boatService;
            _busService = busService;

        }

        [HttpGet]
        public IActionResult GetCarListByColor(string color)
        {
            var res = _carService.GetCarListByColor(color);
            return Ok(res);
        }

        [HttpPost]
        public IActionResult TurnOnOrOffTheLights([FromQuery] Guid id)
        {
            var res = _carService.SetChangeHeadlightStatusByCarId(id);
            return Ok(res);
        }

        [HttpDelete]
        public IActionResult RemoveCarById(Guid id)
        {
            var res = _carService.RemoveCarById(id);
            return Ok(res);
        }

        [HttpGet]
        public IActionResult GetBusListByColor(string color)
        {
            var res = _busService.GetBusListByColor(color);
            return Ok(res);
        }

        [HttpGet]
        public IActionResult GetBoatListByColortBoat(string color)
        {
            var res = _boatService.GetBoatListByColor(color);
            return Ok(res);
        }

        

    }
}
