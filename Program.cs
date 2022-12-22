namespace Interfaces
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Crea las formas de pago 

            PaymentModeFactory.Create(Mode.CreditCard).MakePayment();
            PaymentModeFactory.Create(Mode.DebitCar).MakePayment();
            PaymentModeFactory.Create(Mode.PayPal).MakePayment();
            PaymentModeFactory.Create(Mode.Pse).MakePayment();


        }
    }

}