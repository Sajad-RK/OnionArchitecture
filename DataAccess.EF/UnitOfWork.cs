using Core.Contracts;
using Core.Contracts.Courses;
using Core.Contracts.Students;
using DataAccess.EF.Courses;
using DataAccess.EF.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CoreStore_Context _context;

        public UnitOfWork(CoreStore_Context context)
        {
            this._context = context;
        }
        public IStudentRepository StudentRepository { get => new StudentRepository(_context); set => throw new NotImplementedException(); }
        public ICourseRepository CourseRepository { get => new CourseRepository(_context); set => throw new NotImplementedException(); }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
