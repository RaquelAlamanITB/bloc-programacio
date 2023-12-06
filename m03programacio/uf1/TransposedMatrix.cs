using System;

namespace Projects
{
    public class TransposedMatrix
    {
        public static void Main()
        {
            const string MsgRows = "Quantes files vols que tingui la matriu?";
            const string MsgCols = "Quantes columness vols que tingui la matriu?";
            const string MsgValors = "Comencem a introduir els valors: ";
            const string MsgMatriuOriginal = "Matriu original:";
            const string MsgMatriuTrasposada = "Matriu trasposada:";

            int rows = 0, cols = 0;
            
            Console.WriteLine(MsgRows);
            rows  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgCols);
            cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows,cols];

            //inserció de dades en matriu
            Console.WriteLine(MsgValors);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //mostra de dades de la matriu original per consola
            Console.WriteLine(MsgMatriuOriginal);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            //mostra de dades de la matriu trasposada per consola
            Console.WriteLine(MsgMatriuTrasposada);
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

