using Core.Contracts.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EF.Students
{
    public class StudentRepository : IStudentRepository
    {
        private readonly CoreStore_Context _context;

        public StudentRepository(CoreStore_Context context)
        {
            this._context = context;
        }
    }
}
