using System;

namespace oop
{
    public class Director : Person
    {
        private string film;

        public string Film
        {
            get { return film; }
            set { film = value; }
        }
        public Director(string name, string surname, string film) : base(name, surname)
        {
            Film = film;
        }

        public override string GetFullName()
        {
            return Name + " " + Surname + ": " + Film;
        }

        public void Direct()
        {
            throw new System.NotImplementedException();
        }
    }
}