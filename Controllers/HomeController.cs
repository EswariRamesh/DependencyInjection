using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dependency_Injection
{
    public class HomeController : Controller
    {
        //create a reference variable of IEmployeeRepository
        /*
        private readonly IEmployeeRepository _repository;

        // Initialize the variable in the constructor

       
        public HomeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        #region Without Implementing Dependency Injection
        // GET: /<controller>/
        //public JsonResult Index()
        //{
        //    //create an instance of employee repository class and then invoke the GetAllEmployees() - Tightly Coupled with EmployeeRepository.
        //    EmployeeRepository repository = new EmployeeRepository();
        //    List<Employee> allEmployees = repository.GetAllEmployees();
        //    return Json(allEmployees);
        //}

        //public JsonResult GetEmployeeByID(int Id)
        //{
        //    EmployeeRepository repository = new EmployeeRepository();
        //    Employee employee = repository.GetEmployeeByID(Id);
        //    return Json(employee);
        //}

        #endregion

        #region Implementing Constructor Dependency Injection

        //Get All Employees
        //public JsonResult getAll()
        //{
        //    List<Employee> employees = _repository.GetAllEmployees();
        //    return Json(employees);
        //}

        //public JsonResult getEmployeeByID(int ID)
        //{
        //    Employee employee = _repository.GetEmployeeByID(ID);
        //    return Json(employee);
        //}

        #endregion

        #region Implementing Action Method Dependency Injection

        //Get All Employees

        //public JsonResult GetAll([FromServices] IEmployeeRepository repository)
        //{
        //    List<Employee> employees = repository.GetAllEmployees();
        //    return Json(employees);
        //}

        #endregion

        #region Implementing Property Injection

        //Built-in-container does not support property injection. So we are using third party services to implement property injection.

        // IOC Containers manually used Request Services from HttpContext.

        //public JsonResult GetAll()
        //{
        //    var services = this.HttpContext.RequestServices;
        //    var _repository = (IEmployeeRepository)services.GetService(typeof(IEmployeeRepository));
        //    List<Employee> employees = _repository.GetAllEmployees();
        //    return Json(employees);
        //}

        //public JsonResult GetEmployeeID(int ID)
        //{
        //    var services = this.HttpContext.RequestServices;
        //    var _repository = (IEmployeeRepository)services.GetService(typeof(IEmployeeRepository));
        //    Employee employee = _repository.GetEmployeeByID(ID);
        //    return Json(employee);
        //}

        #endregion
        */
    }



}

