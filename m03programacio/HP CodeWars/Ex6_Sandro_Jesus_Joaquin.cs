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

    class exercici4
    {
        static void Main()
        {

            int firstNum;

            firstNum = Convert.ToInt32(Console.ReadLine());

            for(int i = firstNum; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
        }
    }

}