/*
* Author: Miroslav Magerov, Tomas Vicente, Manel Arbiol
* M03. Programació UF1
* v1. 13/11/23
* Exercici 1.
*/

namespace Project
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            int oneWayTicketPrice, returnTicketCost, totalCost;

            oneWayTicketPrice = Convert.ToInt32(Console.ReadLine());
            returnTicketCost = Convert.ToInt32(Console.ReadLine());

            totalCost = oneWayTicketPrice + returnTicketCost;

            Console.WriteLine($"Ana should save a total of {totalCost} euros.");
        }
    }
}