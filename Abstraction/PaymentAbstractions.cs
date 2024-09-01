// Referencing the PaymentImplementations module which contains the  implementations of payment methods.
using PaymentImplementations;

namespace PaymentAbstractions
{
    // Abstract class representing Goods, acts as the abstraction in the Bridge Pattern.
    public abstract class Goods
    {
        // The PaymentMethod reference represents the implementation side of the Bridge.
        protected IPaymentMethod PaymentMethod;

        // Constructor accepts an IPaymentMethod implementation, allowing flexibility in payment processing.
        public Goods( IPaymentMethod PaymentMethod )
        {
            this.PaymentMethod = PaymentMethod;
        }

        // Abstract method for purchasing goods, to be implemented by derived classes.
        public abstract string Purchase( decimal Amount );
    }

    // Concrete class for purchasing physical goods, a specific type of Goods.
    public class PhysicalGoods : Goods
    {
        // Constructor passes the payment method to the base Goods class.
        public PhysicalGoods( IPaymentMethod PaymentMethod ) : base( PaymentMethod )
        {
        }

        // Implements the Purchase method for physical goods, using the chosen payment method.
        public override string Purchase( decimal Amount )
        {
            return $"Purchasing physical goods. {PaymentMethod.ProcessPayment( Amount )}";
        }
    }

    // Concrete class for purchasing digital goods, another specific type of Goods.
    public class DigitalGoods : Goods
    {
        // Constructor passes the payment method to the base Goods class.
        public DigitalGoods( IPaymentMethod PaymentMethod ) : base( PaymentMethod )
        {
        }

        // Implements the Purchase method for digital goods, using the chosen payment method.
        public override string Purchase( decimal amount )
        {
            return $"Purchasing digital goods. {PaymentMethod.ProcessPayment( amount )}";
        }
    }
}
