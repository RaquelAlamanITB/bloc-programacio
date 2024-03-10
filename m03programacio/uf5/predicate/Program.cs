using collections;

namespace MyNamespace
{
    public class Program
    {
        public static void Main()
        {
            var emails = new List<string>()
           {
                "admin@gmail.com",
                "admin@gmail",
                "2gmail.com",
                "test@hotmail.com"
            };

            Predicate<string> predicate = new Predicate<string>(Helper.EmailIsValid);

            var validEmails = emails.FindAll(predicate);

            Console.WriteLine("Les adreces de correu vàlides són: ");

            foreach (var email in validEmails)
            {
                Console.WriteLine(email);
            }
        }
    }

}