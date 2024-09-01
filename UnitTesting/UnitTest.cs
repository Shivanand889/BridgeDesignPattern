using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentAbstractions;
using PaymentImplementations;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestPhysicalGoodsWithCreditCardPayment()
        {
            // Testing the purchase of physical goods using a credit card payment method.
            IPaymentMethod PaymentMethod = new CreditCardPayment();
            Goods Good = new PhysicalGoods( PaymentMethod );
            decimal Amount = 100m;

            // Asserting that the correct payment processing message is returned.
            string Result = Good.Purchase( Amount );
            Assert.AreEqual( "Purchasing physical goods. Processed credit card payment of $100.00" , Result );
        }

        [TestMethod]
        public void TestPhysicalGoodsWithPayPalPayment()
        {
            // Testing the purchase of physical goods using a PayPal payment method.
            IPaymentMethod PaymentMethod = new PayPalPayment();
            Goods Good = new PhysicalGoods( PaymentMethod );
            decimal Amount = 200m;

            // Asserting that the correct payment processing message is returned.
            string Result = Good.Purchase( Amount );
            Assert.AreEqual( "Purchasing physical goods. Processed PayPal payment of $200.00" , Result );
        }

        [TestMethod]
        public void TestDigitalGoodsWithCreditCardPayment()
        {
            // Testing the purchase of digital goods using a credit card payment method.
            IPaymentMethod PaymentMethod = new CreditCardPayment();
            Goods Good = new DigitalGoods( PaymentMethod );
            decimal Amount = 50m;

            // Asserting that the correct payment processing message is returned.
            string Result = Good.Purchase( Amount );
            Assert.AreEqual( "Purchasing digital goods. Processed credit card payment of $50.00" , Result );
        }

        [TestMethod]
        public void TestDigitalGoodsWithPayPalPayment()
        {
            // Testing the purchase of digital goods using a PayPal payment method.
            IPaymentMethod PaymentMethod = new PayPalPayment();
            Goods Good = new DigitalGoods( PaymentMethod );
            decimal Amount = 75m;

            // Asserting that the correct payment processing message is returned.
            string Result = Good.Purchase( Amount );
            Assert.AreEqual( "Purchasing digital goods. Processed PayPal payment of $75.00" , Result );
        }
    }
}
