using Business.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AlphaStellar_HomeTest.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VehicleController : ControllerBase
    {
        private readonly IBaseService _service;

        public VehicleController(IBaseService service)
        {
            _service = service;
           
        }

        [HttpGet]
        public IActionResult GetAllCarList()
        {
            var res = _service.GetAllCarList();
            return Ok(res);
        }

        [HttpGet]
        public IActionResult GetCarListByColor(string color)
        {
            var res = _service.GetCarListByColor(color);
            return Ok(res);
        }

        [HttpPost]
        public IActionResult TurnOnOrOffTheLights(int id)
        {
            var res = _service.SetChangeHeadlightStatusByCarId(id);
            return Ok(res);
        }

        [HttpDelete]
        public IActionResult RemoveCarById(int id)
        {
            var res = _service.RemoveCarById(id);
            return Ok(res);
        }

        [HttpGet]
        public IActionResult GetBusListByColor(string color)
        {
            var res = _service.GetBusListByColor(color);
            return Ok(res);
        }

        [HttpGet]
        public IActionResult GetBoatListByColortBoat(string color)
        {
            var res = _service.GetBoatListByColor(color);
            return Ok(res);
        }

        

    }
}
