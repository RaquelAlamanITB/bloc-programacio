using System;

public class Example
{
    public static void Main()
    {
        const string Msg = "Introdueix un text:";
        Console.WriteLine(Msg);
        string inputText = Console.ReadLine();
        char[] chars = new char[inputText.Length];  

        Console.WriteLine(inputText.ToUpper()); //Conversió tot a majúscules
        Console.WriteLine(inputText.ToLower()); //Conversió tot a minúscules

        //capitalització (conversió de les primeres lletres de cada paraula a majúscula)
        chars[0] = char.ToUpper(inputText[0]);
        for (int i = 1; i < inputText.Length; i++)
        {
            if (inputText[i - 1] == ' ')
            {
                chars[i] = char.ToUpper(inputText[i]);
            }
            else
            {
                chars[i] = inputText[i];
            }
        }
        //mostra per consola cada paraula transformada
        for (int i = 0; i < chars.Length; i++)
        {
            Console.Write(chars[i]);
        }
    }
}