using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Point

    {

        public int x, y;

        public Point(int p1, int p2)

        {

            x = p1;

            y = p2;

        }

        public int Add()

        {

            return x + y;

        }

    }
}
