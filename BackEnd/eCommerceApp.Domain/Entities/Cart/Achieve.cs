using System.ComponentModel.DataAnnotations;
namespace eCommerceApp.Domain.Entities.Cart
{
    public class Achieve
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public string? UserId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}