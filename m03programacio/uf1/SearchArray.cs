using System;

namespace Projects
{
    public class IsInArray
    {
        public static void Main()
        {
            const string MsgOK = "Algú ha tret un 10.";
            const string MsgKO = "Ningú no ha tret un 10";

            int i = 0;
            int[] marks = new int[] { 3, 0, 7, 10, 4, 6, 8, 3, 2, 1, 1, 10 };
            bool found = false;
            
            //mentre no hagi trobat el valor i no hagi arribat al final de l'array
            while ((i < marks.Length) && (!found))
            {
                if (marks[i] == 10)
                {
                    found = true;
                }
                i++;
            }
            //s'ha trobat?
            Console.WriteLine(found ? MsgOK : MsgKO);           
        }
    }
}

