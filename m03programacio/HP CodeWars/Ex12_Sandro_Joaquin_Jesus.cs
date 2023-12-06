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

    class exercici6
    {
        static void Main()
        {

            double sum = 0;
            int approved = 0;
            double[] grades = new double[5];


            for(int i = 0; i < 5; i++)
            {
                grades[i] = Convert.ToDouble(Console.ReadLine());
                sum += grades[i];
            }

            for(int i = 0; i < 5; i++)
            {
                if (grades[i] < sum / 5)
                {
                    approved++;
                }
            }
            Console.WriteLine(approved);

        }
    }

}