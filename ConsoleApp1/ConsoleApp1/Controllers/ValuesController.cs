using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/get-all")]    
        public string GetAll()
        {
            return "Method GetAll Works";
        }
        [Route("api/get-all-author")]    
        public string GetAllAuthor()
        {
            return "Method GetAllAuthor Works";
        }
    }
}
