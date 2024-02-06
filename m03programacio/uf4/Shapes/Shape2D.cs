using System;

namespace Shapes
{
    public abstract class Shape2D : Shape
    {
        protected Shape2D(Colour foreColour, Colour backgroundColour) : base(foreColour, backgroundColour){}
        public abstract double GetPerimeter();
    }
}