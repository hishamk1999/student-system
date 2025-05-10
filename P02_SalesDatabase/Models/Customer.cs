using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    class Customer
    {
        public int CustomerId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }=string.Empty;

        [Column(TypeName = "varchar(80)")] // not unicode
        public string Email { get; set; } = string.Empty;

        public string CreaditCardNumber { get; set; } = string.Empty;

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
