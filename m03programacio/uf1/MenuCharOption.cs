/* 
 * Author: Raquel Alamán
 * M03. Programació UF1
 * v1. 09/10/2023
 * Mostra un menú amb diferents opcions (indicades per un caràcter). 
 * 
 */

using System;
namespace Project
{
    class MyExercises 
    {
        static void Main()
        {
            const int Min = 1, Max = 10;
            const string Msg = "Escull una de les següents opcions:";
            const string Menu = "A. Saludar\nB. Mostrar taula\nC. Calcular mitjana\nS. Sortir";
            const string MsgGreeting = "Com et dius?";
            const string TxtGreeting = "Hola, ";
            const string TxtAvg = "La mitjana dels 10 primers nombres naturals és: ";
            const string MsgBye = "Adéu";
            const string MsgK0 = "Error";

            int sum = 0;
            char option;
            string name;

            Console.WriteLine(Msg);
            Console.WriteLine(Menu);
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case 'a': case 'A':
                    Console.WriteLine(MsgGreeting);
                    name = Console.ReadLine();
                    Console.WriteLine(TxtGreeting + name);
                    break;
                case 'b': case 'B':
                    for (int i = Min; i < Max; i++)
                    {
                        for (int j = Min; j < Max; j++)
                        {
                            Console.Write(i * j + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 'c': case 'C':
                    for (int i = Min; i <= Max; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine(TxtAvg + (sum / (float)Max));
                    break;
                case 's': case 'S':
                    Console.WriteLine(MsgBye);
                    break;
                default:
                    Console.WriteLine(MsgK0);
                    break;
            }
        }
    }
}


