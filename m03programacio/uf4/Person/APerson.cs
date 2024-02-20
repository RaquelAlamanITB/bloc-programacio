using System;
namespace enums
{
    public enum Type
    {
        Docent,
        Estudiant,
        PAS
    }
    public class APerson
    {
        public string? Name { get; set; }
        public string?  Surname { get; set; }
        public Type Sort { get; set; }
        public APerson(string name, string surname, Type sort)
        {
            Name = name;
            Surname = surname;
            Sort = sort;
        }
    }
}
