using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public class PaymentManager
    {
        private readonly CreditCardPaymment creditCard;
        private readonly DebitCardPaymment debitCard;

        public PaymentManager(CreditCardPaymment creditCard, DebitCardPaymment debitCard)
        {
            this.creditCard = creditCard;
            this.debitCard = debitCard;
        }

        public void ManagePayment()
        {
            creditCard.MakePayment();
            debitCard.MakePayment();
        }

    }
}