using System;
namespace Recursion {
    public class Program {
        public static int SumaIt(int n)
        {
            int num = 0;
            for (int i = 1; i <= n; i++)
            {
                num += i;
            }
            return num;
        }

        public static int SumaRec(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + SumaRec(n - 1);
            }
        }

        public static void Main() {
            Console.WriteLine("Resultat suma iterativa:", SumaIt(4));
            Console.WriteLine("Resultat suma recursiva:", SumaRec(4));
        }
    }
}


