using Core.Entities.Courses;

namespace Core.Entities.Students
{
    public class StudentCourse
    {
        public int StudentCourseId { get; set; }
        public virtual Student Teacher { get; set; }
        public virtual Course Course { get; set; }
    }
}
