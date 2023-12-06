using System;
namespace Projects {
    public class SaveMarks { 
        public static void Main()
        {
            const int ROWS = 4, COLS = 6;
            const string Msg = "Introdueix la nota per al MP:";
            int[,] numbers = new int[ROWS,COLS];

            //inserció de dades en matriu bidimendional
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(Msg);
                    numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //lectura de dades de matriu bidimensional
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    } 
}

