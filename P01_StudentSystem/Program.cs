using P01_StudentSystem.Data;
using P01_StudentSystem.Models;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ApplicationDBContext();

            // Ensure the database is created
            context.Database.EnsureCreated();

            // Seed sample data if not already present
            DbSeeder.Seed(context);

            bool exit = false;


            while (!exit)
            {
                Console.WriteLine("\n===== Student System Menu =====");
                Console.WriteLine("1. View Students");
                Console.WriteLine("2. View Courses");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var students = context.Students.ToList();
                        Console.WriteLine("\n-- Students --");
                        foreach (var student in students)
                        {
                            Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Registered: {student.RegisteredOn.ToShortDateString()}");
                        }
                        break;

                    case "2":
                        var courses = context.Courses.ToList();
                        Console.WriteLine("\n-- Courses --");
                        foreach (var course in courses)
                        {
                            Console.WriteLine($"ID: {course.CourseId}, Name: {course.Name}, Price: {course.Price}");
                        }
                        break;

                    case "0":
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
