using ClientLibrary.Models;
using ClientLibrary.Models.Cart;

namespace ClientLibrary.Services
{
    public interface ICartService
    {
        Task<ServiceResponse>Checkout(Checkout checkout);
        Task<ServiceResponse>SaveCheckoutHistory(IEnumerable<CreateAchieve>achieves);
    }
}