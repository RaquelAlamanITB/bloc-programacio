using System;

namespace Modules
{
    public class BasicMethods
    {
        public static void Main()
        {
            int firstNum, secondNum;
            int[] marks = new int[] { 1, 3, 2, 5, 6 };
            const string Msg = "Introdueix un valor natural:";

            do
            {
                Console.WriteLine(Msg);
                firstNum = Convert.ToInt32(Console.ReadLine());
            } while (!IsPositive(firstNum));

            do
            {
                Console.WriteLine(Msg);
                secondNum = Convert.ToInt32(Console.ReadLine());
            } while (!IsPositive(secondNum));

            Console.WriteLine($"El resultat de la suma és {AddTwoNumbers(firstNum, secondNum)}");
            Console.WriteLine($"{firstNum} elevat a {secondNum} és igual a {PowNumber(firstNum, secondNum)}");
            Console.WriteLine(ToUpper(false, "Hola que Tal"));

            Avg(marks);

            Console.WriteLine(NomDelMes(4));
        }

        public static string NomDelMes(int mes)
        {
            //switch expression
            string month = mes switch
            {
                1 => "Gener",
                2 => "Febrer",
                3 => "Març",
                4 => "Abril",
                5 => "Maig",
                6 => "Juny",
                7 => "Juliol",
                8 => "Agost",
                9 => "Setembre",
                10 => "Octubre",
                11 => "Novembre",
                12 => "Desembre",
                _ => "Valor invàlid"
            };
            return month;
        }

        public static bool IsPositive(int num)
        {
            return num > 0;
        }

        public static int AddTwoNumbers(int first, int second)
        {
            return first + second;
        }

        public static int PowNumber(int baseNum, int exp)
        {
            int result = 1;
            for (int i = 0; i < exp; i++)
            {
                result *= baseNum;
            }
            return result;
        }

        public static string ToUpper(bool upper, string text)
        {
            return upper ? text.ToUpper() : text.ToLower();
        }

        public static void Avg(int[] marks)
        {
            float sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            Console.WriteLine($"La mitjana és {sum / marks.Length}");
        }

    }
}