using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplications.Models;
using WebApplications.Services;

namespace WebApplications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            return _employeeService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Employee GetById(int id)
        {
            return _employeeService.GetById(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _employeeService.Delete(id);
        }

        [HttpPost]
        public void Post(Employee employee)
        {
            _employeeService.Post(employee);
        }

        [HttpPut]
        public void Put(int id, Employee employee)
        {
            _employeeService.Put(id, employee);
        }
    }
}
