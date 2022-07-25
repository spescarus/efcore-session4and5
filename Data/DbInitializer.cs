using Ef_core_Tutorial.Models;

namespace Ef_core_Tutorial.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student
                {
                    LastName = "Alexandru",
                    FirstMidName = "Pop ",
                    Email = "pop.alexandru@email.com",
                    EnrollmentDate = DateTime.UtcNow,
                },
                new Student
                {
                    LastName = "Vasile",
                    FirstMidName = "Pop ",
                    Email = "pop.vasile@email.com",
                    EnrollmentDate = DateTime.UtcNow,
                }
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course
                {
                    CourseId = 1050,
                    Title = "Chemistry",
                    Credits = 3
                },
                new Course
                {
                    CourseId = 4022,
                    Title = "Microeconomics",
                    Credits = 4
                },
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment
                {
                    CourseId = courses.Single(s => s.Title == "Chemistry").CourseId,
                    StudentId = students.Single(p => p.LastName == "Alexandru").Id,
                    Grade = Grade.A,
                },
                new Enrollment
                {
                CourseId = courses.Single(s => s.Title == "Microeconomics").CourseId,
                StudentId = students.Single(p => p.LastName == "Vasile").Id,
                Grade = Grade.A,
                }
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
