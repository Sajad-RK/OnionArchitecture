using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Teachers
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<TeacherCourse> Courses { get; set; }
    }
}
