using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class RoutingsController : ControllerBase
    {
        IRoutingService _routingService;
        public RoutingsController(IRoutingService routingService)
        {
            _routingService = routingService;   
        }

        [HttpGet]
        [Route("/api/routing/get")]
        public IActionResult Get()
        {
            var res = _routingService.GetAll();
            return Ok(res);

        }


        [HttpPost]
        [Route("/api/routing/add")]
        public IActionResult Add([FromBody] Routing r)
        {
            var res = _routingService.Add(r);
            return Ok(res);

        }
    }
}
