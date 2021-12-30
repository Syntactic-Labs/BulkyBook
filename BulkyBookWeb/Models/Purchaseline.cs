using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BulkyBookWeb.Models
{
    public class Purchaseline
    {
        [Key]
        public int Id { get; set; } = 0;
        public int Quantity { get; set; } = 1;
        public int PurchaseId { get; set; } = 0;
        public int ProductId { get; set; } = 0;
        [JsonIgnore]
        public virtual Purchase? Purchase { get; set; } = null;
        public virtual Product? Product { get; set; } = null;
    }
}
