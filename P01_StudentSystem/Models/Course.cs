using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    class Course
    {
        public int CourseId { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(255)")]
        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Precision(10, 2)]
        public decimal Price { get; set; }

        public ICollection<Resource> Resources { get; set; } = new List<Resource>();
        public ICollection<Homework> Homeworks { get; set; } = new List<Homework>();
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}
