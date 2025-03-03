using System;
    public class Account
    {
        public double Balance { get; set; }

        public Account(double balance)
        {
            Balance = balance;
        }

        public virtual void CalculateInterest()
        {
            Console.WriteLine("Base account interest calculation.");
        }
    }

    public class SavingsAccount : Account
    {
        private double interestRate;
        public SavingsAccount(double balance, double rate) : base(balance)
        {
            interestRate = rate;
        }
        public sealed override void CalculateInterest()
        {
            double interest = Balance * (interestRate / 100);
            Console.WriteLine($"Savings Account Interest: {interest:C}");
        }
    }

