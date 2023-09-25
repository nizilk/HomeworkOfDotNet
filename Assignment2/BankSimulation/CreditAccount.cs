using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    public class CreditAccount : Account
    {
        public static double CreditLimit { get; set; }
        public CreditAccount() { }
        public CreditAccount(string id, string pwd, double max):base(id, pwd)
        {
            Balance = 0;
            CreditLimit = max;
        }

        public override bool Withdraw(double amount)
        {
            if (amount > CreditLimit || amount <= 0)
            {
                return false;
            }
            Balance -= amount;
            DicRecords.Add(DateTime.Now, -amount);
            return true;
        }
    }
}
