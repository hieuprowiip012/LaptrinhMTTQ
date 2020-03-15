using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingMethod
{
    class Animal
    {


        public Animal()

        {

            Console.WriteLine("Animal constructor");

        }

        public void Talk()

        {

            Console.WriteLine("Animal talk");

        }



    }

    class Dog : Animal

    {

        public Dog()

        {

            Console.WriteLine("Dog constructor");

        }

        public new void Talk()

        {

            Console.WriteLine("Dog talk");

        }
    }
}
