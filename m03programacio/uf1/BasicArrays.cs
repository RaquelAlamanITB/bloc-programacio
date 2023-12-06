using System;
namespace Projects {
    public class SaveNumbers { 
        public static void Main()
        {
            const int Size = 5;
            const string Msg = "Introdueix un número:";

            int i = 0;

            int[] arrayNums = new int[Size];

            //assignació de valors en array amb loop: while
            while (i < Size)
            {
                Console.WriteLine(Msg);
                arrayNums[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }

            //assignació de valors en array amb loop: do-while
            i = 0;
            do
            {
                Console.WriteLine(Msg);
                arrayNums[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            } while (i < Size);

            //assignació de valors en array amb loop: for
            for (int j = 0; j < Size; j++)
            {
                arrayNums[j] = Convert.ToInt32(Console.ReadLine());
            }

            //lectura de valors emmagatzemats en un array amb loop: for
            for (int j=0; j< Size; j++) {
                Console.Write(arrayNums[j] + " ");
            }
        }
    } 
}

