using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _emp1;
        private readonly IEmployee _emp2;

        public EmployeeController([FromServices] IEmployee emp1, [FromServices] IEmployee emp2)
        {
            _emp1 = emp1;
            _emp2 = emp2;
        }

        [HttpGet]
        public IActionResult SingletonResult()
        {
            List<string> resultList = _emp1.GetEmployeeList();
            return new JsonResult(resultList);
        }
    }
}
