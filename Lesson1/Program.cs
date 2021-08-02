using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer;

            Console.WriteLine("Введи своё имя");
            namePlayer = Console.ReadLine();
            
            Console.WriteLine("Привет " + namePlayer);

        }
    }
}
