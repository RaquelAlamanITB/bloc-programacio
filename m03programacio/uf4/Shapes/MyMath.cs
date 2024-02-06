using System;

namespace Shapes
{
    public static class MyMath
    {
        //Atributs o camps estàtics
        public const double PI = 3.14_15_92_65;
        public const double E = 2.71828;

        private static Random Rnd = new Random();

        //Mètodes o operacions estàtiques
        public static bool IsEven(int value) => value % 2 == 0;

        public static bool IsOdd(int value) => !IsEven(value);

        public static int Abs(int value) => value > 0 ? value : -value;

        public static int NextInt(int bound) => Rnd.Next(bound + 1);
    }
}
