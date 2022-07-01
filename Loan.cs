namespace csharp_banca_oop
{
    internal class Loan
    {
        int Id { get; set; }
        User Loaner { get; set; }
        int Amount { get; set; }
        int Rates { get; set; }
        DateOnly StartDate { get; set; }
        DateOnly EndDate { get; set; }

    }
}