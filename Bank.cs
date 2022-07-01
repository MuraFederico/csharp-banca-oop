using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Bank
    {
        public string Name { get; set; }

        List<User> users;
        List<Loan> loans;

        public Bank(string name)
        {
            this.Name = name;
            users = new List<User>();
            loans = new List<Loan>();
        }

        public static User CreateClient()
        {
            ConsoleCreation.Title("Client registration", "Insert Client Informations: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Fiscal Code: ");
            string fiscalCode = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Salary: ");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine();

            return new User(name, surname, fiscalCode, salary);
        }

        public static Loan CreateLoan(User loaner)
        {
            ConsoleCreation.Title("Loan registration", "Insert Loan Informations: ");
            Console.Write("Amount: ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Number of Rates: ");
            int rates = int.Parse(Console.ReadLine());
            Console.WriteLine();
            

            return new Loan(loaner, amount, rates);
        }

        public void AddLoan(Loan loan)
        {
            this.loans.Add(loan);
            loan.Loaner.Loans++;
        }

        public void PrintLoans()
        {
            ConsoleCreation.Title("Loans List");

            int i = 1;
            foreach (Loan loan in loans)
            {
                Console.WriteLine($"{i}. Amount: {loan.Amount}");
                i++;
            }
            Console.WriteLine();
        }

        public static int ClientSelection()
        {
            Console.Write("Select a Client: ");
            
            int selected = int.Parse(Console.ReadLine());

            Console.WriteLine();
            return selected;
        }

        public void AddClient(User client)
        {
            this.users.Add(client);
        }

        public void PrintClients()
        {
            ConsoleCreation.Title("Clients List");

            int i = 1;
            foreach (User client in users)
            {
                Console.WriteLine($"{i}. {client.Name}");
                i++;
            }
            Console.WriteLine();
        }

        public User SelectClient(int index)
        {
            index--;
            if(index < 0 || index> users.Count())
            {
                Console.WriteLine("No user find");
                return null;
            }

            return users[index];
        }

        public void ModifyClient(int index)
        {
            index--;
            this.users[index] = Bank.CreateClient();
        }

        public List<User> FindClient()
        {
            Console.Write("Type search: ");
            string identifier = Console.ReadLine();

            List<User> results = new List<User>();
            foreach (User client in users)
            {
                if(client.Name == identifier || client.Surname == identifier || client.FiscalCode == identifier)
                {
                    results.Add(client);
                }
            }

            return results;
        }

        public List<Loan> FindLoans()
        {
            Console.Write("Type search: ");
            string identifier = Console.ReadLine();

            List<Loan> results = new List<Loan>();
            foreach (Loan loan in loans)
            {
                if (loan.Loaner.FiscalCode == identifier)
                {
                    results.Add(loan);
                }
            }

            return results;
        }

        public void PrintUserLoans(List<Loan> loans)
        {
            int i = 1;
            foreach (Loan loan in loans)
            {
                Console.WriteLine($"{i}. Amount: {loan.Amount} Rates Left: {loan.RatesLeft}");
                i++;
            }
            Console.WriteLine();
        }

        public int LoansAmount()
        {
            Console.Write("Type Fiscal Code: ");
            string identifier = Console.ReadLine();

            
            foreach (User client in users)
            {
                if (client.FiscalCode == identifier)
                {
                    return client.Loans;
                }
            }

            throw new Exception("No user found");
        }
    }
}
