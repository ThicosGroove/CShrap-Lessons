using System;
using System.Collections.Generic;
using System.Text;
using ExceptionsErrors1.Entities.Exceptions;

namespace ExceptionsErrors1.Entities
{
    class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }
        public float WidhtdrawLimit { get; set; }

        public Account() { }

        public Account(int id, string name, float balance, float widhtdrawLimit)
        {
            Id = id;
            Name = name;
            Balance = balance;
            WidhtdrawLimit = widhtdrawLimit;
        }

        public void Deposit(float amount)
        {
            Balance += amount;
        }

        public void Withdraw(float amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            if (amount > WidhtdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }
    }
}
