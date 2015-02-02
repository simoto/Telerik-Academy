using System;

//Deposit accounts have no interest if their balance is positive and less than 1000.

namespace ExerciseTwo
{
    class Deposit : Account
    {
        public Deposit(Customer type, decimal balance, decimal interestRate)
        {
            this.customer = type;
            this.balance = balance;
            this.rate = interestRate;
        }
        public override void DepositMoney(decimal money)
        {
            this.balance += money;
        }

        public void DrawMoney(decimal money)
        {
            this.balance -= money;
        }

        public override decimal CalculateInterest(decimal numberOfMonth)
        {
            if (this.balance >= 0 && this.balance <= 1000)
            {
                return 0;
            }
            else
            {
                return this.balance * numberOfMonth;
            }
        }
    }
}
