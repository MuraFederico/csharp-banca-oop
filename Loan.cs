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
}