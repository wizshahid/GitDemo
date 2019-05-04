using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitDemo.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}