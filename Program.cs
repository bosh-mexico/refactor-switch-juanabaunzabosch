using System;
using System.Collections.Generic;

namespace PaymentProcessing
{
    interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }

    class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount:F2}");
            // PayPal-specific logic here
        }
    }

    class GooglePayProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Google Pay payment of ${amount:F2}");
            // GooglePay-specific logic here
        }
    }

    class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Credit Card payment of ${amount:F2}");
            // Credit card-specific logic here
        }
    }

    class UnknownPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Invalid payment method selected!");
        }
    }

    class Program
    {
        static void Checkout(IPaymentProcessor processor, double amount)
        {
            processor.ProcessPayment(amount);
        }

        static void Main(string[] args)
        {
            double amount = 150.75;

            Checkout(new PayPalProcessor(), amount);
            Checkout(new GooglePayProcessor(), amount);
            Checkout(new CreditCardProcessor(), amount);
            Checkout(new UnknownPaymentProcessor(), amount);
        }
    }
}
