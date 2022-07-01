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

        }

        int Id { get; set; }
        User Loaner { get; set; }
        public int Amount { get; set; }
        int Rates { get; set; }
        DateOnly StartDate { get; set; }
        DateOnly EndDate { get; set; }

    }
}