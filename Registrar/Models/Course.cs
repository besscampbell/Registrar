using System.Collections.Generic;

namespace Registrar.Models
{
    public class Course 
    {
        public Course()
        {
            this.Students = new HashSet<CourseStudent>();
        }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<CourseStudent> Students { get; set; }
        public int DeptId { get; set; }
        public Dept Dept { get; set; }
    }
}