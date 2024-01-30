using System;

namespace oopsecond
{
    public class Cat : Animal, IPoint
    {
        public Cat(float weight, string name) : base(weight, name)
        {
            this.Weight = weight;
            this.Name = name;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public double Distance(int X, int Y)
        {
            return X*Y;
        }

        public override string GetFullInfo()
        {
            return "Cat implementation: " + this.Name + " " + this.Weight;
        }
    }
}
