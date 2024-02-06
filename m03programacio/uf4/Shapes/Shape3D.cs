using System;

namespace Shapes
{
    public abstract class Shape3D : Shape
    {
        protected Shape3D(Colour foreColour, Colour backgroundColour) : base(foreColour, backgroundColour){}
        public abstract double GetVolume();
    }
}