using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GitDemo.Models;
namespace GitDemo.Controllers
{
    public class EmployeeController : Controller
    {
        GitDemoDbEntities db = new GitDemoDbEntities();
        public ActionResult GetEmployees()
        {
            return View(db.Employees.Include("Department"));
        }
        
        public ActionResult AddEmployee()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DeptName");
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DeptName");
            return RedirectToAction("GetEmployees");
        }

        public ActionResult ViewMap(int id)
        {
            return View(db.Employees.Include("Department").SingleOrDefault(x=>x.Id==id));
        }
    }
}