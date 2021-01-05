using System.Collections.Generic;

namespace Registrar.Models
{
    public class Dept
    {
        public Dept()
        {
            this.Students = new HashSet<Student>();
            this.Courses = new HashSet<Course>();
        }
        public int DeptId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}