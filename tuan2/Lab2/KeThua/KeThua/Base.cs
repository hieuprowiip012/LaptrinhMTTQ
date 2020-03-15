using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("In Base Constructor!");
            Console.ReadKey();
        }
        public virtual void Method1()
        {
            Console.WriteLine("In Base.Method1");
            Console.ReadKey();
        }

        public void Method2()
        {
            Console.WriteLine("In Base.Method2");
            Console.ReadKey();
        }
    }
}
