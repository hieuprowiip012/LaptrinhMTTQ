using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Listener
    {
       
        public void GetNotified(string sInfo)
        {
            Console.WriteLine("I got notified with the following information {0}", sInfo);
            Console.ReadKey();
        }   
        public static void GetNotifiedAgain(string sInfo)
        {
            Console.WriteLine("I got notified with the following information2:{0}",sInfo);
            Console.ReadKey();
        }
    }
}
