using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBookWeb.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required, StringLength(20)]
        public string DeliveryMode { get; set; } = "Standard";

        [Required, Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; } = decimal.Zero;

        public int UserId { get; set; } = 0;

        public virtual User? User { get; set; } = default;

        public virtual IEnumerable<Purchaseline>? Purchaselines { get; set; } = null;
    }
}
