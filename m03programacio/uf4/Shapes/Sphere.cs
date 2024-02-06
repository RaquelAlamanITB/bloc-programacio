using System;

namespace Shapes
{
    public class Sphere : Shape3D
    {
        public double Radius;
        public Sphere(double radius, Colour foreColour, Colour backgroundColour) : base(foreColour, backgroundColour)
        {
            this.Radius = radius;
        }
        public override double GetArea() => 4 * MyMath.PI * Math.Pow(this.Radius, 2);
        public override double GetVolume() => (4.0 / 3.0) * MyMath.PI * Math.Pow(this.Radius, 3);
    }
}