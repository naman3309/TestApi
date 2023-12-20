using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController:ControllerBase
    {
        public String Get()
        {
            return "Get works";
        }
        public String Get1()
        {
            return "Get1 works";
        }
    }
}
