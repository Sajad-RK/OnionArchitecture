using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Courses
{
    public class CourseVW
    {
        public string Name { get; set; }
    }
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public virtual List<Students.StudentCourse> Students { get; set; }
        public virtual List<Teachers.TeacherCourse> Teachers { get; set; }

    }
}
