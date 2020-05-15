using Core.Entities.Courses;

namespace Core.Entities.Teachers
{
    public class TeacherCourse
    {
        public int TeacherCourseId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Course Course { get; set; }
    }
}
