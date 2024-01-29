namespace oop
{
    public class Actor
    {
        private string? name;
        private string? surname;

        public Actor(string name, string surname) {
            this.SetName(name);
            this.SetSurname(surname);
        }
        public string? GetName() {
            return this.name;
        }
        public void SetName(string name) {
            this.name = name;
        }

        public string? GetSurname()
        {
            return this.surname;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public string GetFullName() { 
            return this.GetSurname() + ", " + this.GetName();
        }
    }
}