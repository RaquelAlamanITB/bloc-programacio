using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class Classe
    {

        public static void Display<T>(string msg, T value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }
    }
}
