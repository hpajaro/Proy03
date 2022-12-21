namespace Interfaces
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            CreditCardPaymment pagoTarCredito = new CreditCardPaymment();
            DebitCardPaymment pagoTarDebito = new DebitCardPaymment();

            PaymentManager pagoAdmin = new PaymentManager(pagoTarCredito, pagoTarDebito);

            pagoAdmin.ManagePayment();

        }
    }

}