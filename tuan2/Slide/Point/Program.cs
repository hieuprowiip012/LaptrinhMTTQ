using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point objP1 = new Point(1, 1);

            Point objP2 = new Point(2, 2);

            Point objResult = new Point();

            objResult = objP1 + objP2;

            Console.WriteLine("The result is m_x = {0} and m_y = {1}",

            objResult.m_x, objResult.m_y);

            Console.ReadLine();
        }
    }
}
