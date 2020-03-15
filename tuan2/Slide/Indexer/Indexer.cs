using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Indexer
    {
        private int[] myArray = new int[100];

        public int this[int index]

        {

            get

            {

                if (index < 0 || index >= 100)

                    return 0;

                else

                    return myArray[index];

            }

            set

            {

                if (!(index < 0 || index >= 100))

                    myArray[index] = value;

            }

        }
    }
}
