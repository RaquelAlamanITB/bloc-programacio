using System;
using System.IO;
using System.Text;

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
            using StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
