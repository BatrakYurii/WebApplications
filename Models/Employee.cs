using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplications.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        
    }
}
