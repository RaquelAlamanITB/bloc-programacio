using System;

namespace Shapes
{
    public class Program
    {
        public static void Main()
        {
            try {
                Circle circle = new Circle(5, new Colour("Red", 255, 0, 0), new Colour("Green", 0, 255, 0));
                Console.WriteLine($"Àrea del cercle: {circle.GetArea()}");
                Console.WriteLine($"Circumferència del cercle: {circle.GetPerimeter()}");
            } catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            
            Colour colour = new Colour("Blue", 0, 0, 255);
            Console.WriteLine($"Color: {colour.ToRGB(true)}");
            Console.WriteLine($"Total de colors: {Colour.GetCounter()}");
            var prova = Colour.Random();
            Console.WriteLine($"Color: {prova.ToRGB()}");
            Console.WriteLine($"Total de colors: {Colour.GetCounter()}");

            Square square = new Square(5, new Colour("Red", 255, 0, 0), new Colour("Green", 0, 255, 0));
            Console.WriteLine($"Àrea del quadrat: {square.GetArea()}");
            Console.WriteLine($"Perímetre del quadrat: {square.GetPerimeter()}");
        }
    }
}
