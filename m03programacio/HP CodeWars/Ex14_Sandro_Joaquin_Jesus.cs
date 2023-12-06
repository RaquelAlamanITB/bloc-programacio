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

    class exercici7
    {
        static void Main()
        {

            int num, binary = 0;

            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                if (num / 2 == 0)
                {
                    binary--;
                }


                num /= 2;

                binary++;
            }

            

            Console.WriteLine(binary);

        }
    }

}