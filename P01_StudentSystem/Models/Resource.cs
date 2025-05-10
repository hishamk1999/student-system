using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    class Resource
    {
        public int ResourceId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; } = string.Empty;

        [Unicode(false)]
        public string Url { get; set; } = string.Empty;

        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
