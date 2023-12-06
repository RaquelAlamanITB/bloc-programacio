/*
* Author: Sandro Antonucci - Jesús Gomez - Joaquín Alcázar
* M03. Programació UF1
* v1. 13/11/2023
* Exercici X. Enunciat de l’exercici que es resol
*
*/


using System;

namespace MyApplication
{

    class exercici8
    {
        static void Main()
        {

            string s, s2;

            s = Console.ReadLine();
            s2 = Console.ReadLine();

            foreach (char i in s2)
            {
                s = s.Replace(i, '\0');
            }

            Console.WriteLine(s);

        }
    }

}