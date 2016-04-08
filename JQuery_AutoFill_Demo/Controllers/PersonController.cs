using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JQuery_AutoFill_Demo.Models;

namespace JQuery_AutoFill_Demo.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            using (AdventureWorks2014Entities1 db = new AdventureWorks2014Entities1())
            {
                var X = from r in db.People
                        select new { r.FirstName, r.LastName };

                //var v = db.People.ToList();
                return View(X.ToList());
            }
                
        }
    }
}