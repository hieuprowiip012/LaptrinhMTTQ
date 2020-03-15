using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();

            Point p2 = new Point(10, 10);



            Console.Write(" Point 1:   ");

            Console.WriteLine("x = {0}, y = {1}", p1.x, p1.y);



            Console.Write(" Point 2: ");

            Console.WriteLine("x = {0}, y = {1}", p2.x, p2.y);



            Console.WriteLine("Call Add method: {0}", p2.Add());

            Console.ReadLine();
        }
    }
}
