using System;

namespace enums {
    public class Program {
        public static void Main()
        {
            Teacher teacher = new Teacher("Maria", "Garcia", Type.Docent, 35000f);
            Console.WriteLine(teacher.ToString());
            Student student = new Student("Pere", "Martinez", Type.Estudiant, "A1");  
            Console.WriteLine(student.ToString());
        }
    }
}