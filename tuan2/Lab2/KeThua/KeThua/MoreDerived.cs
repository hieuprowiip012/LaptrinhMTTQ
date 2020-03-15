using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class MoreDerived : Derived
    {
        public MoreDerived() : base("DEFAULT")
        {
            Console.WriteLine("In MoreDerived Constructor!");
        }
    }
}
