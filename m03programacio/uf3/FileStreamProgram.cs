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
            using FileStream fs = File.OpenRead(path);
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            int readLen;
            while ((readLen = fs.Read(b, 0, b.Length)) > 0)
            {
                Console.WriteLine(temp.GetString(b, 0, readLen));
            }
        }
    }
}
