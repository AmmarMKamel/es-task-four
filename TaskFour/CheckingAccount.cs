namespace TaskFour
{
    internal class CheckingAccount : Account
    {
        private readonly double _withdrawalFee = 1.5;

        public CheckingAccount(
            string name = "Unnamed Account",
            double balance = 0.0) : base(name, balance)
        { }

        public override bool Withdraw(double amount)
        {
            amount += _withdrawalFee;
            return base.Withdraw(amount);
        }

        public override string ToString()
        {
            return $"{Name}'s CheckingAccount, Balance: {Balance}";
        }
    }
}
