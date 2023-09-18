namespace Assignment1_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.Write("请输入数字：");
            int.TryParse(Console.ReadLine(), out n);
            Console.Write("\n素数因子为：");
            if (isPrime(n))
            {
                Console.Write("none! ");
            }
            for(int i = 2; i <= n/2; i++)
            {
                if(n%i == 0 && isPrime(i))
                {
                    Console.Write($"{i}  ");
                }
            }
            Console.WriteLine();
        }

        static bool isPrime(int n)
        {
            for(int i = 2; i <= n/2; i++)
            {
                if (n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}