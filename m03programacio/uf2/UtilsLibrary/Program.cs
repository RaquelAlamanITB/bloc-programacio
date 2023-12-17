using UtilsLibrary;

namespace MyNamespace
{
    public class Programa

    {
        public static void Main()
        {
            int num;
            const string Msg = "Introdueix un valor natural";
            const string MsgResult = "El valor introduït és: {0}";
            do
            {
                Console.WriteLine(Msg);
                num = Convert.ToInt32(Console.ReadLine());
            } while (!Utils.ValidateNum(num));
            Console.WriteLine(MsgResult, num);
        }
    }
}