using System;

//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.

namespace ExerciseTwo
{
    class Mortgage : Account
    {
        public Mortgage(Customer type, decimal balance, decimal interestRate)
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
            if (this.customer == Customer.Company)
            {
                if (numberOfMonth <= 12)
                {
                    return 0.5m;
                }
                else
                {
                    return this.balance * numberOfMonth;
                }
            }
            else
            {
                if (numberOfMonth <= 6)
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
}
