namespace csharp_banca_oop
{
    internal class Loan
    {
        public Loan(User loaner, int amount, int rates)
        {
            Loaner = loaner;
            Amount = amount;
            Rates = rates;
            StartDate = new DateOnly();
            EndDate = new DateOnly().AddMonths(24);
            RatesLeft = rates;
        }

        int Id { get; set; }
        public User Loaner { get; set; }
        public int Amount { get; set; }
        int Rates { get; set; }
        public int RatesLeft { get; }
        DateOnly StartDate { get; set; }
        DateOnly EndDate { get; set; }

    }

    internal interface Iinterest
    {
        float InterestAmount();
    }
    internal class InterestLoan : Loan, Iinterest
    {
        public InterestLoan(User loaner, int amount, int rates, float interest) : base(loaner, amount, rates)
        {
            this.Interest = interest;
        }

        float Interest { get; set; }

        public float InterestAmount()
        {
            return this.Interest * this.Amount / 100;
        }
    }
}

