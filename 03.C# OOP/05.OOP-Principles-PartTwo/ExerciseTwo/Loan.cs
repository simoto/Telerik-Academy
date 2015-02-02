using System;

//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months
//if are held by a company.

namespace ExerciseTwo
{
    class Loan : Account
    {
        public Loan(Customer type, decimal balance, decimal interestRate)
        {
            this.customer = type;
            this.balance = balance;
            this.rate = interestRate;
        }

        public override void DepositMoney(decimal money)
        {
            this.balance += money;
        }

        public override decimal CalculateInterest(decimal numberOfMonth)
        {
            if (this.customer == Customer.Individual)
            {
                if (numberOfMonth <= 3)
                {
                    return 0;
                }
                else
                {
                    return (this.balance * this.rate);
                }
            }
            else
            {
                if (numberOfMonth <= 2)
                {
                    return 0;
                }
                else
                {
                    return (this.balance * this.rate);
                }
            }
        }
    }
}
