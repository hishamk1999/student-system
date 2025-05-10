using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    class Product
    {
        public int ProductId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; } =string.Empty;

        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; } = "No description";

        public double Quantity { get; set; }

        public decimal Price { get; set; }

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
