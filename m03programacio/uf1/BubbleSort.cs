using System;

namespace Projects
{
    public class IsInArray
    {
        public static void Main()
        {
            const string FirstMsg = "Array sense ordenar:";
            const string SecondMsg = "Array ordenat:";

            int[] marks = new int[] { 3, 0, 7, 10, 4, 6, 8, 3, 2, 1, 1, 10 };

            Console.WriteLine(FirstMsg);
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < marks.Length - 1; i++)
            {
                //bucle intern, cerca entre la resta de posicions quin és el valor més baix
                for (int j = i + 1; j < marks.Length; j++)
                {
                    //si la posició tractada té un valor més alt que el de la cerca, els intercanviem
                    if (marks[i] > marks[j])
                    {
                        //per intercanviar valors cal una variable auxiliar
                        int aux = marks[i];
                        marks[i] = marks[j];
                        marks[j] = aux;
                    }
                }
            }

            Console.WriteLine(SecondMsg);
            for (int i = 0; i< marks.Length; i++) 
            {
                Console.Write(marks[i] + " ");
            }

        }
    }
}

