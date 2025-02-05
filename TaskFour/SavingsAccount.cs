namespace TaskFour
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(
            string name = "Unnamed Account",
            double balance = 0.0,
            double interestRate = 0.0) : base(name, balance)
        {
            InterestRate = interestRate;
        }

        public override string ToString()
        {
            return $"{Name}'s SavingsAccount, Balance: {Balance}";
        }
    }
}
