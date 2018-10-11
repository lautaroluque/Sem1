using System.Collections.Generic;

namespace Entities
{
    public class Teacher : Person
    {
        public int TeacherId { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}