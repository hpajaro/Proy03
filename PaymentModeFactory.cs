using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public enum Mode
    {
        CreditCard,
        DebitCar,
        PayPal,
        Pse
    }
    public class PaymentModeFactory
    {
        public static IPaymentMode Create(Mode mode)
        {

            if (mode == Mode.CreditCard)
                return new CreditCardPaymment();
            else if (mode == Mode.DebitCar)
                return new DebitCardPaymment();
            else if (mode == Mode.PayPal)
                return new PayPalPayment();
            else
                return new Pse();

        }
    }
}