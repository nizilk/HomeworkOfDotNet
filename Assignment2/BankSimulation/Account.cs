using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    public class Account
    {
        public string AccId { get; set; } = "";

        private string password = "";
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public double Balance { get; set; } = 500;
        public Dictionary<DateTime, double> DicRecords { get; set; } = new Dictionary<DateTime, double>();
        
        public Account(string id, string pwd) 
        {
            AccId = id;
            password = pwd;
            DicRecords.Add(CreatedTime, Balance);
        }
        public Account() { }

        public bool Login(string id, string pwd)
        {
            if (AccId == id && password == pwd)
                return true;
            else
                return false;
        }

        public virtual bool Withdraw(double amount)
        {
            if (amount > Balance || amount <= 0)
            {
                return false;
            }
            Balance -= amount;
            DicRecords.Add(DateTime.Now, -amount);
            return true;
        }

        public bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                DicRecords.Add(DateTime.Now, +amount);
                return true;
            }
        }
    }
}
