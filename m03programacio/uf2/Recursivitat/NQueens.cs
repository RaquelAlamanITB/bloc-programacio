using System;
namespace Backtracking
{
    public class Program
    {
        private static int N;
        private const string MsgStateSize = "Indica la mida del tauler (N): ";
        private const string MsgNotFound = "No s'ha trobat cap solució";
        public static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        public static bool ToPlaceOrNotToPlace(int[,] board, int row, int col)
        {
            int i, j;
            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 1) return false;
            }
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1) return false;
            }
            for (i = row, j = col; j >= 0 && i < N; i++, j--)
            {
                if (board[i, j] == 1) return false;
            }
            return true;
        }

        public static bool BoardSolver(int[,] board, int col)
        {
            if (col >= N) return true;
            for (int i = 0; i < N; i++)
            {
                if (ToPlaceOrNotToPlace(board, i, col))
                {
                    board[i, col] = 1;
                    if (BoardSolver(board, col + 1))  return true;
                    board[i, col] = 0;
                }
            }
            return false;
        }
        public static void Main()
        {
            Console.WriteLine(MsgStateSize);
            N = Convert.ToInt32(Console.ReadLine());
            int[,] board = new int[N, N];
            if (!BoardSolver(board, 0))
            {
                Console.WriteLine(MsgNotFound);
            }
            PrintBoard(board);
            Console.ReadLine();
        }
    }
}