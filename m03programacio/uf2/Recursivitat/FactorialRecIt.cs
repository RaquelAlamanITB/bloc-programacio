using System;
namespace Recursion {
    public class Program {

        public static int FactorialIt(int n)
        {
            int count = 1, val = 1;
            while (val <= n) 
            {
                count *= val;
                val++;
            }
            return count;
        }
        public static int FactorialRec(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else 
            {
                return n * FactorialRec(n - 1);
            }
        }

        public static void Main() {
            Console.WriteLine("Resultat Factorial iteratiu: {0}", FactorialIt(4));
            Console.WriteLine("Resultat Factorial recursiu: {0}", FactorialRec(4));
        }
    }
}


