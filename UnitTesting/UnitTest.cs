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
            IPaymentMethod paymentMethod = new CreditCardPayment();
            Goods goods = new PhysicalGoods( paymentMethod );
            decimal amount = 100m;

            // Asserting that the correct payment processing message is returned.
            string result = goods.Purchase( amount );
            Assert.AreEqual( "Purchasing physical goods. Processed credit card payment of $100.00" , result );
        }

        [TestMethod]
        public void TestPhysicalGoodsWithPayPalPayment()
        {
            // Testing the purchase of physical goods using a PayPal payment method.
            IPaymentMethod paymentMethod = new PayPalPayment();
            Goods goods = new PhysicalGoods( paymentMethod );
            decimal amount = 200m;

            // Asserting that the correct payment processing message is returned.
            string result = goods.Purchase( amount );
            Assert.AreEqual( "Purchasing physical goods. Processed PayPal payment of $200.00" , result );
        }

        [TestMethod]
        public void TestDigitalGoodsWithCreditCardPayment()
        {
            // Testing the purchase of digital goods using a credit card payment method.
            IPaymentMethod paymentMethod = new CreditCardPayment();
            Goods goods = new DigitalGoods( paymentMethod );
            decimal amount = 50m;

            // Asserting that the correct payment processing message is returned.
            string result = goods.Purchase( amount );
            Assert.AreEqual( "Purchasing digital goods. Processed credit card payment of $50.00" , result );
        }

        [TestMethod]
        public void TestDigitalGoodsWithPayPalPayment()
        {
            // Testing the purchase of digital goods using a PayPal payment method.
            IPaymentMethod paymentMethod = new PayPalPayment();
            Goods goods = new DigitalGoods( paymentMethod );
            decimal amount = 75m;

            // Asserting that the correct payment processing message is returned.
            string result = goods.Purchase( amount );
            Assert.AreEqual( "Purchasing digital goods. Processed PayPal payment of $75.00" , result );
        }
    }
}
