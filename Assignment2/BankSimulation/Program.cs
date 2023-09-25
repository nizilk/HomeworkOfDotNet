namespace BankSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bk = new Bank("工商银行");
            bk.CreateAccount("test123");
            ATM.BankServer.Add("623000", bk);

        }
    }
}