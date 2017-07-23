using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankApp
    {
        public int Saldo { get; set; }

        public void Debit(int amount)
        {
            if(Saldo >= amount && amount >= 0)
            {
                if (amount < 1000)
                    Saldo -= amount;
                else
                    Saldo -= 1000;
            }
        }

        public void Credit(int amount)
        {
            if(amount >= 0)
            Saldo += amount;
        }

        public int Balance()
        {
            return Saldo;
        }
    }
}
