using System;

namespace generics
{
    public class Program 
    {
        public static void Main() 
        {
            // Invoke the generic method
            Console.WriteLine("**************************************");
            Classe.Display<int>("Integer: ", 122);
            Classe.Display<char>("Character: ", 'H');
            Classe.Display<double>("Decimal: ", 255.67);
            Classe.Display<string>("String: ", "Hello World");

            // Create a new instance of the generic class
            Console.WriteLine("**************************************");
            Space<int> spaceInt = new Space<int>(0, 0, 1920, 1280);
            Space<double> spaceDoub = new Space<double>(0.0, 0.0, 50.0, 75.5);
            Console.WriteLine(spaceInt.ToString());
            Console.WriteLine(spaceDoub.ToString());
        }
    }
}