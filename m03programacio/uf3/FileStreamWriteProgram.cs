using System;
using System.IO;
using System.IO.Pipes;
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
            string path = Path.GetFullPath("..\\..\\..\\files\\" + file);
            using FileStream fs = File.Create(path);

            byte[] info = new UTF8Encoding(true).GetBytes("Escriptura des de FileStream");
            fs.Write(info, 0, info.Length);
        }
    }
}
