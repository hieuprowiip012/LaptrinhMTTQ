using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ITest
    {
        void Print();

    }

    class Base : ITest

    {

        public void Print()

        {

            Console.WriteLine("Print method called");

        }
    }
}
