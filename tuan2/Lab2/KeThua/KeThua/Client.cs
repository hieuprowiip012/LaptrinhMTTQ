using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class Client
    {

        static void Main(string[] args)
        {
            Base b;
            Derived d;  
            d = new Derived("test");
            b = d;
            b.Method2();  
            d.Method2();;
        }
    }
}
