using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using travelAworld.Model;

namespace eRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UplataController : ControllerBase
    {
        [HttpPost("pay")]
        public IActionResult Pay(PaymentCardAdd cardInfo)
        {
            var token = GetToken(cardInfo);
            StripeConfiguration.ApiKey = "sk_test_ZYySFlXrQCDciqzHKybrdcWU";

            // `source` is obtained with Stripe.js; see https://stripe.com/docs/payments/accept-a-payment-charges#web-create-token
            var options = new ChargeCreateOptions
            {
                Amount = cardInfo.Amount*100,
                Currency = "bam",
                Source = token,
                Description = cardInfo.Desc,
            };
            var service = new ChargeService();
            Charge charge = service.Create(options);
            //service.Create(options);
            Uplata uplata = new Uplata
            {
                ChargeId = charge.Id,
                Description = charge.Description,
                UplacenoUkupno = charge.Amount,
                Status = charge.Status
            };


            return Ok(uplata);
        }

        private string GetToken(PaymentCardAdd cardInfo)
        {
            StripeConfiguration.ApiKey = "sk_test_ZYySFlXrQCDciqzHKybrdcWU";

            var options = new TokenCreateOptions
            {
                Card = new CreditCardOptions
                {
                    Number = cardInfo.BrojKartice,
                    ExpYear = int.Parse(20 + cardInfo.Godina.ToString()),
                    ExpMonth = cardInfo.Mjesec,
                    Cvc = cardInfo.CVV.ToString()
                }
            };

            var service = new TokenService();
            Token stripeToken = service.Create(options);
            return stripeToken.Id;
        }
    }
}
