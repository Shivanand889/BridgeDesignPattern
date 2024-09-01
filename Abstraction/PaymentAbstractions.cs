using PaymentImplementations;

namespace PaymentAbstractions
{
    public abstract class Goods
    {
        protected IPaymentMethod PaymentMethod;

        public Goods( IPaymentMethod PaymentMethod )
        {
            this.PaymentMethod = PaymentMethod;
        }

        public abstract string Purchase( decimal Amount );
    }

    public class PhysicalGoods : Goods
    {
        public PhysicalGoods( IPaymentMethod PaymentMethod ) : base( PaymentMethod )
        {
        }

        public override string Purchase( decimal Amount )
        {
            return $"Purchasing physical goods. {PaymentMethod.ProcessPayment( Amount )}";
        }
    }

    public class DigitalGoods : Goods
    {
        public DigitalGoods( IPaymentMethod PaymentMethod ) : base( PaymentMethod )
        {
        }

        public override string Purchase( decimal amount )
        {
            return $"Purchasing digital goods. {PaymentMethod.ProcessPayment( amount )}";
        }
    }
}
