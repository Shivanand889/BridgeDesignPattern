using System.Globalization;

namespace PaymentImplementations
{
    // Interface for payment methods, defines the contract for processing payments.
    public interface IPaymentMethod
    {
        // Method for processing payment with the specified amount.
        string ProcessPayment( decimal Amount );
    }

    // Implementation of IPaymentMethod for credit card payments.
    public class CreditCardPayment : IPaymentMethod
    {
        public string ProcessPayment( decimal Amount )
        {
            // Formats the payment amount as U.S. dollars and processes the credit card payment.
            return $"Processed credit card payment of {Amount.ToString( "C" , CultureInfo.CreateSpecificCulture( "en-US" ) )}";
        }
    }

    // Implementation of IPaymentMethod for PayPal payments.
    public class PayPalPayment : IPaymentMethod
    {
        public string ProcessPayment( decimal Amount )
        {
            // Formats the payment amount as U.S. dollars and processes the PayPal payment.
            return $"Processed PayPal payment of {Amount.ToString( "C" , CultureInfo.CreateSpecificCulture( "en-US" ) )}";
        }
    }
}
