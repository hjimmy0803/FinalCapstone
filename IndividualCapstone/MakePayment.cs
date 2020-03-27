using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stripe;

namespace IndividualCapstone
{
    public class MakePayment
    {
        public static async Task<dynamic> PayAsync(string cardnumber, int month, int year, string cvc, int value)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_QVMHSve6X4AY982OFfwNjO3Z000Vjl0ADt";

                var optionstoken = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = cardnumber,
                        ExpMonth = month,
                        ExpYear = year,
                        Cvc = cvc

                    }
                };

                var servicetoken = new TokenService();
                Token stripetoken = await servicetoken.CreateAsync(optionstoken);

                var options = new ChargeCreateOptions
                {
                    Amount = value,
                    Currency = "usd",
                    Description = "Payment Id",
                    Source = stripetoken.Id

                };

                var service = new ChargeService();
                Charge charge = await service.CreateAsync(options);

                if (charge.Paid)
                {
                    return "success";
                }
                else
                {
                    return "failed";
                }

            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}
