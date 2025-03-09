using System.ComponentModel.DataAnnotations;
namespace ClientLibrary.Models.Cart
{
    public class CreateAchieve : ProcessCart
    {
        [Required]
        public string UserId { get; set; } = string.Empty;
    }
}