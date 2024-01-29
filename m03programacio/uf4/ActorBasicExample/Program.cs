using System;

namespace oop {
    public class Program { 
        public static void Main() {
            Actor firstActor = new Actor("Keanu", "Reeves");
            Actor secondActor = new Actor("Pratt");
            Console.WriteLine(firstActor.GetFullName());
            Console.WriteLine(secondActor.GetFullName());
        }
    }
}
