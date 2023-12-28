using System;
namespace FibonacciSeries
{
    public class Program {
        public const string Msg = "Introdueix la mida de la seqüència de Fibonacci: ";
        public static int FibonacciSeries(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
        public static void Main()
        {
            Console.WriteLine(Msg);
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciSeries(i));
            }
        }
    }
}
