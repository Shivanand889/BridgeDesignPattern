using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentAbstractions;
using PaymentImplementations;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPhysicalGoodsWithCreditCardPayment()
        {
            // Arrange
            IPaymentMethod paymentMethod = new CreditCardPayment();
            Goods goods = new PhysicalGoods( paymentMethod );
            decimal amount = 100m;

            // Act
            string result = goods.Purchase( amount );

            // Assert
            Assert.AreEqual( "Purchasing physical goods. Processed credit card payment of $100.00" , result );
        }

        [TestMethod]
        public void TestPhysicalGoodsWithPayPalPayment()
        {
            // Arrange
            IPaymentMethod paymentMethod = new PayPalPayment();
            Goods goods = new PhysicalGoods( paymentMethod );
            decimal amount = 200m;

            // Act
            string result = goods.Purchase( amount );

            // Assert
            Assert.AreEqual( "Purchasing physical goods. Processed PayPal payment of $200.00" , result );
        }

        [TestMethod]
        public void TestDigitalGoodsWithCreditCardPayment()
        {
            // Arrange
            IPaymentMethod paymentMethod = new CreditCardPayment();
            Goods goods = new DigitalGoods( paymentMethod );
            decimal amount = 50m;

            // Act
            string result = goods.Purchase( amount );

            // Assert
            Assert.AreEqual( "Purchasing digital goods. Processed credit card payment of $50.00" , result );
        }

        [TestMethod]
        public void TestDigitalGoodsWithPayPalPayment()
        {
            // Arrange
            IPaymentMethod paymentMethod = new PayPalPayment();
            Goods goods = new DigitalGoods( paymentMethod );
            decimal amount = 75m;

            // Act
            string result = goods.Purchase( amount );

            // Assert
            Assert.AreEqual( "Purchasing digital goods. Processed PayPal payment of $75.00" , result );
        }
    }
}
