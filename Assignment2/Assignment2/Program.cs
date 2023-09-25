using BankSimulation;

namespace Assignment2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Bank bk = new Bank("工商银行");
            bk.CreateAccount("test123");
            ATM.BankServer.Add("623000", bk);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoginForm loginForm = new LoginForm();
            MainForm mainForm = new MainForm();
            loginForm.login += mainForm.atm.Authe;
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                mainForm.ini();
                Application.Run(mainForm);
            }
        }
    }
}