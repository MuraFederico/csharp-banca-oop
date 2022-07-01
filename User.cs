namespace csharp_banca_oop
{
    internal class User
    {
        public User(object name, object surname, object fiscalCode, object salary)
        {
            Name = name;
            Surname = surname;
            FiscalCode = fiscalCode;
            Salary = salary;
        }

        public object Name { get; }
        public object Surname { get; }
        public object FiscalCode { get; }
        public object Salary { get; }

        public void Print()
        {
            Console.WriteLine(this.Name);
        }
    }
}