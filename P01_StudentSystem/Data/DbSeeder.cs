using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    class DbSeeder
    {
        public static void Seed(ApplicationDBContext context)
        {
            /* 
             * "Before we start adding new records, check if the database already has any students.
             * If it does — that means we already seeded before — so just exit the method and do nothing."
            */
            if (context.Students.Any()) return;

            // Add students
            var students = new[]
            {
                new Student { Name = "Hisham", RegisteredOn = DateTime.Now,Birthday = new DateTime(1999, 01, 30) },
                new Student { Name = "Sara", RegisteredOn = DateTime.Now }
            };

            // Add courses
            var courses = new[]
            {
                new Course { Name = "C# Basics", Price = 100, StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1) },
                new Course { Name = "Entity Framework", Price = 150, StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1) }
            };

            context.Students.AddRange(students);
            context.Courses.AddRange(courses);
            context.SaveChanges();

            // Enroll students in courses
            var enrollments = new[]
            {
                new StudentCourse { StudentId = students[0].StudentId, CourseId = courses[0].CourseId },
                new StudentCourse { StudentId = students[1].StudentId, CourseId = courses[1].CourseId }
            };

            // Add resources
            var resources = new[]
            {
                new Resource { Name = "Intro Video", Url = "http://udemy.com", CourseId = courses[0].CourseId, ResourceType = ResourceType.Video }
            };

            // Add homework
            var homeworks = new[]
            {
                new Homework { Content = "homework1.zip", ContentType = ContentType.Zip, SubmissionTime = DateTime.Now, CourseId = courses[0].CourseId, StudentId = students[0].StudentId }
            };

            context.StudentCourses.AddRange(enrollments);
            context.Resources.AddRange(resources);
            context.Homeworks.AddRange(homeworks);

            context.SaveChanges();
        }
    }
}
