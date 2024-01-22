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
            string path = Path.GetFullPath("..\\..\\..\\files\\" + file);
            if (!File.Exists(path))
            {
                string createText = "Hello world!" + Environment.NewLine;
                File.WriteAllText(path, createText);

                string appendText = "Nova línia" + Environment.NewLine;
                File.AppendAllText(path, appendText);
            }
        }
    }
}
