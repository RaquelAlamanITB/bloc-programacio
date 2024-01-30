using System;

namespace oopsecond
{
    public class Dog : AAnimal, IPoint
    {
        public Dog(float weight, string name) { 
            this.Weight = weight;
            this.Name = name;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public double Distance(int X, int Y)
        {
            return (X + Y)/2;
        }

        public override void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public override void Move()
        {
            Console.WriteLine("Moving...");
        }
    }
}
