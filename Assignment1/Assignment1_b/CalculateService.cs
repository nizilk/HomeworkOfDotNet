using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_b
{
    public class CalculateService
    {
        private int a;
        private int b;
        private char op;
        private static readonly char[] allOP = { '+', '-', '*' };
        public float RightQuiz { get; set; } = 0;
        public int TotalQuiz { get; set; } = 0;

        public string RandomFormula()
        {
            Random rd = new Random();
            a = rd.Next(1, 500);
            b = rd.Next(1, 500);
            op = allOP[rd.Next(0, 3)];
            if(op == '*')
            {
                a = rd.Next(1, 50);
                b = rd.Next(1, 50);
            }
            return  string.Concat(a.ToString(), " ", op, " ", b.ToString(), " =");
        }

        public bool IsRight(string ans)
        {
            int.TryParse(ans, out int answer);
            switch(op)
            {
                case '+':
                    return a+b == answer;
                case '-':
                    return a-b == answer;
                case '*':
                    return a*b == answer;
                default: 
                    return false;
            }
        }
    }
}
