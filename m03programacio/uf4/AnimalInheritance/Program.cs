using System;

namespace oopsecond
{
    public class Program
    {
        public static void Main()
        {
            Animal animal = new Animal(10, "Animal");
            Console.WriteLine(animal.GetFullInfo());
            Console.WriteLine("----------------------------------------");

            Cat cat = new Cat(5, "Cat");
            Console.WriteLine(cat.GetFullInfo());
            Console.WriteLine($"Distance covered: {cat.Distance(5, 5)}");

            Console.WriteLine("----------------------------------------");

            Dog dog = new Dog(20.5f,"Dog");
            Console.WriteLine(dog.Name);
            dog.Eat();
            Console.WriteLine($"Distance covered: {dog.Distance(5, 5)}");
        }
    }
}
