using System;
namespace HanoiTower
{
    class Program
    {
        private const string MsgMove = "Mou el disc de {0} a {1}.";
        public static void SolveTowers(int n, char fromRod, char toRod, char auxRod)
        {
            if (n > 0)
            {
                SolveTowers(n - 1, fromRod, auxRod, toRod);
                Console.WriteLine(MsgMove, fromRod, toRod);
                SolveTowers(n - 1, auxRod, toRod, fromRod);

            }
        }

        public static void Main()
        {
            int N = 3;
            SolveTowers(N, 'A', 'C', 'B');
        }
    }
}
