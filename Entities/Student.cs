using System.Collections.Generic;

namespace Entities
{
    public class Student : Person

    {
        public int StudentId { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
