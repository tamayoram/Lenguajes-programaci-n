using EFexample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFexample.DAL
{
    public class SchoolInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Pablo",LastName="Suarez",EnrollmentDate=DateTime.Parse("2009-09-01")},
            new Student{FirstMidName="Juan",LastName="Perez",EnrollmentDate=DateTime.Parse("2010-09-01")},
            new Student{FirstMidName="Arturo",LastName="Tamayo",EnrollmentDate=DateTime.Parse("2004-09-01")},
            new Student{FirstMidName="Andrea",LastName="Ramirez",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{FirstMidName="Paula",LastName="Zapata",EnrollmentDate=DateTime.Parse("2014-09-01")},
            new Student{FirstMidName="Camilo",LastName="Vahos",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Laura",LastName="Pimienta",EnrollmentDate=DateTime.Parse("2011-09-01")},
            new Student{FirstMidName="Victor",LastName="Paz",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=105,Title="Lenguajes",Credits=3,},
            new Course{CourseID=402,Title="WebI",Credits=3,},
            new Course{CourseID=404,Title="WebII",Credits=3,},
            new Course{CourseID=104,Title="MovilesI",Credits=4,},
            new Course{CourseID=314,Title="Avanzada",Credits=4,},
            new Course{CourseID=202,Title="MovilesII",Credits=3,},
            new Course{CourseID=204,Title="LenguajesII",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=105,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=402,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=404,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=104,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=314,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=202,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=105},
            new Enrollment{StudentID=4,CourseID=105,},
            new Enrollment{StudentID=4,CourseID=402,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=404,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=104},
            new Enrollment{StudentID=7,CourseID=314,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }

    }
}