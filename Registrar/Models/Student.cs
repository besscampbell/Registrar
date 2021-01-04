using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;
// using MySql.Data.MySqlClient;

namespace Registrar.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        [DisplayName("EnrollmentDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime EnrollmentDate { get; set; }
    }
}