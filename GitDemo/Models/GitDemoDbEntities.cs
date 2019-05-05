using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GitDemo.Models
{
    public class GitDemoDbEntities:DbContext
    {
        public GitDemoDbEntities():base ("GitDemoDbEntities")
            {
            }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}