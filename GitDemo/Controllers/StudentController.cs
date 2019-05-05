using GitDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        GitDemoDbEntities db = new GitDemoDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddStudent()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments,"Id", "DeptName");
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(Student stud)
        {
            db.Students.Add(stud);
            db.SaveChanges();
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DeptName");
            return View();
        }

        public ActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDepartment(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            return View();
        }

    }
}