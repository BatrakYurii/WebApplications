using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplications.Models;

namespace WebApplications.Services
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAll();
        public Employee GetById(int id);
        public void Put(int deleteId, Employee employee);
        public void Delete(int id);
        public void Post(Employee employee);
    }
}
