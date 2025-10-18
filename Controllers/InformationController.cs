using HngWebApiProject.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HngWebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        public readonly IGetInformationService _infoservice;
        public InformationController(IGetInformationService infoservice)
        {
            _infoservice = infoservice;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        { 
           var response = await _infoservice.GetMyInformation();

           return Ok(response);
        }
    }
}
