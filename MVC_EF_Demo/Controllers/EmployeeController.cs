using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeBL.EF;
using EmployeeBL;
using MVC_EF_Demo.Models;
namespace MVC_EF_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetAllEplmoyees()
        {
            Viewmodel vm = new Viewmodel();
            vm.Employees = GetAllEmployees();
            vm.Departments = GetAllDepartments();  
            return View(vm); // just added a comment
        }


        #region "Private functions"

        private List<Employee> GetAllEmployees()
        {
            MyFirstDBEntities myDB = new MyFirstDBEntities();
            return (myDB.Employees.ToList());
        }
        private List<Department> GetAllDepartments()
        {
            MyFirstDBEntities myDB = new MyFirstDBEntities();
            return (myDB.Departments.ToList());
        }


        # endregion

    }
}