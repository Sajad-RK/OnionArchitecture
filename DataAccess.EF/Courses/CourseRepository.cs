using Core.Contracts.Courses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EF.Courses
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CoreStore_Context _context;

        public CourseRepository(CoreStore_Context context)
        {
            this._context = context;
        }
    }
}
