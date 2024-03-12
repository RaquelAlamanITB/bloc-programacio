using System;

namespace collections
{
    public class MyClass 
    {
        public void MyMethod(int i)
        {
            Console.WriteLine("El valor passat com a paràmetre és: {0}", i);
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}
