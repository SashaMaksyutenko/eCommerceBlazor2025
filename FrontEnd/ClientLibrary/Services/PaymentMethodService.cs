using ClientLibrary.Helper;
using ClientLibrary.Models;
using ClientLibrary.Models.Cart;

namespace ClientLibrary.Services
{
    public class PaymentMethodService(IHttpClientHelper httpClient, IApiCallHelper apiHelper) : IPaymentMethodService
    {
        public async Task<IEnumerable<GetPaymentMethod>> GetPaymentMethods()
        {
             var client = httpClient.GetPublicClient();
            var apiCall = new ApiCall
            {
                Route = Constant.Payment.GetAll,
                Type = Constant.ApiCallType.Get,
                Client = client,
                Model = null!,
                Id = null!
            };
            var result = await apiHelper.ApiCallTypeCall<Dummy>(apiCall);
            if (result.IsSuccessStatusCode)
                return await apiHelper.GetServiceResponse<IEnumerable<GetPaymentMethod>>(result);
            else
                return [];
        }
    }
}