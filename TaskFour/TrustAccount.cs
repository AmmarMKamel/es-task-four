namespace TaskFour
{
    internal class TrustAccount: Account
    {
        public double InterestRate { get; set; }
        private int WithdrawalsLimit { get; set; } = 3;

        public TrustAccount(
            string name = "Unnamed Account",
            double balance = 0.0,
            double interestRate = 0.0) : base(name, balance)
        {
            InterestRate = interestRate;
        }

        public override bool Withdraw(double amount)
        {
            if (WithdrawalsLimit == 0)
                return false;

            double amountAfterInterestRate = amount + InterestRate;

            if (amountAfterInterestRate > 0.2 * Balance)
                return false;

            WithdrawalsLimit--;

            return base.Withdraw(amountAfterInterestRate);
        }

        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
                amount += 50;

            return base.Deposit(amount);
        }

        public override string ToString()
        {
            return $"{Name}'s TrustAccount, Balance: {Balance}";
        }
    }
}
