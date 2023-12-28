using System;
namespace Recursion {
    public class Program {

        public static int PowRec(int m, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return m * PowRec(m, n - 1);
            }
        }

        public static void Main() {
            Console.WriteLine("Resultat potència recursiva: {0}", PowRec(2,1));
        }
    }
}


