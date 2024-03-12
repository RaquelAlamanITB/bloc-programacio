using collections;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace MyNamespace
{
    public class Program
    {
        public delegate void MyDelegate(int i);
        public delegate int MyDelegate2(int x, int y);
        public delegate int MyDelegate3(int x, int y);
        public static void Main()
        {
            MyClass mClass = new MyClass();
            MyDelegate delegat = new MyDelegate(mClass.MyMethod);
            delegat(83);
            MyDelegate2 delegat2 = new MyDelegate2(mClass.Add);
            Console.WriteLine(delegat2(3, 5));
            MyDelegate3 delegat3 = mClass.Multiply;
            Console.WriteLine(delegat3(3, 5));

            MyDelegate3 delegat4 = delegate (int x, int y){ return x * y; };
            Console.WriteLine(delegat4(3, 5));

            MyDelegate3 delegat5 = (x, y) => x * y;
            Console.WriteLine(delegat5(3,4));

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            var lamdable = new Lamdable();
            Console.WriteLine(lamdable.Add(3, 5));

            MyDelegate3 lamdable2 = (x, y) => x + y;

            var emails = new List<string>()
           {
                "admin@gmail.com",
                "admin@gmail",
                "2gmail.com",
                "test@hotmail.com"
            };

            // creem un predicat que apunta al mètode EmailIsValid
            Predicate<string> predicate = new Predicate<string>(Helper.EmailIsValid);

            // fem servir el mètode FindAll per trobar tots els elements que compleixen el predicat
            var validEmails = emails.FindAll(predicate);

            // recorrem la llista de emails vàlids
            foreach (var email in validEmails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("*********************** Versió amb mètode anònim *****************************");
            Predicate<string> predicateAnonymous = new Predicate<string>(
                     delegate (string email)
                     {
                         string pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                         return Regex.IsMatch(email, pattern);
                     });

            var validEmailsAnonymous = emails.FindAll(predicateAnonymous);

            foreach (var item in validEmailsAnonymous)
            {
                Console.WriteLine(item);
            }
        }
    }

}