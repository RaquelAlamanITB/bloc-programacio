using System;
namespace ArgsParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ParseArgs(args);
            Console.WriteLine(GetConsole(args[0], args[1]));
            SumArgs(args);
         
        }
        public static void SumArgs(string[] args)
        {
            Console.WriteLine("Suma: {0}", Convert.ToInt32(args[0]) + Convert.ToInt32(args[1]));
        }
        public static void ParseArgs(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
        public static string GetConsole(string arg, string inArg)
        {
            return arg.Contains(inArg) ? "Sí que el conté" : "No el conté";
        }
    }
}