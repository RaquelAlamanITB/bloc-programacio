using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;


namespace oop
{
    public class Productor : AbstractPerson, IPerson
    {
        //expression bodied property
        public override string Name { get => name; set => name = value; }
        //expression bodied property
        public override string Surname { get => name; set => name = value; }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }

        public override string GetFullName()
        {
            return "Nom: " + Name;
        }
    }
}
