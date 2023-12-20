using ConsoleApp1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>()
            {
                new EmployeeModel() {Id = 1, Name = "Employee 1"},
                new EmployeeModel() {Id = 2, Name = "Employee 2"}
            };
        }
        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> Gert(int id){
            
            if (id == 0)
            {
                return NotFound();
            }

            return new EmployeeModel() { Id = 4, Name = "Employee AR" };
        }


        
    }
}
