using System;

namespace Shapes
{
    public class Square : Shape2D
    {
        public double Side { get; set; }
        public Square(double side, Colour foreColour, Colour backgroundColour) : base(foreColour, backgroundColour)
            => this.Side = side;
        public Square(Colour foreColour, Colour backgroundColour) : this(DefaultSize, foreColour, backgroundColour) { }

        public override double GetPerimeter() => this.Side * 4;
        public override double GetArea() => Math.Pow(this.Side, 2);
    }
}
