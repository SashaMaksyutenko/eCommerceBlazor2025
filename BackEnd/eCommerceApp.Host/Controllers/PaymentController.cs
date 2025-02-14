using eCommerceApp.Application.DTOs.Cart;
using eCommerceApp.Application.Services.Interfaces.Cart;
using Microsoft.AspNetCore.Mvc;
namespace eCommerceApp.Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController(IPaymentMethodService paymentMethodService) : ControllerBase
    {
        [HttpGet("payment-methods")]
        public async Task<ActionResult<IEnumerable<GetPaymentMethod>>>GetPamentMethods(){
            var methods=await paymentMethodService.GetPaymentMethods();
            if(!methods.Any())
                return NotFound();
            else
                return Ok(methods);
        }
    }
}