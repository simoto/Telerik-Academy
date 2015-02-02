namespace ExerciseTwo
{
    abstract class Account
    {
        protected Customer customer;
        protected decimal balance;
        protected decimal rate;

        public abstract void DepositMoney(decimal money);

        public virtual decimal CalculateInterest(decimal numberOfMonth)
        {
            return numberOfMonth * this.rate;
        }
    }
}