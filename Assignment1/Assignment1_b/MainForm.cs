using System;
using static Assignment1_b.StartForm;

namespace Assignment1_b
{
    public partial class MainForm : Form
    {
        private CalculateService cs = new CalculateService();

        public TableLayoutPanel TableMain => tableMain;

        public event LoadDelegate loadFin;

        public FinalForm frm = new FinalForm();

        private TimeSpan span = new TimeSpan();
        private int time = 15;
        private int num = 10;

        public MainForm()
        {
            InitializeComponent();
            initial();
        }

        public MainForm(int t, int total)
        {
            cs.TotalQuiz = num = total;
            time = t;
            InitializeComponent();
            initial();
        }

        private void tbAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar == '-' && tbAnswer.Text == "") || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        async private void btOK_Click(object sender, EventArgs e)
        {
            timerPerQuiz.Stop();

            if (cs.IsRight(tbAnswer.Text))
            {
                lbIfRight.Text = "√";
                lbIfRight.ForeColor = Color.Green;
                cs.RightQuiz++;
            }
            else
            {
                lbIfRight.Text = "×";
                lbIfRight.ForeColor = Color.Red;
            }
            lbIfRight.Visible = true;
            lbScore.Text = (cs.RightQuiz * 100 / cs.TotalQuiz).ToString("0.#");

            await Task.Delay(777);

            if (--num <= 0)
            {
                timerPerQuiz.Enabled = false;
                frm = new FinalForm(lbScore.Text);
                frm.loadStart += loadFin;
                this.loadFin(frm.TableFin);
                this.Dispose();
                this.Close();
                return;
            }

            lbIfRight.Visible = false;
            initial();
        }


        private void timerPerQuiz_Tick(object sender, EventArgs e)
        {
            span = span.Subtract(new TimeSpan(0, 0, 1));
            lbCountdown.Text = span.ToString(@"mm\:ss");
            if (span.TotalSeconds <= 0.0)//当倒计时完毕时
            {
                btOK_Click(sender, e);
            }
        }

        private void initial()
        {
            timerPerQuiz.Enabled = true;
            lbFormula.Text = cs.RandomFormula();
            span = new TimeSpan(0, 0, time);
            lbCountdown.Text = span.ToString(@"mm\:ss");
            tbAnswer.Text = "";
            timerPerQuiz.Start();
        }
    }
}