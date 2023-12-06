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

    class exercici2
    {
        static void Main()
        {

            int firstNum, secondNum;

            firstNum = Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(secondNum - firstNum * 3);

        }
    }

}