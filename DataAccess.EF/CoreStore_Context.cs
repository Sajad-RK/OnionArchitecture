using Core.Entities.Courses;
using Core.Entities.Students;
using Core.Entities.Teachers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EF
{
    public class DbContextFactory : IDesignTimeDbContextFactory<CoreStore_Context>
    {
        public CoreStore_Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CoreStore_Context>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H8V08E1;Initial Catalog=Core_StoreDB;Integrated Security = true;User Id=sa;Password=sqlDB2020!@#;");
            return new CoreStore_Context(optionsBuilder.Options);
        }
    }
    public class CoreStore_Context : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbQuery<CourseVW> CourseVWs { get; set; }

        public CoreStore_Context(DbContextOptions<CoreStore_Context> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<CourseVW>().ToView("CourseVw");
            base.OnModelCreating(modelBuilder);
        }
    }
}
