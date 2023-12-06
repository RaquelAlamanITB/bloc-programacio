using System;

namespace Project 
{
    public class Validate 
    {       
        public static void Main()
        {
			const string UserAgeMsg = "Introdueix la teva edat";
			const string UserNameMsg = "Introdueix el teu nom";
            int userAge;
            string userName = "";
            Console.WriteLine(UserNameMsg);
            userName  = Console.ReadLine();
            Console.WriteLine(userName);
            userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 5)
            {
                Console.WriteLine(PrintMessage(userName));
            }
            else if (userAge >= 5 && userAge < 18)
            {
                Console.WriteLine(PrintMessage(true, userName));
            }
            else 
            {
                Console.WriteLine(PrintMessage(userAge, userName));
            }

        }

        public static string PrintMessage(string userName) { 
            return $"Hola {userName}!";
        }

        public static string PrintMessage(int userAge, string userName)
        {
            return $"Hola {userName}!Tens {userAge} anys.";
        }

        public static string PrintMessage(bool userMinor, string userName)
        {
            return userMinor? $"Hola {userName}!En ser menor d’edat, necessites autorització signada." : PrintMessage(userName);
        }
    }
}