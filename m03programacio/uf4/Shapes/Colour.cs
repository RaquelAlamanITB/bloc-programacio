using System;

namespace Shapes
{
    public class Colour
    {
        public string? Name;
        public int Red;
        public int Green;
        public int Blue;

        private static int counter = 0;
        public const int MinValue = 0;
        public const int MaxValue = 255;
        public const string DefaultName = "No name";

        
        public Colour(string name, int red, int green, int blue)
        {
            this.Name = name;
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            counter++;
        }
        public Colour(int red, int green, int blue) : this (DefaultName, red, green, blue) {}

        public Colour() : this (DefaultName, MaxValue, MaxValue, MaxValue) {}

        public static int GetCounter() => counter;
        /// <summary>
        /// Mètode que retorna una cadena amb els valors RGB d'un color
        /// </summary>
        /// <param name="upper">Si T transforma la cadena RGB a majúscules </param>
        /// <returns>Retorna la cadena amb format RGB(R,G,B) del color</returns>
        public string ToRGB(bool upper) => (upper ? "RGB" : "rgb") + "(" + this.Red + "," + this.Green + "," + this.Blue + ")";
        /// <summary>
        /// Mètode que retorna una cadena amb els valors RGB d'un color
        /// </summary>
        /// <param name="upper">Si T transforma la cadena RGB a minúscules </param>
        /// <returns>Retorna la cadena amb format rgb(R,G,B) del color</returns>
        public string ToRGB() => ToRGB(false);
        /// <summary>
        /// Mètode que retorna una instància de color aleatori
        /// </summary>
        /// <returns>Retorna un nou color de valors RGB aleatoris</returns>
        public static Colour Random() => new Colour(MyMath.NextInt(MaxValue), 
            MyMath.NextInt(MaxValue), MyMath.NextInt(MaxValue));
    }
}