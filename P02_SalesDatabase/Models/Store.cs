using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    class Store
    {
        public int StoreId { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        public string Name { get; set; }=string.Empty;

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
