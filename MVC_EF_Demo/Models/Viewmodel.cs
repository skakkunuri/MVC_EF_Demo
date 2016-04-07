using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeBL;
using EmployeeBL.EF;

namespace MVC_EF_Demo.Models
{
    public class Viewmodel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Department> Departments { get; set; }

    }
}