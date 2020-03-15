using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Base obj = new Base();

            obj.Print();



            ITest ib = (ITest)obj;

            ib.Print();

 

            Base ojB = (Base)ib;

            ojB.Print();

            Console.ReadLine();


        }
    }
}
