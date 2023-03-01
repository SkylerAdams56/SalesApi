using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesApi.Models
{
    public class order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [StringLength(80)]
        public string? Description { get; set; } = null;
        [Column(TypeName = "decimal(7,2)")]
        public decimal Total { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }

        public order() { }
    }
}
