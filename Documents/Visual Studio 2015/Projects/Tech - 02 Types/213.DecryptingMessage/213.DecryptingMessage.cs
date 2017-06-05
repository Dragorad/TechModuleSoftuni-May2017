using System;


namespace _213.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < n; i++)
            {
                char  leterIndex = char.Parse(Console.ReadLine());
                char letter = (char)(leterIndex + key);
                message = message + letter;
            }

            Console.WriteLine(message);
        }
    }
}
