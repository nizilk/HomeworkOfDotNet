using BankSimulation;

namespace Assignment2
{
    public partial class MainForm : Form
    {
        public ATM atm = new ATM();
        public MainForm()
        {
            InitializeComponent();
        }

        public void ini()
        {
            lbName.Text = atm.CurBank.BankName;
            lbAccId.Text = "账号：" + atm.CurId;
        }

        private void btBalance_Click(object sender, EventArgs e)
        {
            double balance = atm.GetBalance();
            MessageBox.Show($"余额：{balance}元");
        }

        private void btWithdraw_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm(atm.WithdrawLimit);
            inputForm.Input += atm.Withdraw;
            inputForm.BigMoneyFetched += Warning;
            inputForm.Res += ShowResW;
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                
            }

        }

        private void btDeposit_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm(atm.DepositLimit);
            inputForm.Input += atm.Deposit;
            inputForm.BigMoneyFetched += Warning;
            inputForm.Res += ShowResD;
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void ShowResW(double num) => MessageBox.Show($"成功取出{num}元, 余额{atm.GetBalance()}元");

        private void ShowResD(double num) => MessageBox.Show($"成功存入{num}元, 余额{atm.GetBalance()}元");

        private void Warning(double num) => MessageBox.Show($"操作金额{num}过大,请注意");

        private void btRecords_Click(object sender, EventArgs e)
        {
            RecordsForm recordsForm = new RecordsForm(atm.AccRecords);
            recordsForm.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}