using System.ComponentModel.DataAnnotations;
namespace eCommerceApp.Application.DTOs.Cart
{
    public class Checkout
    {
        [Required]
        public required Guid PaymentMethodId { get; set; }
        public required IEnumerable<ProcessCart> Carts { get; set; }
    }
}