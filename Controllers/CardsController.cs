using Cp1_CardFifa.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cp1_CardFifa.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CardsController : ControllerBase
    {
        private static Cards St = new Cards();
        [HttpGet]
        public ActionResult<Cards> Get()
        {
            return Ok(St);
        }
    }
}

