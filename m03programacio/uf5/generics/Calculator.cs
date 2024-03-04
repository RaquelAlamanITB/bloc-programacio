using System;


namespace generics
{
    public class Calculator<T>
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
