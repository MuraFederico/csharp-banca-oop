using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal abstract class BankAccount
    {
        public BankAccount(User owner)
        {
            Balance = 0;
            Owner = owner;
        }

        internal int Balance { get; set; }
        User Owner { get; set; }

        public abstract void Withdraw(int amount);

        public abstract void Deposit(int amount);
       
    }

    internal class StandardAccount : BankAccount
    {
        public StandardAccount(User owner) : base(owner)
        {
        }

        public override void Deposit(int amount)
        {
            this.Balance += amount;
        }

        public override void Withdraw(int amount)
        {
            if(amount > this.Balance)
            {

                throw new Exception("amount requested higher than balance");
            }

            this.Balance -= amount;
        }
    }

    internal class SavingsAccount : BankAccount
    {
        public SavingsAccount(User owner) : base(owner)
        {
        }

        public override void Deposit(int amount)
        {
            if(amount > 5000)
            {
                throw new Exception("can't deposit more than 5000");
            }
            Balance += amount;
        }

        public override void Withdraw(int amount)
        {
            if(Balance < 1000)
            {
                throw new Exception("can't withdraw if balance lower than 1000");
            }
            if(amount > Balance)
            {
                throw new Exception("amount requested higher than balance");
            }
            Balance -= amount;
        }
    }
}
