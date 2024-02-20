using System;

namespace enums
{
    public class Teacher : APerson
    {
        public float Salary { get; set; }
        public Teacher(string name, string surname, Type sort, float salary) 
                                : base(name, surname, sort) => Salary = salary;

        public override string? ToString() => $"Nom: {this.Name}; " +
                                              $"Cognoms: {this.Surname}; " +
                                              $"Rol: {this.Sort}; " +
                                              $"Sou: {this.Salary} euros";
    }
}
