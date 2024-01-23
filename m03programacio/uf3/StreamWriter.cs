using System;
using System.IO;

namespace FileHandling
{
    public class Program
    {
        public static void Main()
        {
            FileHandling("file.txt");
        }

        public static void FileHandling(string file)
        {
            string path = Path.GetFullPath(@"..\..\..\files\" + file);
            //using StreamWriter sw = new StreamWriter(path);
            //sw.WriteLine("Escriptura amb StreamWriter ");

            using StreamWriter sw = new StreamWriter(path, append: true);
            sw.WriteLine("Escriptura amb StreamWriter en mode Append");
        }
    }
}