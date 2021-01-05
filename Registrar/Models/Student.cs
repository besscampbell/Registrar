using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Registrar.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<CourseStudent>();
        }
        public int StudentId { get; set; }
        public string Name { get; set; }
        [DisplayName("EnrollmentDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<CourseStudent> Courses { get; }

        public int DeptId { get; set; }
        public Dept Dept { get; set; }
    }
}