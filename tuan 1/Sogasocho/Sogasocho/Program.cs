using System;

namespace Sogasocho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************So ga So Cho*******************");
            Console.Write("Vua ga vua cho\n");
            Console.Write("Bo lai cho tron\n");
            Console.Write("Ba muoi sau(36) con\n");
            Console.Write("Mot tram(100) chan chan\n");
            Console.WriteLine("Hoi may ga, may cho?\n");
            for (int i = 9; i <= 25; i++)
            {
                if ((2 * i + (36 - i) * 4) == 100)
                {
                    Console.WriteLine("So ga la: " + i);
                    Console.WriteLine("So cho la: " + (36 - i));
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
