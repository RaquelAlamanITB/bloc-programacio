using System;

namespace enums
{
    public class Student : APerson
    {
        public string? Grup { get; set; }
        public Student(string name, string surname, Type sort, string grup) 
                        : base(name, surname, sort) => Grup = grup;
        public override string? ToString()
        {
            return $"Nom: {this.Name}; Cognoms: {this.Surname}; Rol: {this.Sort}; Grup: {this.Grup}";
        }
    }
}
