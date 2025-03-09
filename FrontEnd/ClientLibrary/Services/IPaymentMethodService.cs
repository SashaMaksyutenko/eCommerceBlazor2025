using ClientLibrary.Models.Cart;

namespace ClientLibrary.Services
{
    public interface IPaymentMethodService
    {
        Task<IEnumerable<GetPaymentMethod>>GetPaymentMethods();
    }
}