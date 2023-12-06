/*
* Author: Miroslav Magerov, Tomas Vicente, Manel Arbiol
* M03. Programació UF1
* v1. 13/11/23
* Exercici 3.
*/

namespace Project
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            int GPUfreq, gameFreq, freqPerfectGames = 0;

            GPUfreq = Convert.ToInt32(Console.ReadLine());
            gameFreq = Convert.ToInt32(Console.ReadLine());

            while (gameFreq != 0)
            {
                if (GPUfreq > gameFreq)
                {
                    freqPerfectGames++;
                }
                gameFreq = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(freqPerfectGames);
        }
    }
}