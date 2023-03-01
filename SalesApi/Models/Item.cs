using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesApi.Models
{
    public class Item
    {
        public int Id { get; set; }
        [StringLength(40)]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }

        public Item() { }
    }
}
