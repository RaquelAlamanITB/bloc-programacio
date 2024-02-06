using System;

namespace Shapes
{
    public abstract class Shape
    {   
        protected Colour ForeColour;
        protected Colour BackgroundColour;
        public static double DefaultSize = 1.0D;

        public Shape(Colour foreColour, Colour backgroundColour)
        {
            ForeColour = foreColour;
            BackgroundColour = backgroundColour;
        }
        public abstract double GetArea();
    }
}