namespace csharp_banca_oop
{
    internal class User
    {
        public User(string name, string surname, string fiscalCode, int salary)
        {
            Name = name;
            Surname = surname;
            FiscalCode = fiscalCode;
            Salary = salary;
        }

        public string Name { get; }
        public string Surname { get; }
        public string FiscalCode { get; }
        public int Salary { get; }
        public int Loans {get; set;}

        public void Print()
        {
            Console.WriteLine(this.Name);
        }
    }
}