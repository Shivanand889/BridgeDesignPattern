#Overview

This project demonstrates the Bridge Design Pattern by separating the abstraction of Goods from the implementation of Payment Methods. The design allows you to easily extend both Goods and Payment Methods independently without altering the existing code.

#Key Concepts

1. Abstraction (Goods): Represents different types of goods that can be purchased.
2. Implementation (IPaymentMethod): Represents different ways of processing payments for goods.

#Project Structure

The project is divided into three main parts, each within its own folder:

1. Abstraction

Contains the PaymentAbstractions.cs file.
This file defines the Goods abstract class and its concrete subclasses (PhysicalGoods, DigitalGoods).
These classes represent different types of goods that can be purchased.

2. Implementation

Contains the PaymentImplementations.cs file.
This file defines the IPaymentMethod interface and its implementations (CreditCardPayment, PayPalPayment).
These classes represent different payment methods that can be used for purchasing goods.

3. UnitTesting

Contains the UnitTest1.cs file.
This file includes MSTest unit tests to verify that the abstraction and implementation interact correctly.