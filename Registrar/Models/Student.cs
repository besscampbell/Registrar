using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace Registrar.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}