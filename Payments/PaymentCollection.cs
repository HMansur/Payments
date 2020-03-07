
using System.Collections.Generic;


namespace PortfolioPayments
{
    public class PaymentCollection
    {
        List<Payment> payments;

        public List<Payment> Payments { get => payments; set => payments = value; }
    }
}
