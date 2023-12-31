﻿using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };


            context.Students.AddRangeAsync(students);

            context.SaveChanges();


            var courses = new Course[]
            {

            new Course{Title="Chemistry",Credits=3,Description="Test"},//Id=1050,
            new Course{Title="Microeconomics",Credits=3,Description="Test"},
            new Course{Title="Macroeconomics",Credits=3,Description="Test"},
            new Course{Title="Calculus",Credits=4,Description="Test"},
            new Course{Title="Trigonometry",Credits=4,Description="Test"},
            new Course{Title="Composition",Credits=3,Description="Test"},
            new Course{Title="Literature",Credits=4,Description="Test"}
            };
      
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1},//,Grade=Grade.A
            new Enrollment{StudentID=2,CourseID=2},
            new Enrollment{StudentID=3,CourseID=3},
            new Enrollment{StudentID=4,CourseID=4},
            new Enrollment{StudentID=5,CourseID=5}
       
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
