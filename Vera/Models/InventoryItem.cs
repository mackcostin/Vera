using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vera.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        public InventoryItem()
        {

        }
    }
}
