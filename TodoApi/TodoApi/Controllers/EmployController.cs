using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployAController : ControllerBase
    {
        [HttpGet]
        [Route("Details")]
        public IActionResult GetEmployData()
        {
            List<string> employData = new List<string>()
            {
                "sam ", "shiv" ,"sid", "ram"
            };
          return this.Ok(new {Succuss=true,message="get data successful",Data =employData});
        }
        [HttpGet("Addresses")]
        public IActionResult GetEmployAddress()
        {
            List<string> employData = GetAddress();
            return this.Ok(new { Succuss = true, message = "get address successful", Data = employData });
        }

        private static List<string> GetAddress()
        {
            return new List<string>()
            {
                "jabalpur", "delhi" ,"vijay nagar", "noida"
            };
        }
        [HttpPost("{Address}")]
        public IActionResult RegisterEmployAddress(string Address)
        {
            List<string> employData = GetAddress();
            employData.Add(Address);
            return this.Ok(new { Succuss = true, message = "Register Address successful", Data = employData });
        }
    }
}
