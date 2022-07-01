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
            decimal salary = Decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            return new User(name, surname, fiscalCode, salary);
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
            ConsoleCreation.Title("Clients Lists");

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

        public List<User> FindClient(string identifier)
        {
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
    }
}
