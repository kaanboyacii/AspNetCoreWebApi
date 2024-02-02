using Microsoft.AspNetCore.Mvc;
using HelloWebAPI.Models;

namespace HelloWebAPI.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult getmessage()
        {
            var result = new ResponseModel()
            {
                HttpStatus = 200,
                Message = "hello developer"
            };
            return Ok(result);
        }
        //public ResponseModel GetMessage()
        //{
        //    return new ResponseModel()
        //    {
        //        HttpStatus = 200,
        //        Message = "hello developer"
        //    };
        //}
    }
}
