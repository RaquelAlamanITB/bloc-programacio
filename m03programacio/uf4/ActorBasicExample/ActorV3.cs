namespace oop
{
    public class Actor
    {
	//propietat: mètode per realitzar operacions sobre els atributs
        //des de c# 3 
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public Actor(string name, string surname) { 
            Name = name;
            Surname = surname;
        }
        public string GetFullName() { 
            return Surname + ", " + Name;
        }
    }
}
