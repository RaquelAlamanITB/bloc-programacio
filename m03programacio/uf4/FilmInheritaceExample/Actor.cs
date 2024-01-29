namespace oop
{
    public class Actor : Person
    {
        private string film;

        public string Film {
            get { return film; }
            set { film = value; }
        }
        public Actor(string name, string surname, string film) : base(name, surname)
        {
            Film = film;
        }

        public override string GetFullName() {
            return Name + " " + Surname + ": " + Film;
        }
    }
}