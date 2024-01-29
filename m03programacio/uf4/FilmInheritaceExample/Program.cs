using System;

namespace oop {
    public class Program { 
        public static void Main() {
            Person person = new Person("Miquel", "Garcia");
            Console.WriteLine(person.GetFullName());

            Actor ac = new Actor("Keanu", "Reeves", "John Wick");
            Actor ac2 = new Actor("Tom", "Hardy", "Venom");
            Actor ac3 = new Actor("Chris", "Pratt", "Jurassic World");
            Console.WriteLine(ac.GetFullName());

            Productor pr = new Productor();
            pr.Name = "Steven Spielberg";
            Console.WriteLine(pr.GetFullName());
            pr.DisplayName();
            
        }
    }
}
