using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    public struct CardInfo
    {
        public int Bin { get; set; } = 0;
        public string Ran { get; set; } = "";
        public int CheckCode { get; set; } = 0;
        public int Length { get; set; } = 0;

        public CardInfo() { }
        
        public CardInfo(int bin, int len) 
        {
            Bin = bin;
            Length = len;
        }

        public CardInfo NewCard()
        {
            CardInfo card = new CardInfo(Bin, Length);
            int l = Length - Bin.ToString().Length - 1;
            card.Ran = BitConverter.ToInt64(Guid.NewGuid().ToByteArray()).ToString()[0..l]; 
            card.CheckCode = GenLuhn(card.Bin.ToString() + card.Ran);
            return card;
        }

        public static int GenLuhn(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(i%2 == 0)
                {
                    int temp = (str[str.Length - 1 - i] - '0') *2;
                    sum += temp / 10;
                    sum += temp % 10;
                }
                else
                {
                    sum += str[str.Length - 1 - i] - '0';
                }
            }
            return 10 - (sum % 10);
        }

        public override string ToString() => Bin.ToString() + Ran + CheckCode.ToString();

    }


    public class Bank
    {
        public string BankName { get; set; } = "";
        public List<Account> AccountList { get; set; } = new List<Account>()
        {
            new Account("6230001234512345", "test1234")
        };
        public double InterestRate { get; set; } = 0.003;
        private Dictionary<string, CardInfo> AllCards { get; set; } = new Dictionary<string, CardInfo>
        {
            { "defo", new CardInfo(623000, 16) }
        };

        public Bank() { }

        public Bank(string name) 
        {
            BankName = name;
        }

        public string CreateAccount(string pwd, string type = "defo")
        {
            if (!AllCards.TryGetValue(type, out CardInfo card))
            {
                card = AllCards["defo"];
            }
            string id = card.NewCard().ToString();
            Account account = new(id, pwd);
            AccountList.Add(account);
            return id;
        }

        public Account FindAccount(string id) => AccountList.Find(acc => acc.AccId == id);

        public bool LoginAccount(string id, string pwd)
        {
            Account account = FindAccount(id);
            if (account != null && account.Login(id, pwd))
            {
                return true;
            }
                return false;
        }

        public bool DeleteAccount(string id)
        {
            Account account = FindAccount(id);
            if (account != null && account.Balance == 0)
            {
                AccountList.Remove(account);
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetBalance(string id)
        {
            Account account = FindAccount(id);
            return account != null ? account.Balance : 0;
        }

        public Dictionary<DateTime, double> GetRecords(string id)
        {
            Account account = FindAccount(id);
            return account != null ? account.DicRecords : new Dictionary<DateTime, double>();
        }

        public bool Withdraw(string id, double amount)
        {
            Account account = FindAccount(id);
            return account != null ? account.Withdraw(amount) : false;
        }

        public bool Deposit(string id, double amount)
        {
            Account account = FindAccount(id);
            return account != null ? account.Deposit(amount) : false;
        }
    }
}
