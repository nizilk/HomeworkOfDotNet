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
            lbAccId.Text = "�˺ţ�" + atm.CurId;
        }

        private void btBalance_Click(object sender, EventArgs e)
        {
            double balance = atm.GetBalance();
            MessageBox.Show($"��{balance}Ԫ");
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

        private void ShowResW(double num) => MessageBox.Show($"�ɹ�ȡ��{num}Ԫ, ���{atm.GetBalance()}Ԫ");

        private void ShowResD(double num) => MessageBox.Show($"�ɹ�����{num}Ԫ, ���{atm.GetBalance()}Ԫ");

        private void Warning(double num) => MessageBox.Show($"�������{num}����,��ע��");

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