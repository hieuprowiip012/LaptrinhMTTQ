using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();

            a1.Talk();

            Dog d1 = new Dog();

            d1.Talk();

            Console.ReadLine();
        }
    }
}
