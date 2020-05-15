using DataAccess.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Linq;

namespace EndPoint.Consoles
{

    class Program
    {

        static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(builder => {
                builder.AddFilter("Microsoft", LogLevel.Information)
                       .AddFilter("EndPoint.Console.Program", LogLevel.Debug)
                       .AddConsole();
            });
            var optionsBuilder = new DbContextOptionsBuilder<CoreStore_Context>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H8V08E1;Initial Catalog=Core_StoreDB;Integrated Security = true;User Id=sa;Password=sqlDB2020!@#;");
            optionsBuilder.UseLazyLoadingProxies();
            var context = new CoreStore_Context(optionsBuilder.Options);
            /* below is eager loading
            //var courses = context.Courses.Include(c => c.Teachers).ThenInclude(c => c.Teacher).ToList();
            */


            /*below is explicit loading*/
            //var course = context.Courses.FirstOrDefault();
            //var item1 = context.Entry(course).Collection(c => c.Teachers).Query().Where(a => a.Teacher.FirstName == "Sajad");   // حالت 1
            //context.Entry(course).Collection(c => c.Teachers).Load();   // حالت 2
            //var item2 = context.Entry(course).Reference(c => c.Name).Query().Where(a => a.Length == 4);   // حالت 3
            /*end of explicit loading examples*/



            /*below is lazy loading*/   // refer to course.cs file

            var course = context.Courses.FirstOrDefault();
            var item = course.Teachers;
            /*end of lazy loading examples*/



            //var flag = context.Database.EnsureCreated();
            Console.WriteLine("flag is => ");
            Console.ReadKey();
        }
    }
}
