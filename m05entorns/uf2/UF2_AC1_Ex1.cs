using System;

namespace Testing{
    public class Validate 
    {
        public static void Main()
        {
            const string Msg = "Introdueix un valor natural";
			int num;
            Console.WriteLine(Msg);
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num > 0 ? true : false);
        }
    }
}