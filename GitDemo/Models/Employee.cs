using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GitDemo.Models
{
    public class Employee
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }
        [ForeignKey("Department")]
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }

        public Department Department { get; set; }

    }
}