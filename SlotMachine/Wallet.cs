using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    internal class Wallet
    {
        private decimal Balance { get; set; }

        public Wallet(decimal balance)
        {
            Balance = balance;
        }

        public void CalculateBalance(decimal amount)
        {
            Balance += amount;
        }
    }
}
