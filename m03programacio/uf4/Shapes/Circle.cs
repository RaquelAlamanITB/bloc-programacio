using System;

namespace Shapes
{
    public class Circle : Shape2D
    {
        public double Radius;
      
        public Circle(double radius, Colour foreColour, Colour backgroundColour) : base(foreColour, backgroundColour) 
            => SetRadius(radius);
        public void SetRadius(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Radius must be greater than 0");
            this.Radius = radius;
        }
        public override double GetArea() => MyMath.PI * Math.Pow(this.Radius, 2);
        public override double GetPerimeter() => 2 * MyMath.PI * this.Radius;
    }
}