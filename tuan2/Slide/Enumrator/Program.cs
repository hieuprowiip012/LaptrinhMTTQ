using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumrator
{
    class Program
    {
      
            enum Days { monday, tuesday, wednesday, thursday, friday, saturday, sunday };

        static void Main(string[] args)

        {

            int x = (int)Days.sunday;

            int y = (int)Days.friday;

            Console.WriteLine("Sun = {0} : Value : {1}", x, Days.thursday + 1);

            Console.WriteLine("Fri = {0} : Value : {1}", y, Days.friday + 1);

            Console.ReadLine();

        }


    }
}

