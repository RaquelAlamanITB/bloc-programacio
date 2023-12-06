using System;
namespace Solutions {
    public class Solution 
    {
        public static void Main()
        {
            Validate(5);
        }

        public static void Validate(int num) {
            Console.WriteLine(num > 0 ? "És natural" : "No és natural");
        }
    }  
}
