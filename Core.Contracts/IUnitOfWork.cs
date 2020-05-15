using Core.Contracts.Courses;
using Core.Contracts.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
        ICourseRepository CourseRepository { get; set; }
        void Save();
    }
}
