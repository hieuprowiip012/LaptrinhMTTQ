using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Client
    {
        static void Main(string[] args)
        {
            IHuman h;
            Theodore t;
            h = new Theodore();   
            t = (Theodore)h;  
            t.Name="Fred";
            t.Speak("I like public implementations!");   
            h.Name = "Teddy";
            h.Speak("I like VB!");
        }
    }
}
