using System.Globalization;

namespace PaymentImplementations
{
    public interface IPaymentMethod
    {
        string ProcessPayment( decimal Amount );
    }

    public class CreditCardPayment : IPaymentMethod
    {
        public string ProcessPayment( decimal Amount )
        {
            // Ensuring that the currency is always formatted in U.S. dollars
            return $"Processed credit card payment of {Amount.ToString( "C" , CultureInfo.CreateSpecificCulture( "en-US" ) )}";
        }
    }

    public class PayPalPayment : IPaymentMethod
    {
        public string ProcessPayment( decimal Amount )
        {
            // Ensuring that the currency is always formatted in U.S. dollars
            return $"Processed PayPal payment of {Amount.ToString( "C" , CultureInfo.CreateSpecificCulture( "en-US" ) )}";
        }
    }
}
