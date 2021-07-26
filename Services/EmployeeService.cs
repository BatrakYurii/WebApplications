using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplications.Models;
using System.Linq;

namespace WebApplications.Services
{
    public class EmployeeService : IEmployeeService
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1,FullName="Steave",ShopId=1 } ,
            new Employee { Id = 2,FullName="Anna", ShopId=1 } ,
            new Employee { Id = 3,FullName="Robert", ShopId=2 }
        };

        public IEnumerable<Employee> GetAll()
        {
            return employees;
            
        }
        public void Delete(int id)
        {
            employees.RemoveAll(e => e.Id == id);
        }
        public void Post(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee GetById(int id)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                    return employee;
            }
            return null;
        }

        public void Put(int deleteId, Employee employee)
        {
            employees.RemoveAll(e => e.Id == deleteId);
            employee.Id = deleteId;
            employees.Add(employee);
            
        }
    }
}
