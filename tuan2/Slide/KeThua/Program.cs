using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class Program
    {
        static void Main(string[] args)
        {


            MicrosoftSoftware objMS = new MicrosoftSoftware();



            IBMSoftware objIBM1 = new IBMSoftware(50);



            IBMSoftware objIBM2 = new IBMSoftware("test", 75);



            Console.ReadLine();
        }
    }
}
