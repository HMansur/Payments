using System;


namespace PortfolioPayments
{
    public class Payment
    {
        int paymentID;
        string currency;
        double amount;
        DateTime paymentDate;
        bool settled;

        public int PaymentID { get => paymentID; set => paymentID = value; }
        public string Currency { get => currency; set => currency = value; }
        public double Amount { get => amount; set => amount = value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }
        public bool Settled { get => settled; set => settled = value; }

    }
}
