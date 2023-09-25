using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    public class ATM
    {
        public static Dictionary<string, Bank> BankServer = new();

        private bool logged = false;

        private string curId = "";
        public string CurId => curId;
        public double WithdrawLimit { get; set; } = 50000;
        public double DepositLimit { get; set; } = 50000;
        public Bank CurBank { get; set; } = new();

        public bool Authe(string id, string pwd)
        {
            curId = id;
            CurBank = BankServer[curId[0..6]];
            if (CurBank == null)
            {
                return false;
            }
            logged = CurBank.LoginAccount(id, pwd);
            return logged;
        }

        public double GetBalance() => CurBank != null ? CurBank.GetBalance(curId) : 0;

        public bool Withdraw(double amount, string pwd)
        {
            if(amount > WithdrawLimit)
            {
                throw new ArgumentException("超过最大取款额度!");
            }
            logged = CurBank.LoginAccount(curId, pwd);
            if (logged)
            {
                logged = false;
                return CurBank.Withdraw(curId, amount);
            }
            return false;
        }

        public bool Deposit(double amount, string pwd)
        {
            Random rd = new Random();

            if (amount > DepositLimit)
            {
                throw new ArgumentException("超过最大存款额度!");
            }
            logged = CurBank.LoginAccount(curId, pwd);
            if (logged)
            {
                logged = false;
                if (rd.Next(0,10) < 3)
                {
                    throw new BadCashException("无法识别的钞票,请重新放入");
                }
                return CurBank.Deposit(curId, amount);
            }
            return false;
        }

        public Dictionary<DateTime, double> AccRecords => CurBank != null ? CurBank.GetRecords(curId) : new();
    }

    public class BadCashException : ApplicationException
    {
        public BadCashException(string message) : base(message)
        {
        }
    }
}
