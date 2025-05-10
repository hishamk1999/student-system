using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    class Student
    {
        public int StudentId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(10), Unicode(false)]
        public string? PhoneNumber { get; set; } = string.Empty;

        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

        public ICollection<Homework> Homeworks { get; set; } = new List<Homework>();
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}
